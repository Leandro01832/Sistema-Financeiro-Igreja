using business.Classe;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace business.banco
{
    public class BD : DbContext
    {
        public BD() : base("Igreja")
        {
           //  Database.SetInitializer<BD>(null);
            var assegurarDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }        

        public DbSet<Movimentacao> Movimentacao        { get; set; }
        public DbSet<Dizimo     > Dizimo             { get; set; }
        public DbSet<Oferta     > Oferta             { get; set; }
        public DbSet<Cantina    > Cantina            { get; set; }
        public DbSet<Bazar      > Bazar              { get; set; }
        public DbSet<Lava_Rapido> Lava_Rapido        { get; set; }
        public DbSet<Aluguel    > Aluguel            { get; set; }
        public DbSet<Compra     > Compra             { get; set; }
        public DbSet<Retiro     > Retiro             { get; set; }
        public DbSet<Transacao  > Transacao          { get; set; }
        public DbSet<Transporte> Transporte          { get; set; }
        public DbSet<Pessoa      > Pessoa              { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
