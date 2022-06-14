using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animu.Data.Entities
{
    public class TagAnime
    {
        public Guid TagId { get; set; }
        public Tag Tag { get; set; }
        public Guid AnimeId { get; set; }
        public Anime Anime { get; set; }
    }
}
