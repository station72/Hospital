namespace Hospital.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Profile = c.String(),
                        TherapeuticInstitutionsId = c.Int(nullable: false),
                        Address = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TherapeuticInstitutions", t => t.TherapeuticInstitutionsId, cascadeDelete: true)
                .Index(t => t.TherapeuticInstitutionsId);
            
            CreateTable(
                "dbo.TherapeuticInstitutions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Patronymic = c.String(),
                        Schedule = c.String(),
                        Cabinet = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        Role = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Departments", "TherapeuticInstitutionsId", "dbo.TherapeuticInstitutions");
            DropIndex("dbo.Employees", new[] { "DepartmentId" });
            DropIndex("dbo.Departments", new[] { "TherapeuticInstitutionsId" });
            DropTable("dbo.Users");
            DropTable("dbo.Employees");
            DropTable("dbo.TherapeuticInstitutions");
            DropTable("dbo.Departments");
        }
    }
}
