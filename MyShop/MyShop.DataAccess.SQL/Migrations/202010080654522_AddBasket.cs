namespace MyShop.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBasket : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BasketItems",
                c => new
                    {
                        BasketId = c.String(nullable: false, maxLength: 128),
                        ProductId = c.String(),
                        Quantity = c.Int(nullable: false),
                        Basket_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.BasketId)
                .ForeignKey("dbo.Baskets", t => t.Basket_Id)
                .Index(t => t.Basket_Id);
            
            CreateTable(
                "dbo.Baskets",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BasketItems", "Basket_Id", "dbo.Baskets");
            DropIndex("dbo.BasketItems", new[] { "Basket_Id" });
            DropTable("dbo.Baskets");
            DropTable("dbo.BasketItems");
        }
    }
}
