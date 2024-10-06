namespace BBMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UPdateNID : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.DonorTbls");
            DropPrimaryKey("dbo.Patients");
            AlterColumn("dbo.DonorTbls", "NID", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Patients", "NId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.DonorTbls", "NID");
            AddPrimaryKey("dbo.Patients", "NId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Patients");
            DropPrimaryKey("dbo.DonorTbls");
            AlterColumn("dbo.Patients", "NId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.DonorTbls", "NID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Patients", "NId");
            AddPrimaryKey("dbo.DonorTbls", "NID");
        }
    }
}
