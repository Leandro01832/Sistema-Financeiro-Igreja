using business.Classe;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace business.banco
{
    public class BD : DbContext
    {
        public BD() : base("Igreja")
        {
            // Database.SetInitializer<BD>(null);
            var assegurarDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }        

        public DbSet<Movimentacao> Movimentacao        { get; set; }
        public DbSet<Pessoa      > Pessoa              { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
