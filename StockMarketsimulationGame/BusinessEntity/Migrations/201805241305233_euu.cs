namespace BusinessEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class euu : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Brokers", "BrokerName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Brokers", "BrokerName");
        }
    }
}
