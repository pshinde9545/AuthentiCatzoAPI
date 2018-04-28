using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuthenticCatzo.Entities
{
    public class TVSeriesEpisode
    {
        public int Id { get; set; }
        [StringLength(150)]
        public string Title{ get; set; }

        public DateTime DatePublished { get;set; }
        public int EpisodeId{ get; set; }
        [StringLength(50)]
        public string  VideoId { get; set; }
        [StringLength(2000)]
        public string Description{ get; set; }
        [StringLength(256)]
        public string ImageUrl{ get; set; }
        public virtual TVSeries TVseries { get; set; }



    }
}