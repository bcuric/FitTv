namespace FitTv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateVideoTable1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Videos", "Type_Id", "dbo.VideoTypes");
            DropIndex("dbo.Videos", new[] { "Type_Id" });
            RenameColumn(table: "dbo.Videos", name: "Type_Id", newName: "TypeId");
            AlterColumn("dbo.Videos", "TypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Videos", "TypeId");
            AddForeignKey("dbo.Videos", "TypeId", "dbo.VideoTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Videos", "TypeId", "dbo.VideoTypes");
            DropIndex("dbo.Videos", new[] { "TypeId" });
            AlterColumn("dbo.Videos", "TypeId", c => c.Byte());
            RenameColumn(table: "dbo.Videos", name: "TypeId", newName: "Type_Id");
            CreateIndex("dbo.Videos", "Type_Id");
            AddForeignKey("dbo.Videos", "Type_Id", "dbo.VideoTypes", "Id");
        }
    }
}
