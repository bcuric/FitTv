namespace FitTv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateVideoTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Videos", "PublisherId", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Videos", "PublisherId", c => c.Int(nullable: false));
        }
    }
}
