namespace Blip.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrdersItems : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Guid(nullable: false),
                        CustomerID = c.Guid(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        Description = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ItemID = c.Guid(nullable: false),
                        Description = c.String(nullable: false, maxLength: 128),
                        ReorderQuantity = c.Int(nullable: false),
                        MSRP = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ItemID);
            
            CreateTable(
                "dbo.OrderItems",
                c => new
                    {
                        ItemID = c.Guid(nullable: false),
                        OrderID = c.Guid(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Short(nullable: false),
                    })
                .PrimaryKey(t => new { t.ItemID, t.OrderID })
                .ForeignKey("dbo.Items", t => t.ItemID, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: true)
                .Index(t => t.ItemID)
                .Index(t => t.OrderID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderItems", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.OrderItems", "ItemID", "dbo.Items");
            DropForeignKey("dbo.Orders", "CustomerID", "dbo.Customers");
            DropIndex("dbo.OrderItems", new[] { "OrderID" });
            DropIndex("dbo.OrderItems", new[] { "ItemID" });
            DropIndex("dbo.Orders", new[] { "CustomerID" });
            DropTable("dbo.OrderItems");
            DropTable("dbo.Items");
            DropTable("dbo.Orders");
        }
    }
}
