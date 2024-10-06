namespace BBMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UPdateIDentity : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DonorTbls", "DNum", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Patients", "PNum", c => c.Int(nullable: false, identity: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Patients", "PNum", c => c.Int(nullable: false));
            AlterColumn("dbo.DonorTbls", "DNum", c => c.Int(nullable: false));
        }
    }
}
