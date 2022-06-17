using Animu.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animu.Web.Models
{
    public class TagAnimeVM
    {
        public Guid TagId { get; set; }
        public string TagName { get; set; }
        public ICollection<AnimeListVM> Animes { get; set; }

        public TagAnimeVM()
        {
            this.TagId = Guid.NewGuid();
            this.Animes = new HashSet<AnimeListVM>();
        }

        public TagAnimeVM(Tag tag, IEnumerable<Anime> animes)
        {
            this.TagId = tag.Id;
            this.TagName = tag.Name;
            this.Animes = animes.Select(a => new AnimeListVM(a))
                                .ToHashSet();
        }
    }
}
