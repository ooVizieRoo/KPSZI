namespace KPSZI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testToPublic : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.SFH_Type",
                c => new
                    {
                        SFH_TypeID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.SFH_TypeID);
            
            CreateTable(
                "public.SFHs",
                c => new
                    {
                        SFHId = c.Int(nullable: false, identity: true),
                        SFH_TypeID = c.Int(nullable: false),
                        Name = c.String(),
                        ProjectSecurity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SFHId);
            
            CreateTable(
                "public.Threats",
                c => new
                    {
                        ThreatId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        ThreatSource = c.String(),
                    })
                .PrimaryKey(t => t.ThreatId);
            
        }
        
        public override void Down()
        {
            DropTable("public.Threats");
            DropTable("public.SFHs");
            DropTable("public.SFH_Type");
        }
    }
}
