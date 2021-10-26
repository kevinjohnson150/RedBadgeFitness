namespace Fitness.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondmigration : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Workout");
            AddColumn("dbo.Workout", "WorkoutId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Workout", "Title", c => c.String(nullable: false));
            AddColumn("dbo.Workout", "Reps", c => c.String(nullable: false));
            AddColumn("dbo.Workout", "Sets", c => c.String(nullable: false));
            AddPrimaryKey("dbo.Workout", "WorkoutId");
            DropColumn("dbo.Workout", "UserId");
            DropColumn("dbo.Workout", "FirstName");
            DropColumn("dbo.Workout", "LastName");
            DropColumn("dbo.Workout", "FullName");
            DropColumn("dbo.Workout", "Phone");
            DropColumn("dbo.Workout", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Workout", "Email", c => c.String(nullable: false));
            AddColumn("dbo.Workout", "Phone", c => c.String(nullable: false));
            AddColumn("dbo.Workout", "FullName", c => c.String(nullable: false));
            AddColumn("dbo.Workout", "LastName", c => c.String());
            AddColumn("dbo.Workout", "FirstName", c => c.String());
            AddColumn("dbo.Workout", "UserId", c => c.Guid(nullable: false));
            DropPrimaryKey("dbo.Workout");
            DropColumn("dbo.Workout", "Sets");
            DropColumn("dbo.Workout", "Reps");
            DropColumn("dbo.Workout", "Title");
            DropColumn("dbo.Workout", "WorkoutId");
            AddPrimaryKey("dbo.Workout", "UserId");
        }
    }
}
