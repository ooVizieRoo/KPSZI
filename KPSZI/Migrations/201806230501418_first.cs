namespace KPSZI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "soooqa.ConfigOptions",
                c => new
                    {
                        ConfigOptionId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        DefenceClass = c.String(),
                        GISMeasure_GISMeasureId = c.Int(),
                    })
                .PrimaryKey(t => t.ConfigOptionId)
                .ForeignKey("soooqa.GISMeasures", t => t.GISMeasure_GISMeasureId)
                .Index(t => t.GISMeasure_GISMeasureId);
            
            CreateTable(
                "soooqa.GISMeasures",
                c => new
                    {
                        GISMeasureId = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        Description = c.String(),
                        MinimalRequirementDefenceClass = c.Int(nullable: false),
                        isOnlyISPDn = c.Boolean(nullable: false),
                        MeasureGroup_MeasureGroupId = c.Int(),
                    })
                .PrimaryKey(t => t.GISMeasureId)
                .ForeignKey("soooqa.MeasureGroups", t => t.MeasureGroup_MeasureGroupId)
                .Index(t => t.MeasureGroup_MeasureGroupId);
            
            CreateTable(
                "soooqa.MeasureGroups",
                c => new
                    {
                        MeasureGroupId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ShortName = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.MeasureGroupId);
            
            CreateTable(
                "soooqa.ISPDNMeasures",
                c => new
                    {
                        ISPDNMeasureId = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        Description = c.String(),
                        MinimalRequirementDefenceLevel = c.Int(nullable: false),
                        MeasureGroup_MeasureGroupId = c.Int(),
                    })
                .PrimaryKey(t => t.ISPDNMeasureId)
                .ForeignKey("soooqa.MeasureGroups", t => t.MeasureGroup_MeasureGroupId)
                .Index(t => t.MeasureGroup_MeasureGroupId);
            
            CreateTable(
                "soooqa.SZIs",
                c => new
                    {
                        SZIId = c.Int(nullable: false, identity: true),
                        DefenceClass = c.String(),
                        Name = c.String(),
                        Certificate = c.String(),
                        DateOfEnd = c.DateTime(nullable: false),
                        NDVControlLevel = c.Int(nullable: false),
                        SVTClass = c.String(),
                        TU = c.String(),
                        CPUFrequencyRequirements = c.Int(nullable: false),
                        CPUCoresRequirements = c.Int(nullable: false),
                        MemoryRequirements = c.Int(nullable: false),
                        DiscSpaceRequirements = c.Int(nullable: false),
                        ISPDNMeasure_ISPDNMeasureId = c.Int(),
                    })
                .PrimaryKey(t => t.SZIId)
                .ForeignKey("soooqa.ISPDNMeasures", t => t.ISPDNMeasure_ISPDNMeasureId)
                .Index(t => t.ISPDNMeasure_ISPDNMeasureId);
            
            CreateTable(
                "soooqa.SZISorts",
                c => new
                    {
                        SZISortId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ShortName = c.String(),
                        Number = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SZISortId);
            
            CreateTable(
                "soooqa.SFHs",
                c => new
                    {
                        SFHId = c.Int(nullable: false, identity: true),
                        SFHNumber = c.Int(nullable: false),
                        Name = c.String(),
                        ProjectSecurity = c.Int(nullable: false),
                        SFHType_SFHTypeId = c.Int(),
                    })
                .PrimaryKey(t => t.SFHId)
                .ForeignKey("soooqa.SFHTypes", t => t.SFHType_SFHTypeId)
                .Index(t => t.SFHType_SFHTypeId);
            
            CreateTable(
                "soooqa.SFHTypes",
                c => new
                    {
                        SFHTypeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MultipleChoice = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SFHTypeId);
            
            CreateTable(
                "soooqa.Threats",
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
                "soooqa.ImplementWays",
                c => new
                    {
                        ImplementWayId = c.Int(nullable: false, identity: true),
                        WayNumber = c.Int(nullable: false),
                        WayName = c.String(),
                    })
                .PrimaryKey(t => t.ImplementWayId);
            
            CreateTable(
                "soooqa.ThreatSources",
                c => new
                    {
                        ThreatSourceId = c.Int(nullable: false, identity: true),
                        InternalIntruder = c.Boolean(nullable: false),
                        Potencial = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ThreatSourceId);
            
            CreateTable(
                "soooqa.Vulnerabilities",
                c => new
                    {
                        VulnerabilityId = c.Int(nullable: false, identity: true),
                        VulnerabilityNumber = c.Int(nullable: false),
                        VulnerabilityName = c.String(),
                        VulnerabilityDescription = c.String(),
                    })
                .PrimaryKey(t => t.VulnerabilityId);
            
            CreateTable(
                "soooqa.InfoTypes",
                c => new
                    {
                        InfoTypeId = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.InfoTypeId);
            
            CreateTable(
                "soooqa.IntruderTypes",
                c => new
                    {
                        IntruderTypeId = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.IntruderTypeId);
            
            CreateTable(
                "soooqa.TCUIs",
                c => new
                    {
                        TCUIId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TCUIType_TCUITypeId = c.Int(),
                    })
                .PrimaryKey(t => t.TCUIId)
                .ForeignKey("soooqa.TCUITypes", t => t.TCUIType_TCUITypeId)
                .Index(t => t.TCUIType_TCUITypeId);
            
            CreateTable(
                "soooqa.TCUIThreats",
                c => new
                    {
                        TCUIThreatId = c.Int(nullable: false, identity: true),
                        Identificator = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                        TCUI_TCUIId = c.Int(),
                    })
                .PrimaryKey(t => t.TCUIThreatId)
                .ForeignKey("soooqa.TCUIs", t => t.TCUI_TCUIId)
                .Index(t => t.TCUI_TCUIId);
            
            CreateTable(
                "soooqa.TCUITypes",
                c => new
                    {
                        TCUITypeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.TCUITypeId);
            
            CreateTable(
                "soooqa.TechnogenicMeasures",
                c => new
                    {
                        TechnogenicMeasureId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.TechnogenicMeasureId);
            
            CreateTable(
                "soooqa.TechnogenicThreats",
                c => new
                    {
                        TechnogenicThreatId = c.Int(nullable: false, identity: true),
                        Identificator = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.TechnogenicThreatId);
            
            CreateTable(
                "soooqa.SZIGISMeasures",
                c => new
                    {
                        SZI_SZIId = c.Int(nullable: false),
                        GISMeasure_GISMeasureId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SZI_SZIId, t.GISMeasure_GISMeasureId })
                .ForeignKey("soooqa.SZIs", t => t.SZI_SZIId, cascadeDelete: true)
                .ForeignKey("soooqa.GISMeasures", t => t.GISMeasure_GISMeasureId, cascadeDelete: true)
                .Index(t => t.SZI_SZIId)
                .Index(t => t.GISMeasure_GISMeasureId);
            
            CreateTable(
                "soooqa.SZISortSZIs",
                c => new
                    {
                        SZISort_SZISortId = c.Int(nullable: false),
                        SZI_SZIId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SZISort_SZISortId, t.SZI_SZIId })
                .ForeignKey("soooqa.SZISorts", t => t.SZISort_SZISortId, cascadeDelete: true)
                .ForeignKey("soooqa.SZIs", t => t.SZI_SZIId, cascadeDelete: true)
                .Index(t => t.SZISort_SZISortId)
                .Index(t => t.SZI_SZIId);
            
            CreateTable(
                "soooqa.SFHGISMeasures",
                c => new
                    {
                        SFH_SFHId = c.Int(nullable: false),
                        GISMeasure_GISMeasureId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SFH_SFHId, t.GISMeasure_GISMeasureId })
                .ForeignKey("soooqa.SFHs", t => t.SFH_SFHId, cascadeDelete: true)
                .ForeignKey("soooqa.GISMeasures", t => t.GISMeasure_GISMeasureId, cascadeDelete: true)
                .Index(t => t.SFH_SFHId)
                .Index(t => t.GISMeasure_GISMeasureId);
            
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
            
            CreateTable(
                "soooqa.ImplementWayThreats",
                c => new
                    {
                        ImplementWay_ImplementWayId = c.Int(nullable: false),
                        Threat_ThreatId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ImplementWay_ImplementWayId, t.Threat_ThreatId })
                .ForeignKey("soooqa.ImplementWays", t => t.ImplementWay_ImplementWayId, cascadeDelete: true)
                .ForeignKey("soooqa.Threats", t => t.Threat_ThreatId, cascadeDelete: true)
                .Index(t => t.ImplementWay_ImplementWayId)
                .Index(t => t.Threat_ThreatId);
            
            CreateTable(
                "soooqa.ThreatSFHs",
                c => new
                    {
                        Threat_ThreatId = c.Int(nullable: false),
                        SFH_SFHId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Threat_ThreatId, t.SFH_SFHId })
                .ForeignKey("soooqa.Threats", t => t.Threat_ThreatId, cascadeDelete: true)
                .ForeignKey("soooqa.SFHs", t => t.SFH_SFHId, cascadeDelete: true)
                .Index(t => t.Threat_ThreatId)
                .Index(t => t.SFH_SFHId);
            
            CreateTable(
                "soooqa.ThreatSourceThreats",
                c => new
                    {
                        ThreatSource_ThreatSourceId = c.Int(nullable: false),
                        Threat_ThreatId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ThreatSource_ThreatSourceId, t.Threat_ThreatId })
                .ForeignKey("soooqa.ThreatSources", t => t.ThreatSource_ThreatSourceId, cascadeDelete: true)
                .ForeignKey("soooqa.Threats", t => t.Threat_ThreatId, cascadeDelete: true)
                .Index(t => t.ThreatSource_ThreatSourceId)
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
            DropForeignKey("soooqa.TCUIs", "TCUIType_TCUITypeId", "soooqa.TCUITypes");
            DropForeignKey("soooqa.TCUIThreats", "TCUI_TCUIId", "soooqa.TCUIs");
            DropForeignKey("soooqa.VulnerabilityThreats", "Threat_ThreatId", "soooqa.Threats");
            DropForeignKey("soooqa.VulnerabilityThreats", "Vulnerability_VulnerabilityId", "soooqa.Vulnerabilities");
            DropForeignKey("soooqa.ThreatSourceThreats", "Threat_ThreatId", "soooqa.Threats");
            DropForeignKey("soooqa.ThreatSourceThreats", "ThreatSource_ThreatSourceId", "soooqa.ThreatSources");
            DropForeignKey("soooqa.ThreatSFHs", "SFH_SFHId", "soooqa.SFHs");
            DropForeignKey("soooqa.ThreatSFHs", "Threat_ThreatId", "soooqa.Threats");
            DropForeignKey("soooqa.ImplementWayThreats", "Threat_ThreatId", "soooqa.Threats");
            DropForeignKey("soooqa.ImplementWayThreats", "ImplementWay_ImplementWayId", "soooqa.ImplementWays");
            DropForeignKey("soooqa.ThreatGISMeasures", "GISMeasure_GISMeasureId", "soooqa.GISMeasures");
            DropForeignKey("soooqa.ThreatGISMeasures", "Threat_ThreatId", "soooqa.Threats");
            DropForeignKey("soooqa.SFHs", "SFHType_SFHTypeId", "soooqa.SFHTypes");
            DropForeignKey("soooqa.SFHGISMeasures", "GISMeasure_GISMeasureId", "soooqa.GISMeasures");
            DropForeignKey("soooqa.SFHGISMeasures", "SFH_SFHId", "soooqa.SFHs");
            DropForeignKey("soooqa.SZIs", "ISPDNMeasure_ISPDNMeasureId", "soooqa.ISPDNMeasures");
            DropForeignKey("soooqa.SZISortSZIs", "SZI_SZIId", "soooqa.SZIs");
            DropForeignKey("soooqa.SZISortSZIs", "SZISort_SZISortId", "soooqa.SZISorts");
            DropForeignKey("soooqa.SZIGISMeasures", "GISMeasure_GISMeasureId", "soooqa.GISMeasures");
            DropForeignKey("soooqa.SZIGISMeasures", "SZI_SZIId", "soooqa.SZIs");
            DropForeignKey("soooqa.ISPDNMeasures", "MeasureGroup_MeasureGroupId", "soooqa.MeasureGroups");
            DropForeignKey("soooqa.GISMeasures", "MeasureGroup_MeasureGroupId", "soooqa.MeasureGroups");
            DropForeignKey("soooqa.ConfigOptions", "GISMeasure_GISMeasureId", "soooqa.GISMeasures");
            DropIndex("soooqa.VulnerabilityThreats", new[] { "Threat_ThreatId" });
            DropIndex("soooqa.VulnerabilityThreats", new[] { "Vulnerability_VulnerabilityId" });
            DropIndex("soooqa.ThreatSourceThreats", new[] { "Threat_ThreatId" });
            DropIndex("soooqa.ThreatSourceThreats", new[] { "ThreatSource_ThreatSourceId" });
            DropIndex("soooqa.ThreatSFHs", new[] { "SFH_SFHId" });
            DropIndex("soooqa.ThreatSFHs", new[] { "Threat_ThreatId" });
            DropIndex("soooqa.ImplementWayThreats", new[] { "Threat_ThreatId" });
            DropIndex("soooqa.ImplementWayThreats", new[] { "ImplementWay_ImplementWayId" });
            DropIndex("soooqa.ThreatGISMeasures", new[] { "GISMeasure_GISMeasureId" });
            DropIndex("soooqa.ThreatGISMeasures", new[] { "Threat_ThreatId" });
            DropIndex("soooqa.SFHGISMeasures", new[] { "GISMeasure_GISMeasureId" });
            DropIndex("soooqa.SFHGISMeasures", new[] { "SFH_SFHId" });
            DropIndex("soooqa.SZISortSZIs", new[] { "SZI_SZIId" });
            DropIndex("soooqa.SZISortSZIs", new[] { "SZISort_SZISortId" });
            DropIndex("soooqa.SZIGISMeasures", new[] { "GISMeasure_GISMeasureId" });
            DropIndex("soooqa.SZIGISMeasures", new[] { "SZI_SZIId" });
            DropIndex("soooqa.TCUIThreats", new[] { "TCUI_TCUIId" });
            DropIndex("soooqa.TCUIs", new[] { "TCUIType_TCUITypeId" });
            DropIndex("soooqa.SFHs", new[] { "SFHType_SFHTypeId" });
            DropIndex("soooqa.SZIs", new[] { "ISPDNMeasure_ISPDNMeasureId" });
            DropIndex("soooqa.ISPDNMeasures", new[] { "MeasureGroup_MeasureGroupId" });
            DropIndex("soooqa.GISMeasures", new[] { "MeasureGroup_MeasureGroupId" });
            DropIndex("soooqa.ConfigOptions", new[] { "GISMeasure_GISMeasureId" });
            DropTable("soooqa.VulnerabilityThreats");
            DropTable("soooqa.ThreatSourceThreats");
            DropTable("soooqa.ThreatSFHs");
            DropTable("soooqa.ImplementWayThreats");
            DropTable("soooqa.ThreatGISMeasures");
            DropTable("soooqa.SFHGISMeasures");
            DropTable("soooqa.SZISortSZIs");
            DropTable("soooqa.SZIGISMeasures");
            DropTable("soooqa.TechnogenicThreats");
            DropTable("soooqa.TechnogenicMeasures");
            DropTable("soooqa.TCUITypes");
            DropTable("soooqa.TCUIThreats");
            DropTable("soooqa.TCUIs");
            DropTable("soooqa.IntruderTypes");
            DropTable("soooqa.InfoTypes");
            DropTable("soooqa.Vulnerabilities");
            DropTable("soooqa.ThreatSources");
            DropTable("soooqa.ImplementWays");
            DropTable("soooqa.Threats");
            DropTable("soooqa.SFHTypes");
            DropTable("soooqa.SFHs");
            DropTable("soooqa.SZISorts");
            DropTable("soooqa.SZIs");
            DropTable("soooqa.ISPDNMeasures");
            DropTable("soooqa.MeasureGroups");
            DropTable("soooqa.GISMeasures");
            DropTable("soooqa.ConfigOptions");
        }
    }
}
