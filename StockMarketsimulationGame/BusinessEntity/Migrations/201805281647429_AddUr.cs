namespace BusinessEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUr : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BankAccounts", "BankId", "dbo.Banks");
            DropForeignKey("dbo.Transactions", "BankAccountId", "dbo.BankAccounts");
            DropForeignKey("dbo.Transactions", "BrokerId", "dbo.Brokers");
            DropForeignKey("dbo.Transactions", "InvesterId", "dbo.Investers");
            DropForeignKey("dbo.Transactions", "TransactionTypeId", "dbo.TransactionTypes");
            DropIndex("dbo.BankAccounts", new[] { "BankId" });
            DropIndex("dbo.Transactions", new[] { "BankAccountId" });
            DropIndex("dbo.Transactions", new[] { "BrokerId" });
            DropIndex("dbo.Transactions", new[] { "InvesterId" });
            DropIndex("dbo.Transactions", new[] { "TransactionTypeId" });
            CreateTable(
                "dbo.BrokerTransactions",
                c => new
                    {
                        TransactionId = c.Guid(nullable: false),
                        BrokerId = c.Guid(nullable: false),
                        CompanyId = c.Guid(nullable: false),
                        ShereAmount = c.Int(nullable: false),
                        UnitPrice = c.Double(nullable: false),
                        TransactionDate = c.DateTime(nullable: false),
                        TransactionType = c.String(),
                    })
                .PrimaryKey(t => t.TransactionId)
                .ForeignKey("dbo.Brokers", t => t.BrokerId, cascadeDelete: true)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: true)
                .Index(t => t.BrokerId)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.InvesterTransactions",
                c => new
                    {
                        TransactionId = c.Guid(nullable: false),
                        BrokerId = c.Guid(nullable: false),
                        InvesterId = c.Guid(nullable: false),
                        Amount = c.Double(nullable: false),
                        TransactionDate = c.DateTime(nullable: false),
                        TransactionType = c.String(),
                    })
                .PrimaryKey(t => t.TransactionId)
                .ForeignKey("dbo.Brokers", t => t.BrokerId, cascadeDelete: true)
                .ForeignKey("dbo.Investers", t => t.InvesterId, cascadeDelete: true)
                .Index(t => t.BrokerId)
                .Index(t => t.InvesterId);
            
            DropColumn("dbo.BankAccounts", "BankId");
            DropTable("dbo.Banks");
            DropTable("dbo.Transactions");
            DropTable("dbo.TransactionTypes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TransactionTypes",
                c => new
                    {
                        TransactionTypeId = c.Guid(nullable: false),
                        Transaction = c.String(),
                    })
                .PrimaryKey(t => t.TransactionTypeId);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        TransactionId = c.Guid(nullable: false),
                        BankAccountId = c.Guid(nullable: false),
                        BrokerId = c.Guid(nullable: false),
                        InvesterId = c.Guid(nullable: false),
                        TransactionTypeId = c.Guid(nullable: false),
                        Amount = c.Double(nullable: false),
                        TransactionDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TransactionId);
            
            CreateTable(
                "dbo.Banks",
                c => new
                    {
                        BankId = c.Guid(nullable: false),
                        BankName = c.String(),
                    })
                .PrimaryKey(t => t.BankId);
            
            AddColumn("dbo.BankAccounts", "BankId", c => c.Guid(nullable: false));
            DropForeignKey("dbo.InvesterTransactions", "InvesterId", "dbo.Investers");
            DropForeignKey("dbo.InvesterTransactions", "BrokerId", "dbo.Brokers");
            DropForeignKey("dbo.BrokerTransactions", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.BrokerTransactions", "BrokerId", "dbo.Brokers");
            DropIndex("dbo.InvesterTransactions", new[] { "InvesterId" });
            DropIndex("dbo.InvesterTransactions", new[] { "BrokerId" });
            DropIndex("dbo.BrokerTransactions", new[] { "CompanyId" });
            DropIndex("dbo.BrokerTransactions", new[] { "BrokerId" });
            DropTable("dbo.InvesterTransactions");
            DropTable("dbo.BrokerTransactions");
            CreateIndex("dbo.Transactions", "TransactionTypeId");
            CreateIndex("dbo.Transactions", "InvesterId");
            CreateIndex("dbo.Transactions", "BrokerId");
            CreateIndex("dbo.Transactions", "BankAccountId");
            CreateIndex("dbo.BankAccounts", "BankId");
            AddForeignKey("dbo.Transactions", "TransactionTypeId", "dbo.TransactionTypes", "TransactionTypeId", cascadeDelete: true);
            AddForeignKey("dbo.Transactions", "InvesterId", "dbo.Investers", "InvesterId", cascadeDelete: true);
            AddForeignKey("dbo.Transactions", "BrokerId", "dbo.Brokers", "BrokerId", cascadeDelete: true);
            AddForeignKey("dbo.Transactions", "BankAccountId", "dbo.BankAccounts", "BankAccountId", cascadeDelete: true);
            AddForeignKey("dbo.BankAccounts", "BankId", "dbo.Banks", "BankId", cascadeDelete: true);
        }
    }
}
