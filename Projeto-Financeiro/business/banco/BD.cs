using business.Classe;
using database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business.banco
{
   public class BD : DbContext
    {
        public BD() : base("Igreja")
        {
            Database.SetInitializer<BD>(null);
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
