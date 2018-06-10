namespace BusinessEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mmkhj : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Companies", "UnitPrice", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Companies", "UnitPrice", c => c.Double(nullable: false));
        }
    }
}
