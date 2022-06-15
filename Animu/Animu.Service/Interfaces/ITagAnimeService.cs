using Animu.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animu.Service.Interfaces
{
    public interface ITagAnimeService
    {
        IEnumerable<TagAnime> GetAll();
        IEnumerable<TagAnime> GetByTagId(Guid tagId);
        IEnumerable<TagAnime> GetByAnimeId(Guid tagId);
    }
}
