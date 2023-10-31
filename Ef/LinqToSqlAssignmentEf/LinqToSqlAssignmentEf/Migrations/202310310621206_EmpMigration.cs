namespace LinqToSqlAssignmentEf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmpMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        Empid = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastNmae = c.String(),
                        Title = c.String(),
                        DOB = c.DateTime(nullable: false),
                        DOJ = c.DateTime(nullable: false),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Empid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employee");
        }
    }
}
