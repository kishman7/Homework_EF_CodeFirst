namespace Homework_EF_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GameModePlayer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "GameModePlayer", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "GameModePlayer");
        }
    }
}
