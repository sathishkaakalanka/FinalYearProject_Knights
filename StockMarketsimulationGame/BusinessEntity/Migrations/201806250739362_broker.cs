namespace BusinessEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class broker : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Brokers", "password", c => c.String());
            AddColumn("dbo.Brokers", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Brokers", "Email");
            DropColumn("dbo.Brokers", "password");
        }
    }
}
