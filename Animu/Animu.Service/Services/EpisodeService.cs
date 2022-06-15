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
    public class EpisodeService : BaseService<Episode>, IBaseService<Episode>, IEpisodeService
    {
        public EpisodeService(AnimuDbContext context) : base(context)
        {
        }

        public IEnumerable<Episode> GetAnimeEpisodes(Guid animeId) =>
            this.dbSet.Where(e => e.AnimeId == animeId).ToHashSet();
    }
}
