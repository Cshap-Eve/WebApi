using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Models
{
    public class StudentContext:DbContext
    {
        public StudentContext() : base("con") 
        {
            Database.SetInitializer<StudentContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }

        public DbSet<Grade> Grades { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<StudentDoc> StudentDoc { get; set; }
        public DbSet<StudentGraduateInfo> StudentGraduateInfos { get; set; }
        public DbSet<StudentRelative> StudentRelatives { get; set; }
        public DbSet<StudentJob> StudentJob { get; set; }
        public DbSet<StudentLanComplete> StudentLanComplete { get; set; }
        public DbSet<StudentSigned> StudentSigns { get; set; }
        public DbSet<StudentTalked> StudentTalks { get; set; }
        public DbSet<SysSetting> SysSettings { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }
        public DbSet<Score> Scores { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<ClassTeacherHasClass> ClassTeacherHasClasses { get; set; }
    }
}
