using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animu.Data.Entities
{
    public class Anime : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        [Required]
        [Url]
        public string ImageUrl { get; set; }
        [Required]
        public string Synopsis { get; set; }
        public ICollection<TagAnime> TagAnimes { get; set; }
        public ICollection<Episode> Episodes { get; set; }

        public Anime() : base()
        {
            this.TagAnimes = new HashSet<TagAnime>();
            this.Episodes = new HashSet<Episode>();
        }
    }
}
