namespace Raamatukogu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class das : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.RaamatuVäljaLaenutamine");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.RaamatuVäljaLaenutamine",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ÜleNädalaVeel = c.String(),
                        KuniNädalVeel = c.String(),
                        ÜletanudTähtaeg = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
