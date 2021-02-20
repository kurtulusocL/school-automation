namespace SchoolSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClassTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        IdentityNumber = c.String(),
                        PhoneNumber = c.String(),
                        MailAddress = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                        RegisterDate = c.DateTime(nullable: false),
                        LessonId = c.Int(nullable: false),
                        ClassTypeId = c.Int(nullable: false),
                        TeacherId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClassTypes", t => t.ClassTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Lessons", t => t.LessonId, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.TeacherId, cascadeDelete: true)
                .Index(t => t.LessonId)
                .Index(t => t.ClassTypeId)
                .Index(t => t.TeacherId);
            
            CreateTable(
                "dbo.Lessons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        IdentityNumber = c.String(),
                        PhoneNumber = c.String(),
                        MailAddress = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                        HireDate = c.DateTime(nullable: false),
                        LessonId = c.Int(),
                        ClassTypeId = c.Int(),
                        TaskInSchoolId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClassTypes", t => t.ClassTypeId)
                .ForeignKey("dbo.Lessons", t => t.LessonId)
                .ForeignKey("dbo.TaskInSchools", t => t.TaskInSchoolId, cascadeDelete: true)
                .Index(t => t.LessonId)
                .Index(t => t.ClassTypeId)
                .Index(t => t.TaskInSchoolId);
            
            CreateTable(
                "dbo.TaskInSchools",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KindOfTask = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Workers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        IdentityNumber = c.String(),
                        PhoneNumber = c.String(),
                        MailAddress = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                        HireDate = c.DateTime(nullable: false),
                        TaskInSchoolId = c.Int(nullable: false),
                        TeacherId = c.Int(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TaskInSchools", t => t.TaskInSchoolId, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.TeacherId)
                .Index(t => t.TaskInSchoolId)
                .Index(t => t.TeacherId);
            
            CreateTable(
                "dbo.StudentNotes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Exam1 = c.Double(nullable: false),
                        Exam2 = c.Double(nullable: false),
                        Vize = c.Double(nullable: false),
                        Exam3 = c.Double(nullable: false),
                        Final = c.Double(nullable: false),
                        StudentId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentNotes", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Workers", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.Workers", "TaskInSchoolId", "dbo.TaskInSchools");
            DropForeignKey("dbo.Teachers", "TaskInSchoolId", "dbo.TaskInSchools");
            DropForeignKey("dbo.Students", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.Teachers", "LessonId", "dbo.Lessons");
            DropForeignKey("dbo.Teachers", "ClassTypeId", "dbo.ClassTypes");
            DropForeignKey("dbo.Students", "LessonId", "dbo.Lessons");
            DropForeignKey("dbo.Students", "ClassTypeId", "dbo.ClassTypes");
            DropIndex("dbo.StudentNotes", new[] { "StudentId" });
            DropIndex("dbo.Workers", new[] { "TeacherId" });
            DropIndex("dbo.Workers", new[] { "TaskInSchoolId" });
            DropIndex("dbo.Teachers", new[] { "TaskInSchoolId" });
            DropIndex("dbo.Teachers", new[] { "ClassTypeId" });
            DropIndex("dbo.Teachers", new[] { "LessonId" });
            DropIndex("dbo.Students", new[] { "TeacherId" });
            DropIndex("dbo.Students", new[] { "ClassTypeId" });
            DropIndex("dbo.Students", new[] { "LessonId" });
            DropTable("dbo.StudentNotes");
            DropTable("dbo.Workers");
            DropTable("dbo.TaskInSchools");
            DropTable("dbo.Teachers");
            DropTable("dbo.Lessons");
            DropTable("dbo.Students");
            DropTable("dbo.ClassTypes");
        }
    }
}
