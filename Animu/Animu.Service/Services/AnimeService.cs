using Animu.Data.Entities;
using Animu.Service.Interfaces;
using Animu.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animu.Service.Services
{
    public class AnimeService : BaseService<Anime>, IBaseService<Anime>, IAnimeService
    {
        private readonly ITagAnimeService tagAnimeService;
        public AnimeService(AnimuDbContext context, ITagAnimeService tagAnimeService) : base(context)
        {
            this.tagAnimeService = tagAnimeService;
        }

        public IEnumerable<Anime> GetTagAnimes(Guid tagId)
        {
            IEnumerable<TagAnime> tagAnimes = this.tagAnimeService.GetByTagId(tagId);
            return (from ta in tagAnimes
                    join anime in GetAll()
                    on ta.AnimeId equals anime.Id
                    select anime).ToHashSet();
        }
    }
}
