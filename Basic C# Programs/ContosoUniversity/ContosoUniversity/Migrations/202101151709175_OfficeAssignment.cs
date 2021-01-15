namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OfficeAssignment : DbMigration
    {
        public object InstructorID { get; internal set; }
        public string Location { get; internal set; }

        public override void Up()
        {
        }
        
        public override void Down()
        {
        }
    }
}
