using Animu.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animu.Service.Interfaces
{
    public interface IEpisodeService : IBaseService<Episode>
    {
        IEnumerable<Episode> GetAnimeEpisodes(Guid animeId);
    }
}
