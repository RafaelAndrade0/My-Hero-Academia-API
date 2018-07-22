namespace MyHeroAcademiaAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateHeroesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Heroes", "Quirk", c => c.String(nullable: false));
            AlterColumn("dbo.Heroes", "Name", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Heroes", "Name", c => c.String());
            DropColumn("dbo.Heroes", "Quirk");
        }
    }
}
