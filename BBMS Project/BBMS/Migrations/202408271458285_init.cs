namespace BBMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BloodTbls",
                c => new
                    {
                        BGroup = c.String(nullable: false, maxLength: 128),
                        BStook = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BGroup);
            
            CreateTable(
                "dbo.DonorTbls",
                c => new
                    {
                        NID = c.Int(nullable: false, identity: true),
                        DName = c.String(),
                        DAge = c.Int(nullable: false),
                        DNum = c.Int(nullable: false),
                        DGender = c.String(),
                        DPhone = c.String(),
                        DAddress = c.String(),
                        DBGroup = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.NID)
                .ForeignKey("dbo.BloodTbls", t => t.DBGroup)
                .Index(t => t.DBGroup);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        NId = c.Int(nullable: false, identity: true),
                        PNum = c.Int(nullable: false),
                        PName = c.String(),
                        PAge = c.Int(nullable: false),
                        PGender = c.String(),
                        PPhone = c.String(),
                        PAddress = c.String(),
                        PBGroup = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.NId)
                .ForeignKey("dbo.BloodTbls", t => t.PBGroup)
                .Index(t => t.PBGroup);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TransferTbls",
                c => new
                    {
                        TNum = c.Int(nullable: false, identity: true),
                        PName = c.String(),
                        PBGroup = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.TNum)
                .ForeignKey("dbo.BloodTbls", t => t.PBGroup)
                .Index(t => t.PBGroup);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TransferTbls", "PBGroup", "dbo.BloodTbls");
            DropForeignKey("dbo.Patients", "PBGroup", "dbo.BloodTbls");
            DropForeignKey("dbo.DonorTbls", "DBGroup", "dbo.BloodTbls");
            DropIndex("dbo.TransferTbls", new[] { "PBGroup" });
            DropIndex("dbo.Patients", new[] { "PBGroup" });
            DropIndex("dbo.DonorTbls", new[] { "DBGroup" });
            DropTable("dbo.TransferTbls");
            DropTable("dbo.Employees");
            DropTable("dbo.Patients");
            DropTable("dbo.DonorTbls");
            DropTable("dbo.BloodTbls");
        }
    }
}
