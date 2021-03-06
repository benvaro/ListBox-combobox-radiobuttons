namespace EF_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSalaryColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Salary", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Salary");
        }
    }
}
