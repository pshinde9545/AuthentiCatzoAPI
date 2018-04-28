namespace AuthenticCatzo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "DatePublished", c => c.DateTime(nullable: false));
            AddColumn("dbo.EducationVideos", "DatePublished", c => c.DateTime(nullable: false));
            AddColumn("dbo.MovieTrailers", "DatePublished", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MovieTrailers", "DatePublished");
            DropColumn("dbo.EducationVideos", "DatePublished");
            DropColumn("dbo.Movies", "DatePublished");
        }
    }
}
