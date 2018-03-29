namespace KPSZI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class myschema : DbMigration
    {
        public override void Up()
        {
            MoveTable(name: "korolev.InfoTypes", newSchema: "nak");
            MoveTable(name: "korolev.IntruderTypes", newSchema: "nak");
            MoveTable(name: "korolev.SFHs", newSchema: "nak");
            MoveTable(name: "korolev.SFHTypes", newSchema: "nak");
            MoveTable(name: "korolev.Threats", newSchema: "nak");
            MoveTable(name: "korolev.ThreatSources", newSchema: "nak");
        }
        
        public override void Down()
        {
            MoveTable(name: "nak.ThreatSources", newSchema: "korolev");
            MoveTable(name: "nak.Threats", newSchema: "korolev");
            MoveTable(name: "nak.SFHTypes", newSchema: "korolev");
            MoveTable(name: "nak.SFHs", newSchema: "korolev");
            MoveTable(name: "nak.IntruderTypes", newSchema: "korolev");
            MoveTable(name: "nak.InfoTypes", newSchema: "korolev");
        }
    }
}
