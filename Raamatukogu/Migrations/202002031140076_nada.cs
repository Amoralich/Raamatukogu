namespace Raamatukogu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nada : DbMigration
    {
        public override void Up()
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
        
        public override void Down()
        {
            DropTable("dbo.RaamatuVäljaLaenutamine");
        }
    }
}
