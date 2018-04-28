using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthenticCatzo.Entities
{
    public class Movies
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string Description { get; set; }
        public string VideoId { get; set; }
        public string ImageUrl { get; set; }
        public virtual Language Language { get; set; }
        public virtual CategoryGenre CategoryGenre { get; set; }
        public virtual FilmIndustry FilmIndustry { get; set; }
        public virtual ICollection<TVSeriesEpisode> TVSeriesEpisode { get; set; }
    }
}