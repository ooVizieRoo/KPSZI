namespace KPSZI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _123 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "korolev.InfoTypes",
                c => new
                    {
                        InfoTypeId = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.InfoTypeId);
            
            CreateTable(
                "korolev.IntruderTypes",
                c => new
                    {
                        IntruderTypeId = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.IntruderTypeId);
            
            CreateTable(
                "korolev.SFHs",
                c => new
                    {
                        SFHId = c.Int(nullable: false, identity: true),
                        SFH_TypeID = c.Int(nullable: false),
                        Name = c.String(),
                        ProjectSecurity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SFHId);
            
            CreateTable(
                "korolev.SFHTypes",
                c => new
                    {
                        SFHTypeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.SFHTypeId);
            
            CreateTable(
                "korolev.Threats",
                c => new
                    {
                        ThreatId = c.Int(nullable: false, identity: true),
                        ThreatNumber = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        ObjectOfInfluence = c.String(),
                        ConfidenceViolation = c.Boolean(nullable: false),
                        IntegrityViolation = c.Boolean(nullable: false),
                        AvailabilityViolation = c.Boolean(nullable: false),
                        DateOfAdd = c.DateTime(nullable: false),
                        DateOfChange = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ThreatId);
            
            CreateTable(
                "korolev.ThreatSources",
                c => new
                    {
                        ThreatSourceId = c.Int(nullable: false, identity: true),
                        InternalIntruder = c.Boolean(nullable: false),
                        Potencial = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ThreatSourceId);
            
            CreateTable(
                "korolev.ThreatSourceThreats",
                c => new
                    {
                        ThreatSource_ThreatSourceId = c.Int(nullable: false),
                        Threat_ThreatId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ThreatSource_ThreatSourceId, t.Threat_ThreatId })
                .ForeignKey("korolev.ThreatSources", t => t.ThreatSource_ThreatSourceId, cascadeDelete: true)
                .ForeignKey("korolev.Threats", t => t.Threat_ThreatId, cascadeDelete: true)
                .Index(t => t.ThreatSource_ThreatSourceId)
                .Index(t => t.Threat_ThreatId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("korolev.ThreatSourceThreats", "Threat_ThreatId", "korolev.Threats");
            DropForeignKey("korolev.ThreatSourceThreats", "ThreatSource_ThreatSourceId", "korolev.ThreatSources");
            DropIndex("korolev.ThreatSourceThreats", new[] { "Threat_ThreatId" });
            DropIndex("korolev.ThreatSourceThreats", new[] { "ThreatSource_ThreatSourceId" });
            DropTable("korolev.ThreatSourceThreats");
            DropTable("korolev.ThreatSources");
            DropTable("korolev.Threats");
            DropTable("korolev.SFHTypes");
            DropTable("korolev.SFHs");
            DropTable("korolev.IntruderTypes");
            DropTable("korolev.InfoTypes");
        }
    }
}
