namespace KPSZI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class korolev : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.ThreatSources",
                c => new
                    {
                        ThreatSourceId = c.Int(nullable: false, identity: true),
                        ThreatId = c.Int(nullable: false),
                        InternalIntruder = c.Boolean(nullable: false),
                        Potencial = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ThreatSourceId);
            
            AddColumn("public.Threats", "ObjectOfInfluence", c => c.String());
            AddColumn("public.Threats", "ConfidenceViolation", c => c.Boolean(nullable: false));
            AddColumn("public.Threats", "IntegrityViolation", c => c.Boolean(nullable: false));
            AddColumn("public.Threats", "AvailabilityViolation", c => c.Boolean(nullable: false));
            AddColumn("public.Threats", "DateOfAdd", c => c.DateTime(nullable: false));
            AddColumn("public.Threats", "DateOfChange", c => c.DateTime(nullable: false));
            DropColumn("public.Threats", "ThreatSource");
        }
        
        public override void Down()
        {
            AddColumn("public.Threats", "ThreatSource", c => c.String());
            DropColumn("public.Threats", "DateOfChange");
            DropColumn("public.Threats", "DateOfAdd");
            DropColumn("public.Threats", "AvailabilityViolation");
            DropColumn("public.Threats", "IntegrityViolation");
            DropColumn("public.Threats", "ConfidenceViolation");
            DropColumn("public.Threats", "ObjectOfInfluence");
            DropTable("public.ThreatSources");
        }
    }
}
