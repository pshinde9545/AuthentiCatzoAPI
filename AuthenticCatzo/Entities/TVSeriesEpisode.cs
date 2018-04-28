using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthenticCatzo.Entities
{
    public class TVSeriesEpisode
    {
        public int Id { get; set; }
        public string Title{ get; set; }
        public DateTime DatePublished { get;set; }
        public int EpisodeId{ get; set; }
        public string  VideoId { get; set; }
        public string Description{ get; set; }
        public string ImageUrl{ get; set; }
        public virtual TVSeries TVseries { get; set; }



    }
}