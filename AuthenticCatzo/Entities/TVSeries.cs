using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuthenticCatzo.Entities
{
    public class TVSeries
    {
        public int Id { get; set; }
        [StringLength(150)]
        public string Name{ get; set; }
        [StringLength(2000)]
        public string Description{ get; set; }
        public virtual Language Language { get; set; }
        public virtual FilmIndustry FilmIndustry{get;set;}
        public virtual ICollection<TVSeriesEpisode> TVSeriesEpisode { get; set; }



    }
}