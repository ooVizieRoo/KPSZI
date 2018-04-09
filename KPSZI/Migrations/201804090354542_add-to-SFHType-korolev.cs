namespace KPSZI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtoSFHTypekorolev : DbMigration
    {
        public override void Up()
        {
            MoveTable(name: "soooka.GISMeasures", newSchema: "soooqa");
            MoveTable(name: "soooka.MeasureGroups", newSchema: "soooqa");
            MoveTable(name: "soooka.ISPDNMeasures", newSchema: "soooqa");
            MoveTable(name: "soooka.SZIs", newSchema: "soooqa");
            MoveTable(name: "soooka.SZITypes", newSchema: "soooqa");
            MoveTable(name: "soooka.InfoTypes", newSchema: "soooqa");
            MoveTable(name: "soooka.IntruderTypes", newSchema: "soooqa");
            MoveTable(name: "soooka.SFHs", newSchema: "soooqa");
            MoveTable(name: "soooka.SFHTypes", newSchema: "soooqa");
            MoveTable(name: "soooka.TCUIs", newSchema: "soooqa");
            MoveTable(name: "soooka.TCUIThreats", newSchema: "soooqa");
            MoveTable(name: "soooka.TCUITypes", newSchema: "soooqa");
            MoveTable(name: "soooka.TechnogenicMeasures", newSchema: "soooqa");
            MoveTable(name: "soooka.TechnogenicThreats", newSchema: "soooqa");
            MoveTable(name: "soooka.Threats", newSchema: "soooqa");
            MoveTable(name: "soooka.ThreatSources", newSchema: "soooqa");
            MoveTable(name: "soooka.SZIGISMeasures", newSchema: "soooqa");
            MoveTable(name: "soooka.SZIISPDNMeasures", newSchema: "soooqa");
            MoveTable(name: "soooka.ThreatSourceThreats", newSchema: "soooqa");
            AddColumn("soooqa.SFHTypes", "MultipleChoice", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("soooqa.SFHTypes", "MultipleChoice");
            MoveTable(name: "soooqa.ThreatSourceThreats", newSchema: "soooka");
            MoveTable(name: "soooqa.SZIISPDNMeasures", newSchema: "soooka");
            MoveTable(name: "soooqa.SZIGISMeasures", newSchema: "soooka");
            MoveTable(name: "soooqa.ThreatSources", newSchema: "soooka");
            MoveTable(name: "soooqa.Threats", newSchema: "soooka");
            MoveTable(name: "soooqa.TechnogenicThreats", newSchema: "soooka");
            MoveTable(name: "soooqa.TechnogenicMeasures", newSchema: "soooka");
            MoveTable(name: "soooqa.TCUITypes", newSchema: "soooka");
            MoveTable(name: "soooqa.TCUIThreats", newSchema: "soooka");
            MoveTable(name: "soooqa.TCUIs", newSchema: "soooka");
            MoveTable(name: "soooqa.SFHTypes", newSchema: "soooka");
            MoveTable(name: "soooqa.SFHs", newSchema: "soooka");
            MoveTable(name: "soooqa.IntruderTypes", newSchema: "soooka");
            MoveTable(name: "soooqa.InfoTypes", newSchema: "soooka");
            MoveTable(name: "soooqa.SZITypes", newSchema: "soooka");
            MoveTable(name: "soooqa.SZIs", newSchema: "soooka");
            MoveTable(name: "soooqa.ISPDNMeasures", newSchema: "soooka");
            MoveTable(name: "soooqa.MeasureGroups", newSchema: "soooka");
            MoveTable(name: "soooqa.GISMeasures", newSchema: "soooka");
        }
    }
}
