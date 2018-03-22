namespace FitTv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingVideos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Videos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Url = c.String(),
                        Description = c.String(),
                        PublisherId = c.Int(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Videos");
        }
    }
}
