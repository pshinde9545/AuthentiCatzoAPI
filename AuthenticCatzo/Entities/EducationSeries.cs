using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuthenticCatzo.Entities
{
    public class EducationSeries
    {
        public int Id { get; set; }
        [StringLength(256)]
        public string SeriesName { get; set; }
        [StringLength(2000)]
        public string Description{ get; set; }
        public virtual Language Language{ get; set; }
        public virtual EducationCategory EducationCategory { get; set; }
        public ICollection<EducationVideos> EducationVideos { get; set; }
    }
}