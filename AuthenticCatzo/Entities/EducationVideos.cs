using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthenticCatzo.Entities
{
    public class EducationVideos
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string VideoId { get; set; }
        public virtual EducationSeries EducationSeries { get; set; }
    }
}