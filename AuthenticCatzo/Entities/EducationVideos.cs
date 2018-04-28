using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuthenticCatzo.Entities
{
    public class EducationVideos
    {
        public int Id { get; set; }
        [StringLength(2000)]
        public string Description { get; set; }
        [StringLength(150)]
        public string Title { get; set; }
        [StringLength(256)]
        public string ImageUrl { get; set; }
        [StringLength(50)]
        public string VideoId { get; set; }
        public DateTime DatePublished { get; set; }
        public virtual EducationSeries EducationSeries { get; set; }
    }
}