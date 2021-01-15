namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Instructor : DbMigration
    {
        public string LastName { get; internal set; }
        public object ID { get; internal set; }
        public string FirstMidName { get; internal set; }
        public DateTime HireDate { get; internal set; }

        public override void Up()
        {
        }
        
        public override void Down()
        {
        }
    }
}
