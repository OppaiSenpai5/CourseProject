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
    public class TagService : BaseService<Tag>, IBaseService<Tag>, ITagService
    {
        private readonly ITagAnimeService tagAnimeService;
        public TagService(AnimuDbContext context, ITagAnimeService tagAnimeService) : base(context)
        {
            this.tagAnimeService = tagAnimeService;
        }

        public IEnumerable<Tag> GetAnimeTags(Guid animeId)
        {
            IEnumerable<TagAnime> tagAnimes = this.tagAnimeService.GetByAnimeId(animeId);
            return (from ta in tagAnimes
                    join tag in GetAll()
                    on ta.TagId equals tag.Id
                    select tag).ToHashSet();
        }
    }
}
