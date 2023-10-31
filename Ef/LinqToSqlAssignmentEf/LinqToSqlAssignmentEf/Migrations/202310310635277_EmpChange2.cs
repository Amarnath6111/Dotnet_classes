namespace LinqToSqlAssignmentEf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmpChange2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Employee", newName: "EmployeeEfs");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.EmployeeEfs", newName: "Employee");
        }
    }
}
