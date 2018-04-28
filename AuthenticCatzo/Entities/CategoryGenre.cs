using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthenticCatzo.Entities
{
    public class CategoryGenre
    {
        public int Id { get; set; }
        public string CategoryGenreName { get; set; }
        public string Icon { get; set; }
        public ICollection<Movies> Movies { get; set; }
    }
}