namespace TodoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class complete_property : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ToDoes", "Complete", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ToDoes", "Complete");
        }
    }
}
