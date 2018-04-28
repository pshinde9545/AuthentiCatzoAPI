using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuthenticCatzo.Entities
{
    public class CategoryGenre
    {
        public int Id { get; set; }
        [StringLength(75)]
        public string CategoryGenreName { get; set; }
        [StringLength(256)]
        public string Icon { get; set; }
        public ICollection<Movies> Movies { get; set; }
    }
}