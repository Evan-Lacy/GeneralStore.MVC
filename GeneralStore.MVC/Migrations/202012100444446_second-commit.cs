namespace GeneralStore.MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondcommit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewId = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        Rating = c.Int(nullable: false),
                        ReviewHeader = c.String(nullable: false, maxLength: 100),
                        ReviewText = c.String(nullable: false, maxLength: 1000),
                    })
                .PrimaryKey(t => t.ReviewId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Reviews", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Reviews", new[] { "CustomerId" });
            DropIndex("dbo.Reviews", new[] { "ProductId" });
            DropTable("dbo.Reviews");
        }
    }
}
