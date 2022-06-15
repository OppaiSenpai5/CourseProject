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
    public class TagService : BaseService<Tag>, IBaseService<Tag>, ITagService
    {
        public TagService(AnimuDbContext context) : base(context)
        {
        }

        public IEnumerable<Tag> GetAnimeTags(Guid animeId) =>
            this.context.TagAnimes
                        .Include(ta => ta.Tag)
                        .Where(ta => ta.AnimeId == animeId)
                        .Select(ta => ta.Tag)
                        .ToHashSet();
    }
}
