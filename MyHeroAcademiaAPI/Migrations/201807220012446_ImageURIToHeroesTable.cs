namespace MyHeroAcademiaAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImageURIToHeroesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Heroes", "ImageURI", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Heroes", "ImageURI");
        }
    }
}
