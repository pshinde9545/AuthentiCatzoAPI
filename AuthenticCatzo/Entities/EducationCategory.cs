using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthenticCatzo.Entities
{
    public class EducationCategory
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Subject { get; set; }
        public ICollection<EducationSeries> EducationSeries { get; set;}
    }
}