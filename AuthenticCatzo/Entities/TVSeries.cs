using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthenticCatzo.Entities
{
    public class TVSeries
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Description{ get; set; }
        public virtual Language Language { get; set; }
        public virtual FilmIndustry FilmIndustry{get;set;}
        public virtual ICollection<TVSeriesEpisode> TVSeriesEpisode { get; set; }



    }
}