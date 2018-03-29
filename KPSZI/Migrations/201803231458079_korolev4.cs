namespace KPSZI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class korolev4 : DbMigration
    {
        public override void Up()
        {
            MoveTable(name: "public.InfoTypes", newSchema: "korolev");
            MoveTable(name: "public.IntruderTypes", newSchema: "korolev");
            MoveTable(name: "public.SFHs", newSchema: "korolev");
            MoveTable(name: "public.SFHTypes", newSchema: "korolev");
            MoveTable(name: "public.Threats", newSchema: "korolev");
            MoveTable(name: "public.ThreatSources", newSchema: "korolev");
        }
        
        public override void Down()
        {
            MoveTable(name: "korolev.ThreatSources", newSchema: "public");
            MoveTable(name: "korolev.Threats", newSchema: "public");
            MoveTable(name: "korolev.SFHTypes", newSchema: "public");
            MoveTable(name: "korolev.SFHs", newSchema: "public");
            MoveTable(name: "korolev.IntruderTypes", newSchema: "public");
            MoveTable(name: "korolev.InfoTypes", newSchema: "public");
        }
    }
}
