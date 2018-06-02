namespace BusinessEntity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class StockMarket : DbContext
    {
        static StockMarket()
        {
            try
            {
                //var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;

                Database.SetInitializer<StockMarket>(null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public StockMarket()
            : base("name=StockMarket")
        {
        }
       // public  DbSet<Bank> Bank { get; set; }
        public DbSet<BankAccount> BankAccount { get; set; }
        public DbSet<Broker> Broker { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<CompanyVersion> CompanyVersion { get; set; }
        public DbSet<Invester> Invester { get; set; }
        public DbSet<Sector> Sector { get; set; }
        public DbSet<InvesterTransaction> InvesterTransaction { get; set; }
        public DbSet<BrokerTransaction> BrokerTransaction { get; set; }
        // public DbSet<TransactionType> TransactionType { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
        
    }
}
