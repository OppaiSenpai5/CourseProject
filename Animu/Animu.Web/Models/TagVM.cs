using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animu.Web.Models
{
    public class TagVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public TagVM()
        {
            this.Id = Guid.NewGuid();
        }
    }
}
