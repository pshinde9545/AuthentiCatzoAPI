using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuthenticCatzo.Entities
{
    public class FilmIndustry
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string FilmIndustryName { get; set; }
    }
}