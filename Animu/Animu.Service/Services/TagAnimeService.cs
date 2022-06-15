using Animu.Data.Entities;
using Animu.Service.Interfaces;
using Animu.Web.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animu.Service.Services
{
    public class TagAnimeService : ITagAnimeService
    {
        private readonly AnimuDbContext context;
        private readonly DbSet<TagAnime> tagAnimes;

        public TagAnimeService(AnimuDbContext context)
        {
            this.context = context;
            this.tagAnimes = this.context.TagAnimes;
        }

        public IEnumerable<TagAnime> GetAll() => this.tagAnimes.ToHashSet();

        public IEnumerable<TagAnime> GetByTagId(Guid tagId) =>
            this.tagAnimes.Where(ta => ta.TagId == tagId).ToHashSet();

        public IEnumerable<TagAnime> GetByAnimeId(Guid animeId) =>
            this.tagAnimes.Where(ta => ta.AnimeId == animeId).ToHashSet();
    }
}
