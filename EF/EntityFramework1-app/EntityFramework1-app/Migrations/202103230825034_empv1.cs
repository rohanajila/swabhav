namespace EntityFramework1_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class empv1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dept",
                c => new
                    {
                        DeptId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.DeptId);
            
            CreateTable(
                "dbo.Emps",
                c => new
                    {
                        EmpId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Salary = c.Double(nullable: false),
                        dept_DeptId = c.Int(),
                    })
                .PrimaryKey(t => t.EmpId)
                .ForeignKey("dbo.Dept", t => t.dept_DeptId)
                .Index(t => t.dept_DeptId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Emps", "dept_DeptId", "dbo.Dept");
            DropIndex("dbo.Emps", new[] { "dept_DeptId" });
            DropTable("dbo.Emps");
            DropTable("dbo.Dept");
        }
    }
}
