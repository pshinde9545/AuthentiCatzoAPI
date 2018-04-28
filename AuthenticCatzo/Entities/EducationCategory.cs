using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuthenticCatzo.Entities
{
    public class EducationCategory
    {
        public int Id { get; set; }
        [StringLength(2000)]
        public string Description { get; set; }
        [StringLength(75)]
        public string Subject { get; set; }
        public ICollection<EducationSeries> EducationSeries { get; set;}
    }
}