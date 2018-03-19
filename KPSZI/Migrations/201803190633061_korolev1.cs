namespace KPSZI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class korolev1 : DbMigration
    {
        public override void Up()
        {
            DropTable("public.SFH_Type");
        }
        
        public override void Down()
        {
            CreateTable(
                "public.SFH_Type",
                c => new
                    {
                        SFH_TypeID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.SFH_TypeID);
            
        }
    }
}
