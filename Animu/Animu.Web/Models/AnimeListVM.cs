using Animu.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Animu.Web.Models
{
    public class AnimeListVM
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

        public AnimeListVM()
        {
            Id = Guid.NewGuid();
        }

        public AnimeListVM(Anime anime)
        {
            this.Id = anime.Id;
            this.Title = anime.Title;
            this.ImageUrl = anime.ImageUrl;
            this.Synopsis = anime.Synopsis;
        }

        public Anime ToAnime()
        {
            return new Anime()
            {
                Id = this.Id,
                Title = this.Title,
                ImageUrl = this.ImageUrl,
                Synopsis = this.Synopsis
            };
        }
    }
}
