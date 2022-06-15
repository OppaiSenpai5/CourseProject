using Animu.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animu.Service.Interfaces
{
    public interface ITagService : IBaseService<Tag> 
    {
        IEnumerable<Tag> GetAnimeTags(Guid animeId);
    }
}
