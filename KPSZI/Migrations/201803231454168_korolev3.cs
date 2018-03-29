namespace KPSZI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class korolev3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("public.Threats", "ThreatNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("public.Threats", "ThreatNumber");
        }
    }
}
