using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthenticCatzo.Entities
{
    public class EducationSeries
    {
        public int Id { get; set; }
        public string SeriesName { get; set; }
        public string Description{ get; set; }
        public virtual Language Language{ get; set; }
        public virtual EducationCategory EducationCategory { get; set; }
        public ICollection<EducationVideos> EducationVideos { get; set; }
    }
}