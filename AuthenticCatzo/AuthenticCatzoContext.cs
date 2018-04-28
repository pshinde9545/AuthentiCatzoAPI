using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AuthenticCatzo.Entities;
namespace AuthenticCatzo
{
    public class AuthenticCatzoContext: DbContext
    {
        public AuthenticCatzoContext() : base("AuthenticCatzoDBConnectionString")
        {

        }

        public DbSet<CategoryGenre> CategoryGenre { get; set; }
        public DbSet<EducationCategory> EducationCategory { get; set; }
        public DbSet<EducationSeries> EducationSeries { get; set; }
        public DbSet<EducationVideos> EducationVideos { get; set; }
        public DbSet<FilmIndustry> FilmIndustry { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<MovieTrailer> MovieTrailer { get; set; }
        public DbSet<TVSeries> TVSeries { get; set; }
        public DbSet<TVSeriesEpisode> TVSeriesEpisode { get; set; }

    }
}