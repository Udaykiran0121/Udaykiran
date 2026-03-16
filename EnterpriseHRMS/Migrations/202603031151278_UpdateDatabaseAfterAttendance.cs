namespace EnterpriseHRMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabaseAfterAttendance : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AttendanceModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(maxLength: 128),
                        EmployeeName = c.String(),
                        LoginTime = c.DateTime(nullable: false),
                        LogoutTime = c.DateTime(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
            AddColumn("dbo.EmployeeModels", "UserId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.EmployeeModels", "EmpFullName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.EmployeeModels", "Email", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.EmployeeModels", "Department", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.EmployeeModels", "CreatedBy", c => c.String(maxLength: 100));
            AlterColumn("dbo.EmployeeModels", "ModifiedBy", c => c.String(maxLength: 100));
            CreateIndex("dbo.EmployeeModels", "UserId");
            AddForeignKey("dbo.EmployeeModels", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeeModels", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AttendanceModels", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.EmployeeModels", new[] { "UserId" });
            DropIndex("dbo.AttendanceModels", new[] { "UserId" });
            AlterColumn("dbo.EmployeeModels", "ModifiedBy", c => c.String());
            AlterColumn("dbo.EmployeeModels", "CreatedBy", c => c.String());
            AlterColumn("dbo.EmployeeModels", "Department", c => c.String());
            AlterColumn("dbo.EmployeeModels", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.EmployeeModels", "EmpFullName", c => c.String(nullable: false));
            DropColumn("dbo.EmployeeModels", "UserId");
            DropTable("dbo.AttendanceModels");
        }
    }
}
