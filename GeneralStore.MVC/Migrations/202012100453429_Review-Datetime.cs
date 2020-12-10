namespace GeneralStore.MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReviewDatetime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "DateofReviewUTC", c => c.DateTimeOffset(nullable: false, precision: 7));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "DateofReviewUTC");
        }
    }
}
