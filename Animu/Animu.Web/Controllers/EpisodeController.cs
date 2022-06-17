using Animu.Data.Entities;
using Animu.Service.Interfaces;
using Animu.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animu.Web.Controllers
{
    public class EpisodeController : Controller
    {
        private readonly AnimuDbContext context;
        private readonly UserManager<IdentityUser> userManager;
        private readonly IEpisodeService episodeService;
        private readonly IAnimeService animeService;
        private readonly ITagService tagService;

        public EpisodeController(AnimuDbContext context, UserManager<IdentityUser> userManager,
            IEpisodeService episodeService, IAnimeService animeService, ITagService tagService)
        {
            this.context = context;
            this.userManager = userManager;
            this.episodeService = episodeService;
            this.animeService = animeService;
            this.tagService = tagService;
        }

        [HttpGet]
        public IActionResult Create(Guid? animeId)
        {
            if (!animeId.HasValue)
            {
                return NotFound();
            }

            Episode episode = new Episode() { AnimeId = animeId.Value };
            return View(episode);
        }

        [HttpPost]
        public IActionResult Create(Episode model)
        {
            if (ModelState.IsValid)
            {
                this.episodeService.Create(model);
                return LocalRedirect($"~/Anime/Details/{model.AnimeId}");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(Guid? id)
        {
            if (!id.HasValue)
            {
                return NotFound();
            }

            Episode model = this.episodeService.Get(id.Value);
            if (model is null)
            {
                return NotFound();
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Episode model)
        {
            if (ModelState.IsValid)
            {
                this.episodeService.Update(model);
                return LocalRedirect($"~/Anime/Details/{model.AnimeId}");
            }

            return View(model);
        }

        public IActionResult Delete(Guid? id)
        {
            if (!id.HasValue)
            {
                return NotFound();
            }

            Episode episode = this.episodeService.Get(id.Value);
            this.episodeService.Delete(episode);
            return LocalRedirect($"~/Anime/Details/{episode.AnimeId}");
        }

        public IActionResult Watch(Guid? id)
        {
            if (!id.HasValue)
            {
                return NotFound();
            }

            var model = this.context
                            .Episodes
                            .Include(e => e.Anime)
                            .ThenInclude(a => a.Episodes)
                            .FirstOrDefault(e => e.Id == id);

            if (model is null)
            {
                return NotFound();
            }

            return View(model);
        }
    }
}
