namespace PetRental.WebMVC1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class other : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Pets", "Content_ID", "dbo.Contents");
            DropIndex("dbo.Pets", new[] { "Content_ID" });
            DropColumn("dbo.Pets", "ImagePath");
            DropColumn("dbo.Pets", "Content_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pets", "Content_ID", c => c.Int());
            AddColumn("dbo.Pets", "ImagePath", c => c.Binary());
            CreateIndex("dbo.Pets", "Content_ID");
            AddForeignKey("dbo.Pets", "Content_ID", "dbo.Contents", "ID");
        }
    }
}
