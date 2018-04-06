namespace KPSZI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbInit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "soooka.GISMeasures",
                c => new
                    {
                        GISMeasureId = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        Description = c.String(),
                        MinimalRequirementDefenceClass = c.Int(nullable: false),
                        MeasureGroup_MeasureGroupId = c.Int(),
                    })
                .PrimaryKey(t => t.GISMeasureId)
                .ForeignKey("soooka.MeasureGroups", t => t.MeasureGroup_MeasureGroupId)
                .Index(t => t.MeasureGroup_MeasureGroupId);
            
            CreateTable(
                "soooka.MeasureGroups",
                c => new
                    {
                        MeasureGroupId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ShortName = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.MeasureGroupId);
            
            CreateTable(
                "soooka.ISPDNMeasures",
                c => new
                    {
                        ISPDNMeasureId = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        Description = c.String(),
                        MinimalRequirementDefenceLevel = c.Int(nullable: false),
                        MeasureGroup_MeasureGroupId = c.Int(),
                    })
                .PrimaryKey(t => t.ISPDNMeasureId)
                .ForeignKey("soooka.MeasureGroups", t => t.MeasureGroup_MeasureGroupId)
                .Index(t => t.MeasureGroup_MeasureGroupId);
            
            CreateTable(
                "soooka.SZIs",
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
                .ForeignKey("soooka.SZITypes", t => t.SZIType_SZITypeId)
                .Index(t => t.SZIType_SZITypeId);
            
            CreateTable(
                "soooka.SZITypes",
                c => new
                    {
                        SZITypeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.SZITypeId);
            
            CreateTable(
                "soooka.InfoTypes",
                c => new
                    {
                        InfoTypeId = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.InfoTypeId);
            
            CreateTable(
                "soooka.IntruderTypes",
                c => new
                    {
                        IntruderTypeId = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.IntruderTypeId);
            
            CreateTable(
                "soooka.SFHs",
                c => new
                    {
                        SFHId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ProjectSecurity = c.Int(nullable: false),
                        SFHType_SFHTypeId = c.Int(),
                    })
                .PrimaryKey(t => t.SFHId)
                .ForeignKey("soooka.SFHTypes", t => t.SFHType_SFHTypeId)
                .Index(t => t.SFHType_SFHTypeId);
            
            CreateTable(
                "soooka.SFHTypes",
                c => new
                    {
                        SFHTypeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.SFHTypeId);
            
            CreateTable(
                "soooka.TCUIs",
                c => new
                    {
                        TCUIId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TCUIType_TCUITypeId = c.Int(),
                    })
                .PrimaryKey(t => t.TCUIId)
                .ForeignKey("soooka.TCUITypes", t => t.TCUIType_TCUITypeId)
                .Index(t => t.TCUIType_TCUITypeId);
            
            CreateTable(
                "soooka.TCUIThreats",
                c => new
                    {
                        TCUIThreatId = c.Int(nullable: false, identity: true),
                        Identificator = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                        TCUI_TCUIId = c.Int(),
                    })
                .PrimaryKey(t => t.TCUIThreatId)
                .ForeignKey("soooka.TCUIs", t => t.TCUI_TCUIId)
                .Index(t => t.TCUI_TCUIId);
            
            CreateTable(
                "soooka.TCUITypes",
                c => new
                    {
                        TCUITypeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.TCUITypeId);
            
            CreateTable(
                "soooka.TechnogenicMeasures",
                c => new
                    {
                        TechnogenicMeasureId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.TechnogenicMeasureId);
            
            CreateTable(
                "soooka.TechnogenicThreats",
                c => new
                    {
                        TechnogenicThreatId = c.Int(nullable: false, identity: true),
                        Identificator = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.TechnogenicThreatId);
            
            CreateTable(
                "soooka.Threats",
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
                "soooka.ThreatSources",
                c => new
                    {
                        ThreatSourceId = c.Int(nullable: false, identity: true),
                        InternalIntruder = c.Boolean(nullable: false),
                        Potencial = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ThreatSourceId);
            
            CreateTable(
                "soooka.SZIGISMeasures",
                c => new
                    {
                        SZI_SZIId = c.Int(nullable: false),
                        GISMeasure_GISMeasureId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SZI_SZIId, t.GISMeasure_GISMeasureId })
                .ForeignKey("soooka.SZIs", t => t.SZI_SZIId, cascadeDelete: true)
                .ForeignKey("soooka.GISMeasures", t => t.GISMeasure_GISMeasureId, cascadeDelete: true)
                .Index(t => t.SZI_SZIId)
                .Index(t => t.GISMeasure_GISMeasureId);
            
            CreateTable(
                "soooka.SZIISPDNMeasures",
                c => new
                    {
                        SZI_SZIId = c.Int(nullable: false),
                        ISPDNMeasure_ISPDNMeasureId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SZI_SZIId, t.ISPDNMeasure_ISPDNMeasureId })
                .ForeignKey("soooka.SZIs", t => t.SZI_SZIId, cascadeDelete: true)
                .ForeignKey("soooka.ISPDNMeasures", t => t.ISPDNMeasure_ISPDNMeasureId, cascadeDelete: true)
                .Index(t => t.SZI_SZIId)
                .Index(t => t.ISPDNMeasure_ISPDNMeasureId);
            
            CreateTable(
                "soooka.ThreatSourceThreats",
                c => new
                    {
                        ThreatSource_ThreatSourceId = c.Int(nullable: false),
                        Threat_ThreatId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ThreatSource_ThreatSourceId, t.Threat_ThreatId })
                .ForeignKey("soooka.ThreatSources", t => t.ThreatSource_ThreatSourceId, cascadeDelete: true)
                .ForeignKey("soooka.Threats", t => t.Threat_ThreatId, cascadeDelete: true)
                .Index(t => t.ThreatSource_ThreatSourceId)
                .Index(t => t.Threat_ThreatId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("soooka.ThreatSourceThreats", "Threat_ThreatId", "soooka.Threats");
            DropForeignKey("soooka.ThreatSourceThreats", "ThreatSource_ThreatSourceId", "soooka.ThreatSources");
            DropForeignKey("soooka.TCUIs", "TCUIType_TCUITypeId", "soooka.TCUITypes");
            DropForeignKey("soooka.TCUIThreats", "TCUI_TCUIId", "soooka.TCUIs");
            DropForeignKey("soooka.SFHs", "SFHType_SFHTypeId", "soooka.SFHTypes");
            DropForeignKey("soooka.SZIs", "SZIType_SZITypeId", "soooka.SZITypes");
            DropForeignKey("soooka.SZIISPDNMeasures", "ISPDNMeasure_ISPDNMeasureId", "soooka.ISPDNMeasures");
            DropForeignKey("soooka.SZIISPDNMeasures", "SZI_SZIId", "soooka.SZIs");
            DropForeignKey("soooka.SZIGISMeasures", "GISMeasure_GISMeasureId", "soooka.GISMeasures");
            DropForeignKey("soooka.SZIGISMeasures", "SZI_SZIId", "soooka.SZIs");
            DropForeignKey("soooka.ISPDNMeasures", "MeasureGroup_MeasureGroupId", "soooka.MeasureGroups");
            DropForeignKey("soooka.GISMeasures", "MeasureGroup_MeasureGroupId", "soooka.MeasureGroups");
            DropIndex("soooka.ThreatSourceThreats", new[] { "Threat_ThreatId" });
            DropIndex("soooka.ThreatSourceThreats", new[] { "ThreatSource_ThreatSourceId" });
            DropIndex("soooka.SZIISPDNMeasures", new[] { "ISPDNMeasure_ISPDNMeasureId" });
            DropIndex("soooka.SZIISPDNMeasures", new[] { "SZI_SZIId" });
            DropIndex("soooka.SZIGISMeasures", new[] { "GISMeasure_GISMeasureId" });
            DropIndex("soooka.SZIGISMeasures", new[] { "SZI_SZIId" });
            DropIndex("soooka.TCUIThreats", new[] { "TCUI_TCUIId" });
            DropIndex("soooka.TCUIs", new[] { "TCUIType_TCUITypeId" });
            DropIndex("soooka.SFHs", new[] { "SFHType_SFHTypeId" });
            DropIndex("soooka.SZIs", new[] { "SZIType_SZITypeId" });
            DropIndex("soooka.ISPDNMeasures", new[] { "MeasureGroup_MeasureGroupId" });
            DropIndex("soooka.GISMeasures", new[] { "MeasureGroup_MeasureGroupId" });
            DropTable("soooka.ThreatSourceThreats");
            DropTable("soooka.SZIISPDNMeasures");
            DropTable("soooka.SZIGISMeasures");
            DropTable("soooka.ThreatSources");
            DropTable("soooka.Threats");
            DropTable("soooka.TechnogenicThreats");
            DropTable("soooka.TechnogenicMeasures");
            DropTable("soooka.TCUITypes");
            DropTable("soooka.TCUIThreats");
            DropTable("soooka.TCUIs");
            DropTable("soooka.SFHTypes");
            DropTable("soooka.SFHs");
            DropTable("soooka.IntruderTypes");
            DropTable("soooka.InfoTypes");
            DropTable("soooka.SZITypes");
            DropTable("soooka.SZIs");
            DropTable("soooka.ISPDNMeasures");
            DropTable("soooka.MeasureGroups");
            DropTable("soooka.GISMeasures");
        }
    }
}
