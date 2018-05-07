namespace KPSZI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCollectionsToMeasuresAndThreats : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "soooqa.ThreatGISMeasures",
                c => new
                    {
                        Threat_ThreatId = c.Int(nullable: false),
                        GISMeasure_GISMeasureId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Threat_ThreatId, t.GISMeasure_GISMeasureId })
                .ForeignKey("soooqa.Threats", t => t.Threat_ThreatId, cascadeDelete: true)
                .ForeignKey("soooqa.GISMeasures", t => t.GISMeasure_GISMeasureId, cascadeDelete: true)
                .Index(t => t.Threat_ThreatId)
                .Index(t => t.GISMeasure_GISMeasureId);
            
            AddColumn("soooqa.GISMeasures", "isOnlyISPDn", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("soooqa.ThreatGISMeasures", "GISMeasure_GISMeasureId", "soooqa.GISMeasures");
            DropForeignKey("soooqa.ThreatGISMeasures", "Threat_ThreatId", "soooqa.Threats");
            DropIndex("soooqa.ThreatGISMeasures", new[] { "GISMeasure_GISMeasureId" });
            DropIndex("soooqa.ThreatGISMeasures", new[] { "Threat_ThreatId" });
            DropColumn("soooqa.GISMeasures", "isOnlyISPDn");
            DropTable("soooqa.ThreatGISMeasures");
        }
    }
}
