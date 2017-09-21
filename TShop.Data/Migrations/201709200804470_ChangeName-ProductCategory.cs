namespace TShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProductCategory : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Categories", newName: "ProductCategories");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.ProductCategories", newName: "Categories");
        }
    }
}
