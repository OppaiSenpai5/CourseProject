using Animu.Data.Entities;
using Animu.Service.Interfaces;
using Animu.Web.Data;
using Animu.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animu.Web.Controllers
{
    public class AnimeController : Controller
    {
        private readonly AnimuDbContext context;
        private readonly UserManager<IdentityUser> userManager;
        private readonly IEpisodeService episodeService;
        private readonly IAnimeService animeService;
        private readonly ITagService tagService;

        public AnimeController(AnimuDbContext context, UserManager<IdentityUser> userManager,
            IEpisodeService episodeService, IAnimeService animeService, ITagService tagService)
        {
            this.context = context;
            this.userManager = userManager;
            this.episodeService = episodeService;
            this.animeService = animeService;
            this.tagService = tagService;
        }

        public IActionResult Index()
        {
            IEnumerable<AnimeListVM> model =
                this.animeService.GetAll().Select(a => new AnimeListVM(a));

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Tags = this.tagService.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Create(IFormCollection collection, AnimeListVM model)
        {
            if (ModelState.IsValid)
            {
                Anime anime = model.ToAnime();
                anime.TagAnimes = ParseTagIds(collection["tags"], anime.Id);
                this.animeService.Create(anime);

                return RedirectToAction(nameof(Index));
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

            Anime anime = this.animeService.Get(id.Value);
            if (anime is null)
            {
                return NotFound();
            }

            ViewBag.Tags = this.tagService.GetAll();
            ViewBag.SelectedTags = this.tagService.GetAnimeTags(anime.Id);
            AnimeListVM model = new AnimeListVM(anime);
            return View(model);

        }

        [HttpPost]
        public IActionResult Edit(AnimeListVM model)
        {
            if (ModelState.IsValid)
            {
                Anime anime = model.ToAnime();
                this.animeService.Update(anime);

                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        public IActionResult Delete(Guid? id)
        {
            if (!id.HasValue)
            {
                return NotFound();
            }

            Anime anime = this.animeService.Get(id.Value);
            if (anime is null)
            {
                return NotFound();
            }

            this.animeService.Delete(anime);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(Guid? id)
        {
            if (!id.HasValue)
            {
                return NotFound();
            }

            Anime anime = this.animeService.Get(id.Value);
            if (anime is null)
            {
                return NotFound();
            }

            var model = new AnimeDetailsVM(anime);
            model.Tags = this.tagService
                             .GetAnimeTags(anime.Id)
                             .Select(t => new TagVM(t))
                             .ToHashSet();

            return View(model);
            
        }

        private static ICollection<TagAnime> ParseTagIds(StringValues tagIds, Guid animeId)
        {
            HashSet<TagAnime> result = new HashSet<TagAnime>();
            foreach (var id in tagIds)
            {
                result.Add(new TagAnime() { TagId = Guid.Parse(id), AnimeId = animeId });
            }

            return result;
        }
    }
}
