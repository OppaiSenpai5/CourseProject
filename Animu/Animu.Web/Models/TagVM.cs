using Animu.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Animu.Web.Models
{
    public class TagVM
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }

        public TagVM()
        {
            this.Id = Guid.NewGuid();
        }

        public TagVM(Tag tag)
        {
            this.Id = tag.Id;
            this.Name = tag.Name;
        }

        public Tag ToTag()
        {
            return new Tag()
            {
                Id = this.Id,
                Name = this.Name
            };
        }
    }
}
