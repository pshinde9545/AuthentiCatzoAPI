using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthenticCatzo.Entities
{
    public class MovieTrailer
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string ImageUrl { get; set; }
        public string Descrption{ get; set; }
        public string Title{ get; set; }
        public string VideoId { get; set; }
        public virtual Language Language{ get; set; }
        public virtual FilmIndustry FilmIndustry { get; set; }

    }
}