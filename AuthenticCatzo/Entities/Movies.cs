using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuthenticCatzo.Entities
{
    public class Movies
    {
        public int Id { get; set; }
        [StringLength(150)]
        public string MovieName { get; set; }
        [StringLength(2000)]
        public string Description { get; set; }
        [StringLength(50)]
        public string VideoId { get; set; }
        [StringLength(256)]
        public string ImageUrl { get; set; }
        public DateTime DatePublished { get; set; }
        public virtual Language Language { get; set; }
        public virtual CategoryGenre CategoryGenre { get; set; }
        public virtual FilmIndustry FilmIndustry { get; set; }
        public virtual ICollection<TVSeriesEpisode> TVSeriesEpisode { get; set; }
    }
}