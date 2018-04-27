namespace KPSZI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intruderChanged : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("soooqa.Threats", "IntruderType_IntruderTypeId", "soooqa.IntruderTypes");
            DropIndex("soooqa.Threats", new[] { "IntruderType_IntruderTypeId" });
            DropColumn("soooqa.Threats", "IntruderType_IntruderTypeId");
        }
        
        public override void Down()
        {
            AddColumn("soooqa.Threats", "IntruderType_IntruderTypeId", c => c.Int());
            CreateIndex("soooqa.Threats", "IntruderType_IntruderTypeId");
            AddForeignKey("soooqa.Threats", "IntruderType_IntruderTypeId", "soooqa.IntruderTypes", "IntruderTypeId");
        }
    }
}
