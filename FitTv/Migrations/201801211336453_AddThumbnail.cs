namespace FitTv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddThumbnail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Videos", "Thumbnail", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Videos", "Thumbnail");
        }
    }
}
