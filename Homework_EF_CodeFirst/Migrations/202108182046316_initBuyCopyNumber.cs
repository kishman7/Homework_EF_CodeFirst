namespace Homework_EF_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initBuyCopyNumber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "BuyCopyNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "BuyCopyNumber");
        }
    }
}
