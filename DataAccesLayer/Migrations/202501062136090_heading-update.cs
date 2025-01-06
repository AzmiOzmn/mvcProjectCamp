namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class headingupdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Headings", "Heading_HeadingId", "dbo.Headings");
            DropIndex("dbo.Headings", new[] { "Heading_HeadingId" });
            DropColumn("dbo.Headings", "Heading_HeadingId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Headings", "Heading_HeadingId", c => c.Int());
            CreateIndex("dbo.Headings", "Heading_HeadingId");
            AddForeignKey("dbo.Headings", "Heading_HeadingId", "dbo.Headings", "HeadingId");
        }
    }
}
