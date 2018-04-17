namespace KPSZI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _123 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "soooqa.ImplementWays",
                c => new
                    {
                        ImplementWayId = c.Int(nullable: false, identity: true),
                        WayName = c.String(),
                    })
                .PrimaryKey(t => t.ImplementWayId);
            
            CreateTable(
                "soooqa.Vulnerabilities",
                c => new
                    {
                        VulnerabilityId = c.Int(nullable: false, identity: true),
                        VulnerabilityName = c.String(),
                        VulnerabilityDescription = c.String(),
                    })
                .PrimaryKey(t => t.VulnerabilityId);
            
            CreateTable(
                "soooqa.ThreatImplementWays",
                c => new
                    {
                        Threat_ThreatId = c.Int(nullable: false),
                        ImplementWay_ImplementWayId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Threat_ThreatId, t.ImplementWay_ImplementWayId })
                .ForeignKey("soooqa.Threats", t => t.Threat_ThreatId, cascadeDelete: true)
                .ForeignKey("soooqa.ImplementWays", t => t.ImplementWay_ImplementWayId, cascadeDelete: true)
                .Index(t => t.Threat_ThreatId)
                .Index(t => t.ImplementWay_ImplementWayId);
            
            CreateTable(
                "soooqa.IntruderTypeThreats",
                c => new
                    {
                        IntruderType_IntruderTypeId = c.Int(nullable: false),
                        Threat_ThreatId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IntruderType_IntruderTypeId, t.Threat_ThreatId })
                .ForeignKey("soooqa.IntruderTypes", t => t.IntruderType_IntruderTypeId, cascadeDelete: true)
                .ForeignKey("soooqa.Threats", t => t.Threat_ThreatId, cascadeDelete: true)
                .Index(t => t.IntruderType_IntruderTypeId)
                .Index(t => t.Threat_ThreatId);
            
            CreateTable(
                "soooqa.VulnerabilityThreats",
                c => new
                    {
                        Vulnerability_VulnerabilityId = c.Int(nullable: false),
                        Threat_ThreatId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Vulnerability_VulnerabilityId, t.Threat_ThreatId })
                .ForeignKey("soooqa.Vulnerabilities", t => t.Vulnerability_VulnerabilityId, cascadeDelete: true)
                .ForeignKey("soooqa.Threats", t => t.Threat_ThreatId, cascadeDelete: true)
                .Index(t => t.Vulnerability_VulnerabilityId)
                .Index(t => t.Threat_ThreatId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("soooqa.VulnerabilityThreats", "Threat_ThreatId", "soooqa.Threats");
            DropForeignKey("soooqa.VulnerabilityThreats", "Vulnerability_VulnerabilityId", "soooqa.Vulnerabilities");
            DropForeignKey("soooqa.IntruderTypeThreats", "Threat_ThreatId", "soooqa.Threats");
            DropForeignKey("soooqa.IntruderTypeThreats", "IntruderType_IntruderTypeId", "soooqa.IntruderTypes");
            DropForeignKey("soooqa.ThreatImplementWays", "ImplementWay_ImplementWayId", "soooqa.ImplementWays");
            DropForeignKey("soooqa.ThreatImplementWays", "Threat_ThreatId", "soooqa.Threats");
            DropIndex("soooqa.VulnerabilityThreats", new[] { "Threat_ThreatId" });
            DropIndex("soooqa.VulnerabilityThreats", new[] { "Vulnerability_VulnerabilityId" });
            DropIndex("soooqa.IntruderTypeThreats", new[] { "Threat_ThreatId" });
            DropIndex("soooqa.IntruderTypeThreats", new[] { "IntruderType_IntruderTypeId" });
            DropIndex("soooqa.ThreatImplementWays", new[] { "ImplementWay_ImplementWayId" });
            DropIndex("soooqa.ThreatImplementWays", new[] { "Threat_ThreatId" });
            DropTable("soooqa.VulnerabilityThreats");
            DropTable("soooqa.IntruderTypeThreats");
            DropTable("soooqa.ThreatImplementWays");
            DropTable("soooqa.Vulnerabilities");
            DropTable("soooqa.ImplementWays");
        }
    }
}
