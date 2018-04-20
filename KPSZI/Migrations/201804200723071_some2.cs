namespace KPSZI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class some2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("soooqa.SFHs", "Threat_ThreatId", "soooqa.Threats");
            DropIndex("soooqa.SFHs", new[] { "Threat_ThreatId" });
            CreateTable(
                "soooqa.SFHThreats",
                c => new
                    {
                        SFH_SFHId = c.Int(nullable: false),
                        Threat_ThreatId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SFH_SFHId, t.Threat_ThreatId })
                .ForeignKey("soooqa.SFHs", t => t.SFH_SFHId, cascadeDelete: true)
                .ForeignKey("soooqa.Threats", t => t.Threat_ThreatId, cascadeDelete: true)
                .Index(t => t.SFH_SFHId)
                .Index(t => t.Threat_ThreatId);
            
            DropColumn("soooqa.SFHs", "Threat_ThreatId");
        }
        
        public override void Down()
        {
            AddColumn("soooqa.SFHs", "Threat_ThreatId", c => c.Int());
            DropForeignKey("soooqa.SFHThreats", "Threat_ThreatId", "soooqa.Threats");
            DropForeignKey("soooqa.SFHThreats", "SFH_SFHId", "soooqa.SFHs");
            DropIndex("soooqa.SFHThreats", new[] { "Threat_ThreatId" });
            DropIndex("soooqa.SFHThreats", new[] { "SFH_SFHId" });
            DropTable("soooqa.SFHThreats");
            CreateIndex("soooqa.SFHs", "Threat_ThreatId");
            AddForeignKey("soooqa.SFHs", "Threat_ThreatId", "soooqa.Threats", "ThreatId");
        }
    }
}
