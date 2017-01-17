namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedb : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PostCategories", "ParentID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PostCategories", "ParentID", c => c.String());
        }
    }
}
