namespace DAL.Data.DBContexts
{
    using Entities;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    public class MAC2000Context : DbContext
    {
        static MAC2000Context()
        {
            // Database.SetInitializer(new CreateDatabaseIfNotExists<FirstDbContext>());
            //Database.SetInitializer(null);
        }
        public IDbSet<Partner> Partners { get; set; }
        public IDbSet<PartnerOrder> PartnerOrders { get; set; }
        //public IDbSet<Category> Categories { get; set; }
        //public IDbSet<Expense> Expenses { get; set; }
        //public IDbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
