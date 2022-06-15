using Animu.Data.Entities;
using Animu.Service.Interfaces;
using Animu.Web.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animu.Service.Services
{
    public class AnimeService : BaseService<Anime>, IBaseService<Anime>, IAnimeService
    {
        public AnimeService(AnimuDbContext context) : base(context)
        {
        }

        public IEnumerable<Anime> GetTagAnimes(Guid tagId) =>
            this.context.TagAnimes
                        .Include(ta => ta.Anime)
                        .Where(ta => ta.TagId == tagId)
                        .Select(ta => ta.Anime)
                        .ToHashSet();
    }
}
