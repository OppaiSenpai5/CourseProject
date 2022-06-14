using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animu.Data.Entities
{
    public class Episode : BaseEntity
    {
        [Required]
        public int Number { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [Url]
        public string VideoUrl { get; set; }
        [Required]
        public Guid AnimeId { get; set; }
        public Anime Anime { get; set; }
    }
}
