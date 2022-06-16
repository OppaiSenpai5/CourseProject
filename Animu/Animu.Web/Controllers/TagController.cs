using Animu.Data.Entities;
using Animu.Service.Interfaces;
using Animu.Web.Data;
using Animu.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animu.Web.Controllers
{
    public class TagController : Controller
    {
        private readonly AnimuDbContext context;
        private readonly UserManager<IdentityUser> userManager;
        private readonly IEpisodeService episodeService;
        private readonly IAnimeService animeService;
        private readonly ITagService tagService;

        public TagController(AnimuDbContext context, UserManager<IdentityUser> userManager,
            IEpisodeService episodeService, IAnimeService animeService, ITagService tagService)
        {
            this.context = context;
            this.userManager = userManager;
            this.episodeService = episodeService;
            this.animeService = animeService;
            this.tagService = tagService;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            IEnumerable<TagVM> modelList =
                this.tagService.GetAll().Select(t => EntityToModel(t));

            return View(modelList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TagVM model)
        {
            if (ModelState.IsValid)
            {
                Tag tag = ModelToEntity(model);
                this.tagService.Create(tag);

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
            
            Tag tag = this.tagService.Get(id.Value);
            if (tag is null)
            {
                return NotFound();
            }

            TagVM model = EntityToModel(tag);
            return View(model);

        }

        [HttpPost]
        public IActionResult Edit(TagVM model)
        {
            if (ModelState.IsValid)
            {
                Tag tag = ModelToEntity(model);
                this.tagService.Update(tag);

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

            Tag tag = this.tagService.Get(id.Value);
            if (tag is null)
            {
                return NotFound();
            }

            this.tagService.Delete(tag);
            return RedirectToAction(nameof(Index));
        }

        private static Tag ModelToEntity(TagVM model)
        {
            Tag tag = new Tag()
            {
                Id = model.Id,
                Name = model.Name
            };

            return tag;
        }

        private static TagVM EntityToModel(Tag tag)
        {
            TagVM model = new TagVM()
            {
                Id = tag.Id,
                Name = tag.Name
            };

            return model;
        }
    }
}
