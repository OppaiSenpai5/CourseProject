using Animu.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Animu.Web.Models
{
    public class AnimeDetailsVM
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [Url]
        public string ImageUrl { get; set; }
        [Required]
        public string Synopsis { get; set; }
        public ICollection<TagVM> Tags { get; set; }

        public AnimeDetailsVM()
        {
            this.Id = Guid.NewGuid();
        }

        public AnimeDetailsVM(Anime anime)
        {
            this.Id = anime.Id;
            this.Title = anime.Title;
            this.ImageUrl = anime.ImageUrl;
            this.Synopsis = anime.Synopsis;
        }
    }
}
