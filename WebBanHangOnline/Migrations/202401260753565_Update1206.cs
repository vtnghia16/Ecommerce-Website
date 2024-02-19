namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update1206 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.tb_ProductImage", "ProductID");
            AddForeignKey("dbo.tb_ProductImage", "ProductID", "dbo.tb_Product", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_ProductImage", "ProductID", "dbo.tb_Product");
            DropIndex("dbo.tb_ProductImage", new[] { "ProductID" });
        }
    }
}
