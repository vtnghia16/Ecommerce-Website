namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_Product", "IsFeature", c => c.Boolean(nullable: false));
            AlterColumn("dbo.tb_Product", "IsHot", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_Product", "IsHot", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.tb_Product", "IsFeature", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
