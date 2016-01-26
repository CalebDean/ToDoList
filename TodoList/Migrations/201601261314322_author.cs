namespace TodoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class author : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ToDoes", "Author", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ToDoes", "Author");
        }
    }
}
