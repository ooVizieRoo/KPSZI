namespace KPSZI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Sashkiny_Tables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.InfoTypes",
                c => new
                    {
                        InfoTypeId = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.InfoTypeId);
            
            CreateTable(
                "public.IntruderTypes",
                c => new
                    {
                        IntruderTypeId = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.IntruderTypeId);
            
        }
        
        public override void Down()
        {
            DropTable("public.IntruderTypes");
            DropTable("public.InfoTypes");
        }
    }
}
