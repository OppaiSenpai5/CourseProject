using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animu.Data.Entities
{
    public class Tag : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public ICollection<TagAnime> TagAnimes { get; set; }

        public Tag() : base() =>
            this.TagAnimes = new HashSet<TagAnime>();
    }
}
