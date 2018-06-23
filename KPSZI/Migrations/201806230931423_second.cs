namespace KPSZI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("soooqa.SZIGISMeasures", "SZI_SZIId", "soooqa.SZIs");
            DropForeignKey("soooqa.SZIGISMeasures", "GISMeasure_GISMeasureId", "soooqa.GISMeasures");
            DropIndex("soooqa.SZIGISMeasures", new[] { "SZI_SZIId" });
            DropIndex("soooqa.SZIGISMeasures", new[] { "GISMeasure_GISMeasureId" });
            CreateTable(
                "soooqa.SZISortGISMeasures",
                c => new
                    {
                        SZISort_SZISortId = c.Int(nullable: false),
                        GISMeasure_GISMeasureId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SZISort_SZISortId, t.GISMeasure_GISMeasureId })
                .ForeignKey("soooqa.SZISorts", t => t.SZISort_SZISortId, cascadeDelete: true)
                .ForeignKey("soooqa.GISMeasures", t => t.GISMeasure_GISMeasureId, cascadeDelete: true)
                .Index(t => t.SZISort_SZISortId)
                .Index(t => t.GISMeasure_GISMeasureId);
            
            AddColumn("soooqa.GISMeasures", "SZI_SZIId", c => c.Int());
            CreateIndex("soooqa.GISMeasures", "SZI_SZIId");
            AddForeignKey("soooqa.GISMeasures", "SZI_SZIId", "soooqa.SZIs", "SZIId");
            DropTable("soooqa.SZIGISMeasures");
        }
        
        public override void Down()
        {
            CreateTable(
                "soooqa.SZIGISMeasures",
                c => new
                    {
                        SZI_SZIId = c.Int(nullable: false),
                        GISMeasure_GISMeasureId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SZI_SZIId, t.GISMeasure_GISMeasureId });
            
            DropForeignKey("soooqa.SZISortGISMeasures", "GISMeasure_GISMeasureId", "soooqa.GISMeasures");
            DropForeignKey("soooqa.SZISortGISMeasures", "SZISort_SZISortId", "soooqa.SZISorts");
            DropForeignKey("soooqa.GISMeasures", "SZI_SZIId", "soooqa.SZIs");
            DropIndex("soooqa.SZISortGISMeasures", new[] { "GISMeasure_GISMeasureId" });
            DropIndex("soooqa.SZISortGISMeasures", new[] { "SZISort_SZISortId" });
            DropIndex("soooqa.GISMeasures", new[] { "SZI_SZIId" });
            DropColumn("soooqa.GISMeasures", "SZI_SZIId");
            DropTable("soooqa.SZISortGISMeasures");
            CreateIndex("soooqa.SZIGISMeasures", "GISMeasure_GISMeasureId");
            CreateIndex("soooqa.SZIGISMeasures", "SZI_SZIId");
            AddForeignKey("soooqa.SZIGISMeasures", "GISMeasure_GISMeasureId", "soooqa.GISMeasures", "GISMeasureId", cascadeDelete: true);
            AddForeignKey("soooqa.SZIGISMeasures", "SZI_SZIId", "soooqa.SZIs", "SZIId", cascadeDelete: true);
        }
    }
}
