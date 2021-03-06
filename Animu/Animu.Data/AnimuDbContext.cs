using Animu.Data.Entities;
using Animu.Data.Seeder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animu.Web.Data
{
    public class AnimuDbContext : IdentityDbContext
    {
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<Anime> Animes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagAnime> TagAnimes { get; set; }

        public AnimuDbContext(DbContextOptions<AnimuDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Episode>()
                   .HasOne(e => e.Anime)
                   .WithMany(a => a.Episodes)
                   .HasForeignKey(e => e.AnimeId);

            builder.Entity<TagAnime>()
                   .HasKey(ta => new { ta.TagId, ta.AnimeId });

            builder.Entity<TagAnime>()
                   .HasOne(ta => ta.Tag)
                   .WithMany(t => t.TagAnimes)
                   .HasForeignKey(ta => ta.TagId);

            builder.Entity<TagAnime>()
                   .HasOne(ta => ta.Anime)
                   .WithMany(a => a.TagAnimes)
                   .HasForeignKey(ta => ta.AnimeId);

            builder.Entity<Episode>().HasData(Seeder.EpisodesSeed());
            builder.Entity<Anime>().HasData(Seeder.AnimesSeed());
            builder.Entity<Tag>().HasData(Seeder.TagsSeed());
            builder.Entity<TagAnime>().HasData(Seeder.TagAnimesSeed());
            builder.Entity<IdentityUser>().HasData(Seeder.UsersSeed());
            builder.Entity<IdentityRole>().HasData(Seeder.RolesSeed());
            builder.Entity<IdentityUserRole<string>>().HasData(Seeder.UserRolesSeed());
        }
    }
}
