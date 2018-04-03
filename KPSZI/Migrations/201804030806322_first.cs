namespace KPSZI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "nak.GISMeasures",
                c => new
                    {
                        GISMeasureId = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        MeasureGroupId = c.Int(nullable: false),
                        Description = c.String(),
                        MinimalRequirementDefenceClass = c.Int(nullable: false),
                        SZI_SZIId = c.Int(),
                    })
                .PrimaryKey(t => t.GISMeasureId)
                .ForeignKey("nak.MeasureGroups", t => t.MeasureGroupId, cascadeDelete: true)
                .ForeignKey("nak.SZIs", t => t.SZI_SZIId)
                .Index(t => t.MeasureGroupId)
                .Index(t => t.SZI_SZIId);
            
            CreateTable(
                "nak.InfoTypes",
                c => new
                    {
                        InfoTypeId = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.InfoTypeId);
            
            CreateTable(
                "nak.IntruderTypes",
                c => new
                    {
                        IntruderTypeId = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.IntruderTypeId);
            
            CreateTable(
                "nak.ISPDNMeasures",
                c => new
                    {
                        ISPDNMeasureId = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        Description = c.String(),
                        MinimalRequirementDefenceLevel = c.Int(nullable: false),
                        MeasureGroup_MeasureGroupId = c.Int(),
                        SZI_SZIId = c.Int(),
                    })
                .PrimaryKey(t => t.ISPDNMeasureId)
                .ForeignKey("nak.MeasureGroups", t => t.MeasureGroup_MeasureGroupId)
                .ForeignKey("nak.SZIs", t => t.SZI_SZIId)
                .Index(t => t.MeasureGroup_MeasureGroupId)
                .Index(t => t.SZI_SZIId);
            
            CreateTable(
                "nak.MeasureGroups",
                c => new
                    {
                        MeasureGroupId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.MeasureGroupId);
            
            CreateTable(
                "nak.SFHs",
                c => new
                    {
                        SFHId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ProjectSecurity = c.Int(nullable: false),
                        SFHType_SFHTypeId = c.Int(),
                    })
                .PrimaryKey(t => t.SFHId)
                .ForeignKey("nak.SFHTypes", t => t.SFHType_SFHTypeId)
                .Index(t => t.SFHType_SFHTypeId);
            
            CreateTable(
                "nak.SFHTypes",
                c => new
                    {
                        SFHTypeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.SFHTypeId);
            
            CreateTable(
                "nak.SZIs",
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
                .ForeignKey("nak.SZITypes", t => t.SZIType_SZITypeId)
                .Index(t => t.SZIType_SZITypeId);
            
            CreateTable(
                "nak.SZITypes",
                c => new
                    {
                        SZITypeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.SZITypeId);
            
            CreateTable(
                "nak.TCUIThreats",
                c => new
                    {
                        TCUIThreatId = c.Int(nullable: false, identity: true),
                        Identificator = c.String(),
                        Description = c.String(),
                        TCUIType_TCUITypeId = c.Int(),
                    })
                .PrimaryKey(t => t.TCUIThreatId)
                .ForeignKey("nak.TCUITypes", t => t.TCUIType_TCUITypeId)
                .Index(t => t.TCUIType_TCUITypeId);
            
            CreateTable(
                "nak.TCUITypes",
                c => new
                    {
                        TCUITypeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.TCUITypeId);
            
            CreateTable(
                "nak.TechnogenicMeasures",
                c => new
                    {
                        TechnogenicMeasureId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.TechnogenicMeasureId);
            
            CreateTable(
                "nak.TechnogenicThreats",
                c => new
                    {
                        TechnogenicThreatId = c.Int(nullable: false, identity: true),
                        Identificator = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.TechnogenicThreatId);
            
            CreateTable(
                "nak.Threats",
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
                "nak.ThreatSources",
                c => new
                    {
                        ThreatSourceId = c.Int(nullable: false, identity: true),
                        InternalIntruder = c.Boolean(nullable: false),
                        Potencial = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ThreatSourceId);
            
            CreateTable(
                "nak.ThreatSourceThreats",
                c => new
                    {
                        ThreatSource_ThreatSourceId = c.Int(nullable: false),
                        Threat_ThreatId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ThreatSource_ThreatSourceId, t.Threat_ThreatId })
                .ForeignKey("nak.ThreatSources", t => t.ThreatSource_ThreatSourceId, cascadeDelete: true)
                .ForeignKey("nak.Threats", t => t.Threat_ThreatId, cascadeDelete: true)
                .Index(t => t.ThreatSource_ThreatSourceId)
                .Index(t => t.Threat_ThreatId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("nak.ThreatSourceThreats", "Threat_ThreatId", "nak.Threats");
            DropForeignKey("nak.ThreatSourceThreats", "ThreatSource_ThreatSourceId", "nak.ThreatSources");
            DropForeignKey("nak.TCUIThreats", "TCUIType_TCUITypeId", "nak.TCUITypes");
            DropForeignKey("nak.SZIs", "SZIType_SZITypeId", "nak.SZITypes");
            DropForeignKey("nak.ISPDNMeasures", "SZI_SZIId", "nak.SZIs");
            DropForeignKey("nak.GISMeasures", "SZI_SZIId", "nak.SZIs");
            DropForeignKey("nak.SFHs", "SFHType_SFHTypeId", "nak.SFHTypes");
            DropForeignKey("nak.ISPDNMeasures", "MeasureGroup_MeasureGroupId", "nak.MeasureGroups");
            DropForeignKey("nak.GISMeasures", "MeasureGroupId", "nak.MeasureGroups");
            DropIndex("nak.ThreatSourceThreats", new[] { "Threat_ThreatId" });
            DropIndex("nak.ThreatSourceThreats", new[] { "ThreatSource_ThreatSourceId" });
            DropIndex("nak.TCUIThreats", new[] { "TCUIType_TCUITypeId" });
            DropIndex("nak.SZIs", new[] { "SZIType_SZITypeId" });
            DropIndex("nak.SFHs", new[] { "SFHType_SFHTypeId" });
            DropIndex("nak.ISPDNMeasures", new[] { "SZI_SZIId" });
            DropIndex("nak.ISPDNMeasures", new[] { "MeasureGroup_MeasureGroupId" });
            DropIndex("nak.GISMeasures", new[] { "SZI_SZIId" });
            DropIndex("nak.GISMeasures", new[] { "MeasureGroupId" });
            DropTable("nak.ThreatSourceThreats");
            DropTable("nak.ThreatSources");
            DropTable("nak.Threats");
            DropTable("nak.TechnogenicThreats");
            DropTable("nak.TechnogenicMeasures");
            DropTable("nak.TCUITypes");
            DropTable("nak.TCUIThreats");
            DropTable("nak.SZITypes");
            DropTable("nak.SZIs");
            DropTable("nak.SFHTypes");
            DropTable("nak.SFHs");
            DropTable("nak.MeasureGroups");
            DropTable("nak.ISPDNMeasures");
            DropTable("nak.IntruderTypes");
            DropTable("nak.InfoTypes");
            DropTable("nak.GISMeasures");
        }
    }
}
