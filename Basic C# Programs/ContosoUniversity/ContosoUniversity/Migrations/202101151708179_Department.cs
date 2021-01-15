namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Department : DbMigration
    {
        public string Name { get; internal set; }
        public int Budget { get; internal set; }
        public DateTime StartDate { get; internal set; }
        public object InstructorID { get; internal set; }
        public int DepartmentID { get; internal set; }

        public override void Up()
        {
        }
        
        public override void Down()
        {
        }
    }
}
