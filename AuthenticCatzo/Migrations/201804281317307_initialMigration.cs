namespace AuthenticCatzo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CategoryGenres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryGenreName = c.String(),
                        Icon = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MovieName = c.String(),
                        Description = c.String(),
                        VideoId = c.String(),
                        ImageUrl = c.String(),
                        CategoryGenre_Id = c.Int(),
                        FilmIndustry_Id = c.Int(),
                        Language_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CategoryGenres", t => t.CategoryGenre_Id)
                .ForeignKey("dbo.FilmIndustries", t => t.FilmIndustry_Id)
                .ForeignKey("dbo.Languages", t => t.Language_Id)
                .Index(t => t.CategoryGenre_Id)
                .Index(t => t.FilmIndustry_Id)
                .Index(t => t.Language_Id);
            
            CreateTable(
                "dbo.FilmIndustries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FilmIndustryName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LanguageName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TVSeriesEpisodes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        DatePublished = c.DateTime(nullable: false),
                        EpisodeId = c.Int(nullable: false),
                        VideoId = c.String(),
                        Description = c.String(),
                        ImageUrl = c.String(),
                        TVseries_Id = c.Int(),
                        Movies_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TVSeries", t => t.TVseries_Id)
                .ForeignKey("dbo.Movies", t => t.Movies_Id)
                .Index(t => t.TVseries_Id)
                .Index(t => t.Movies_Id);
            
            CreateTable(
                "dbo.TVSeries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        FilmIndustry_Id = c.Int(),
                        Language_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FilmIndustries", t => t.FilmIndustry_Id)
                .ForeignKey("dbo.Languages", t => t.Language_Id)
                .Index(t => t.FilmIndustry_Id)
                .Index(t => t.Language_Id);
            
            CreateTable(
                "dbo.EducationCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Subject = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EducationSeries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SeriesName = c.String(),
                        Description = c.String(),
                        EducationCategory_Id = c.Int(),
                        Language_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EducationCategories", t => t.EducationCategory_Id)
                .ForeignKey("dbo.Languages", t => t.Language_Id)
                .Index(t => t.EducationCategory_Id)
                .Index(t => t.Language_Id);
            
            CreateTable(
                "dbo.EducationVideos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Title = c.String(),
                        ImageUrl = c.String(),
                        VideoId = c.String(),
                        EducationSeries_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EducationSeries", t => t.EducationSeries_Id)
                .Index(t => t.EducationSeries_Id);
            
            CreateTable(
                "dbo.MovieTrailers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MovieName = c.String(),
                        ImageUrl = c.String(),
                        Descrption = c.String(),
                        Title = c.String(),
                        VideoId = c.String(),
                        FilmIndustry_Id = c.Int(),
                        Language_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FilmIndustries", t => t.FilmIndustry_Id)
                .ForeignKey("dbo.Languages", t => t.Language_Id)
                .Index(t => t.FilmIndustry_Id)
                .Index(t => t.Language_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovieTrailers", "Language_Id", "dbo.Languages");
            DropForeignKey("dbo.MovieTrailers", "FilmIndustry_Id", "dbo.FilmIndustries");
            DropForeignKey("dbo.EducationSeries", "Language_Id", "dbo.Languages");
            DropForeignKey("dbo.EducationVideos", "EducationSeries_Id", "dbo.EducationSeries");
            DropForeignKey("dbo.EducationSeries", "EducationCategory_Id", "dbo.EducationCategories");
            DropForeignKey("dbo.TVSeriesEpisodes", "Movies_Id", "dbo.Movies");
            DropForeignKey("dbo.TVSeriesEpisodes", "TVseries_Id", "dbo.TVSeries");
            DropForeignKey("dbo.TVSeries", "Language_Id", "dbo.Languages");
            DropForeignKey("dbo.TVSeries", "FilmIndustry_Id", "dbo.FilmIndustries");
            DropForeignKey("dbo.Movies", "Language_Id", "dbo.Languages");
            DropForeignKey("dbo.Movies", "FilmIndustry_Id", "dbo.FilmIndustries");
            DropForeignKey("dbo.Movies", "CategoryGenre_Id", "dbo.CategoryGenres");
            DropIndex("dbo.MovieTrailers", new[] { "Language_Id" });
            DropIndex("dbo.MovieTrailers", new[] { "FilmIndustry_Id" });
            DropIndex("dbo.EducationVideos", new[] { "EducationSeries_Id" });
            DropIndex("dbo.EducationSeries", new[] { "Language_Id" });
            DropIndex("dbo.EducationSeries", new[] { "EducationCategory_Id" });
            DropIndex("dbo.TVSeries", new[] { "Language_Id" });
            DropIndex("dbo.TVSeries", new[] { "FilmIndustry_Id" });
            DropIndex("dbo.TVSeriesEpisodes", new[] { "Movies_Id" });
            DropIndex("dbo.TVSeriesEpisodes", new[] { "TVseries_Id" });
            DropIndex("dbo.Movies", new[] { "Language_Id" });
            DropIndex("dbo.Movies", new[] { "FilmIndustry_Id" });
            DropIndex("dbo.Movies", new[] { "CategoryGenre_Id" });
            DropTable("dbo.MovieTrailers");
            DropTable("dbo.EducationVideos");
            DropTable("dbo.EducationSeries");
            DropTable("dbo.EducationCategories");
            DropTable("dbo.TVSeries");
            DropTable("dbo.TVSeriesEpisodes");
            DropTable("dbo.Languages");
            DropTable("dbo.FilmIndustries");
            DropTable("dbo.Movies");
            DropTable("dbo.CategoryGenres");
        }
    }
}
