namespace MyHeroAcademiaAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateVillainsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Villains", "Quirk", c => c.String(nullable: false));
            AlterColumn("dbo.Villains", "Name", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Villains", "Name", c => c.String());
            DropColumn("dbo.Villains", "Quirk");
        }
    }
}
