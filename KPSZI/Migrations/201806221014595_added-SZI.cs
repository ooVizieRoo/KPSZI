namespace KPSZI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedSZI : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("soooqa.SZIISPDNMeasures", "SZI_SZIId", "soooqa.SZIs");
            DropForeignKey("soooqa.SZIISPDNMeasures", "ISPDNMeasure_ISPDNMeasureId", "soooqa.ISPDNMeasures");
            DropForeignKey("soooqa.SZIs", "SZIType_SZITypeId", "soooqa.SZITypes");
            DropIndex("soooqa.SZIs", new[] { "SZIType_SZITypeId" });
            DropIndex("soooqa.SZIISPDNMeasures", new[] { "SZI_SZIId" });
            DropIndex("soooqa.SZIISPDNMeasures", new[] { "ISPDNMeasure_ISPDNMeasureId" });
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
            
            AddColumn("soooqa.SZIs", "Name", c => c.String());
            AddColumn("soooqa.SZIs", "Certificate", c => c.String());
            AddColumn("soooqa.SZIs", "DateOfEnd", c => c.DateTime(nullable: false));
            AddColumn("soooqa.SZIs", "NDVControlLevel", c => c.Int(nullable: false));
            AddColumn("soooqa.SZIs", "SVTClass", c => c.String());
            AddColumn("soooqa.SZIs", "TU", c => c.String());
            AddColumn("soooqa.SZIs", "ISPDNMeasure_ISPDNMeasureId", c => c.Int());
            CreateIndex("soooqa.SZIs", "ISPDNMeasure_ISPDNMeasureId");
            AddForeignKey("soooqa.SZIs", "ISPDNMeasure_ISPDNMeasureId", "soooqa.ISPDNMeasures", "ISPDNMeasureId");
            DropColumn("soooqa.SZIs", "SZIType_SZITypeId");
            DropTable("soooqa.SZITypes");
            DropTable("soooqa.SZIISPDNMeasures");
        }
        
        public override void Down()
        {
            CreateTable(
                "soooqa.SZIISPDNMeasures",
                c => new
                    {
                        SZI_SZIId = c.Int(nullable: false),
                        ISPDNMeasure_ISPDNMeasureId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SZI_SZIId, t.ISPDNMeasure_ISPDNMeasureId });
            
            CreateTable(
                "soooqa.SZITypes",
                c => new
                    {
                        SZITypeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.SZITypeId);
            
            AddColumn("soooqa.SZIs", "SZIType_SZITypeId", c => c.Int());
            DropForeignKey("soooqa.SZIs", "ISPDNMeasure_ISPDNMeasureId", "soooqa.ISPDNMeasures");
            DropForeignKey("soooqa.SZISortSZIs", "SZI_SZIId", "soooqa.SZIs");
            DropForeignKey("soooqa.SZISortSZIs", "SZISort_SZISortId", "soooqa.SZISorts");
            DropIndex("soooqa.SZISortSZIs", new[] { "SZI_SZIId" });
            DropIndex("soooqa.SZISortSZIs", new[] { "SZISort_SZISortId" });
            DropIndex("soooqa.SZIs", new[] { "ISPDNMeasure_ISPDNMeasureId" });
            DropColumn("soooqa.SZIs", "ISPDNMeasure_ISPDNMeasureId");
            DropColumn("soooqa.SZIs", "TU");
            DropColumn("soooqa.SZIs", "SVTClass");
            DropColumn("soooqa.SZIs", "NDVControlLevel");
            DropColumn("soooqa.SZIs", "DateOfEnd");
            DropColumn("soooqa.SZIs", "Certificate");
            DropColumn("soooqa.SZIs", "Name");
            DropTable("soooqa.SZISortSZIs");
            DropTable("soooqa.SZISorts");
            CreateIndex("soooqa.SZIISPDNMeasures", "ISPDNMeasure_ISPDNMeasureId");
            CreateIndex("soooqa.SZIISPDNMeasures", "SZI_SZIId");
            CreateIndex("soooqa.SZIs", "SZIType_SZITypeId");
            AddForeignKey("soooqa.SZIs", "SZIType_SZITypeId", "soooqa.SZITypes", "SZITypeId");
            AddForeignKey("soooqa.SZIISPDNMeasures", "ISPDNMeasure_ISPDNMeasureId", "soooqa.ISPDNMeasures", "ISPDNMeasureId", cascadeDelete: true);
            AddForeignKey("soooqa.SZIISPDNMeasures", "SZI_SZIId", "soooqa.SZIs", "SZIId", cascadeDelete: true);
        }
    }
}
