namespace KPSZI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "soooqa.GISMeasures",
                c => new
                    {
                        GISMeasureId = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        Description = c.String(),
                        MinimalRequirementDefenceClass = c.Int(nullable: false),
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
                        CPUFrequencyRequirements = c.Int(nullable: false),
                        CPUCoresRequirements = c.Int(nullable: false),
                        MemoryRequirements = c.Int(nullable: false),
                        DiscSpaceRequirements = c.Int(nullable: false),
                        SZIType_SZITypeId = c.Int(),
                    })
                .PrimaryKey(t => t.SZIId)
                .ForeignKey("soooqa.SZITypes", t => t.SZIType_SZITypeId)
                .Index(t => t.SZIType_SZITypeId);
            
            CreateTable(
                "soooqa.SZITypes",
                c => new
                    {
                        SZITypeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.SZITypeId);
            
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
                "soooqa.SFHs",
                c => new
                    {
                        SFHId = c.Int(nullable: false, identity: true),
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
                    })
                .PrimaryKey(t => t.SFHTypeId);
            
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
                "soooqa.ThreatSources",
                c => new
                    {
                        ThreatSourceId = c.Int(nullable: false, identity: true),
                        InternalIntruder = c.Boolean(nullable: false),
                        Potencial = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ThreatSourceId);
            
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
                "soooqa.SZIISPDNMeasures",
                c => new
                    {
                        SZI_SZIId = c.Int(nullable: false),
                        ISPDNMeasure_ISPDNMeasureId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SZI_SZIId, t.ISPDNMeasure_ISPDNMeasureId })
                .ForeignKey("soooqa.SZIs", t => t.SZI_SZIId, cascadeDelete: true)
                .ForeignKey("soooqa.ISPDNMeasures", t => t.ISPDNMeasure_ISPDNMeasureId, cascadeDelete: true)
                .Index(t => t.SZI_SZIId)
                .Index(t => t.ISPDNMeasure_ISPDNMeasureId);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("soooqa.ThreatSourceThreats", "Threat_ThreatId", "soooqa.Threats");
            DropForeignKey("soooqa.ThreatSourceThreats", "ThreatSource_ThreatSourceId", "soooqa.ThreatSources");
            DropForeignKey("soooqa.TCUIs", "TCUIType_TCUITypeId", "soooqa.TCUITypes");
            DropForeignKey("soooqa.TCUIThreats", "TCUI_TCUIId", "soooqa.TCUIs");
            DropForeignKey("soooqa.SFHs", "SFHType_SFHTypeId", "soooqa.SFHTypes");
            DropForeignKey("soooqa.SZIs", "SZIType_SZITypeId", "soooqa.SZITypes");
            DropForeignKey("soooqa.SZIISPDNMeasures", "ISPDNMeasure_ISPDNMeasureId", "soooqa.ISPDNMeasures");
            DropForeignKey("soooqa.SZIISPDNMeasures", "SZI_SZIId", "soooqa.SZIs");
            DropForeignKey("soooqa.SZIGISMeasures", "GISMeasure_GISMeasureId", "soooqa.GISMeasures");
            DropForeignKey("soooqa.SZIGISMeasures", "SZI_SZIId", "soooqa.SZIs");
            DropForeignKey("soooqa.ISPDNMeasures", "MeasureGroup_MeasureGroupId", "soooqa.MeasureGroups");
            DropForeignKey("soooqa.GISMeasures", "MeasureGroup_MeasureGroupId", "soooqa.MeasureGroups");
            DropIndex("soooqa.ThreatSourceThreats", new[] { "Threat_ThreatId" });
            DropIndex("soooqa.ThreatSourceThreats", new[] { "ThreatSource_ThreatSourceId" });
            DropIndex("soooqa.SZIISPDNMeasures", new[] { "ISPDNMeasure_ISPDNMeasureId" });
            DropIndex("soooqa.SZIISPDNMeasures", new[] { "SZI_SZIId" });
            DropIndex("soooqa.SZIGISMeasures", new[] { "GISMeasure_GISMeasureId" });
            DropIndex("soooqa.SZIGISMeasures", new[] { "SZI_SZIId" });
            DropIndex("soooqa.TCUIThreats", new[] { "TCUI_TCUIId" });
            DropIndex("soooqa.TCUIs", new[] { "TCUIType_TCUITypeId" });
            DropIndex("soooqa.SFHs", new[] { "SFHType_SFHTypeId" });
            DropIndex("soooqa.SZIs", new[] { "SZIType_SZITypeId" });
            DropIndex("soooqa.ISPDNMeasures", new[] { "MeasureGroup_MeasureGroupId" });
            DropIndex("soooqa.GISMeasures", new[] { "MeasureGroup_MeasureGroupId" });
            DropTable("soooqa.ThreatSourceThreats");
            DropTable("soooqa.SZIISPDNMeasures");
            DropTable("soooqa.SZIGISMeasures");
            DropTable("soooqa.ThreatSources");
            DropTable("soooqa.Threats");
            DropTable("soooqa.TechnogenicThreats");
            DropTable("soooqa.TechnogenicMeasures");
            DropTable("soooqa.TCUITypes");
            DropTable("soooqa.TCUIThreats");
            DropTable("soooqa.TCUIs");
            DropTable("soooqa.SFHTypes");
            DropTable("soooqa.SFHs");
            DropTable("soooqa.IntruderTypes");
            DropTable("soooqa.InfoTypes");
            DropTable("soooqa.SZITypes");
            DropTable("soooqa.SZIs");
            DropTable("soooqa.ISPDNMeasures");
            DropTable("soooqa.MeasureGroups");
            DropTable("soooqa.GISMeasures");
        }
    }
}
