namespace KPSZI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class some : DbMigration
    {
        public override void Up()
        {
            AddColumn("soooqa.ImplementWays", "WayNumber", c => c.Int(nullable: false));
            DropColumn("soooqa.ImplementWays", "ImplementWayNumber");
        }
        
        public override void Down()
        {
            AddColumn("soooqa.ImplementWays", "ImplementWayNumber", c => c.Int(nullable: false));
            DropColumn("soooqa.ImplementWays", "WayNumber");
        }
    }
}
