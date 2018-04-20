namespace KPSZI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sfhaddedtothreats : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("soooqa.IntruderTypeThreats", "IntruderType_IntruderTypeId", "soooqa.IntruderTypes");
            DropForeignKey("soooqa.IntruderTypeThreats", "Threat_ThreatId", "soooqa.Threats");
            DropIndex("soooqa.IntruderTypeThreats", new[] { "IntruderType_IntruderTypeId" });
            DropIndex("soooqa.IntruderTypeThreats", new[] { "Threat_ThreatId" });
            AddColumn("soooqa.ImplementWays", "ImplementWayNumber", c => c.Int(nullable: false));
            AddColumn("soooqa.Threats", "IntruderType_IntruderTypeId", c => c.Int());
            AddColumn("soooqa.Vulnerabilities", "VulnerabilityNumber", c => c.Int(nullable: false));
            AddColumn("soooqa.SFHs", "SFHNumber", c => c.Int(nullable: false));
            AddColumn("soooqa.SFHs", "Threat_ThreatId", c => c.Int());
            CreateIndex("soooqa.Threats", "IntruderType_IntruderTypeId");
            CreateIndex("soooqa.SFHs", "Threat_ThreatId");
            AddForeignKey("soooqa.SFHs", "Threat_ThreatId", "soooqa.Threats", "ThreatId");
            AddForeignKey("soooqa.Threats", "IntruderType_IntruderTypeId", "soooqa.IntruderTypes", "IntruderTypeId");
            DropTable("soooqa.IntruderTypeThreats");
        }
        
        public override void Down()
        {
            CreateTable(
                "soooqa.IntruderTypeThreats",
                c => new
                    {
                        IntruderType_IntruderTypeId = c.Int(nullable: false),
                        Threat_ThreatId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IntruderType_IntruderTypeId, t.Threat_ThreatId });
            
            DropForeignKey("soooqa.Threats", "IntruderType_IntruderTypeId", "soooqa.IntruderTypes");
            DropForeignKey("soooqa.SFHs", "Threat_ThreatId", "soooqa.Threats");
            DropIndex("soooqa.SFHs", new[] { "Threat_ThreatId" });
            DropIndex("soooqa.Threats", new[] { "IntruderType_IntruderTypeId" });
            DropColumn("soooqa.SFHs", "Threat_ThreatId");
            DropColumn("soooqa.SFHs", "SFHNumber");
            DropColumn("soooqa.Vulnerabilities", "VulnerabilityNumber");
            DropColumn("soooqa.Threats", "IntruderType_IntruderTypeId");
            DropColumn("soooqa.ImplementWays", "ImplementWayNumber");
            CreateIndex("soooqa.IntruderTypeThreats", "Threat_ThreatId");
            CreateIndex("soooqa.IntruderTypeThreats", "IntruderType_IntruderTypeId");
            AddForeignKey("soooqa.IntruderTypeThreats", "Threat_ThreatId", "soooqa.Threats", "ThreatId", cascadeDelete: true);
            AddForeignKey("soooqa.IntruderTypeThreats", "IntruderType_IntruderTypeId", "soooqa.IntruderTypes", "IntruderTypeId", cascadeDelete: true);
        }
    }
}
