namespace FitTv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddVideoTypeTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VideoTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Videos", "Type_Id", c => c.Byte());
            CreateIndex("dbo.Videos", "Type_Id");
            AddForeignKey("dbo.Videos", "Type_Id", "dbo.VideoTypes", "Id");
            DropColumn("dbo.Videos", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Videos", "Type", c => c.Int(nullable: false));
            DropForeignKey("dbo.Videos", "Type_Id", "dbo.VideoTypes");
            DropIndex("dbo.Videos", new[] { "Type_Id" });
            DropColumn("dbo.Videos", "Type_Id");
            DropTable("dbo.VideoTypes");
        }
    }
}
