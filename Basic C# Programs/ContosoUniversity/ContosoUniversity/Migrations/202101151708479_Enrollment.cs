namespace ContosoUniversity.Migrations
{
    using ContosoUniversity.Models;
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Enrollment : DbMigration
    {
        public int StudentID { get; internal set; }
        public int CourseID { get; internal set; }
        public Grade Grade { get; internal set; }

        public override void Up()
        {
        }
        
        public override void Down()
        {
        }
    }
}
