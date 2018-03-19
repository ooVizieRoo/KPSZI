namespace KPSZI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class korolev2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.SFHTypes",
                c => new
                    {
                        SFHTypeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.SFHTypeId);
            
        }
        
        public override void Down()
        {
            DropTable("public.SFHTypes");
        }
    }
}
