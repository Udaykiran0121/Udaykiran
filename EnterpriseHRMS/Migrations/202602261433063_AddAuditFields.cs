namespace EnterpriseHRMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAuditFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployeeModels", "CreatedBy", c => c.String());
            AddColumn("dbo.EmployeeModels", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.EmployeeModels", "ModifiedBy", c => c.String());
            AddColumn("dbo.EmployeeModels", "ModifiedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.EmployeeModels", "ModifiedDate");
            DropColumn("dbo.EmployeeModels", "ModifiedBy");
            DropColumn("dbo.EmployeeModels", "CreatedDate");
            DropColumn("dbo.EmployeeModels", "CreatedBy");
        }
    }
}
