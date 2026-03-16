namespace EnterpriseHRMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSoftDeletionColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployeeModels", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.EmployeeModels", "IsDeleted");
        }
    }
}
