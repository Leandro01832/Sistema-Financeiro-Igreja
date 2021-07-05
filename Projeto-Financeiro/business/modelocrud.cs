
using business;
using business.banco;
using business.Classe;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;

namespace database
{
    public abstract class  modelocrud 
    {
        public modelocrud()
        {
            this.bd = new BD();
        }

        [Key]
        public int Id { get; set; }    

        public BD bd;

        public void salvar()
        {
            if (this is Admin      )  {var modelo = (Admin      )this; bd.Pessoa      .Add(modelo); }
            if (this is Pessoa     )  {var modelo = (Comprador  )this; bd.Pessoa      .Add(modelo); }
            if (this is Dizimo     )  {var modelo = (Dizimo     )this; bd.Movimentacao.Add(modelo); }
            if (this is Oferta     )  {var modelo = (Oferta     )this; bd.Movimentacao.Add(modelo); }
            if (this is Cantina    )  {var modelo = (Cantina    )this; bd.Movimentacao.Add(modelo); }
            if (this is Bazar      )  {var modelo = (Bazar      )this; bd.Movimentacao.Add(modelo); }
            if (this is Lava_Rapido)  {var modelo = (Lava_Rapido)this; bd.Movimentacao.Add(modelo); }
            if (this is Aluguel    )  {var modelo = (Aluguel    )this; bd.Movimentacao.Add(modelo); }
            if (this is Compra     )  {var modelo = (Compra     )this; bd.Movimentacao.Add(modelo); }
            if (this is Retiro     )  {var modelo = (Retiro     )this; bd.Movimentacao.Add(modelo); }
            if (this is Transacao  )  {var modelo = (Transacao  )this; bd.Movimentacao.Add(modelo); }
            if (this is Transporte )  {var modelo = (Transporte )this; bd.Movimentacao.Add(modelo); }
            
            bd.SaveChanges();
        }

        public  void alterar(modelocrud modelo)
        {
            if (modelo is Admin      ) { var model = (Admin      ) modelo; bd.Entry(model).State = EntityState.Modified; }
            if (modelo is Comprador  ) { var model = (Comprador  ) modelo; bd.Entry(model).State = EntityState.Modified; }
            if (modelo is Dizimo     ) { var model = (Dizimo     ) modelo; bd.Entry(model).State = EntityState.Modified; }
            if (modelo is Oferta     ) { var model = (Oferta     ) modelo; bd.Entry(model).State = EntityState.Modified; }
            if (modelo is Cantina    ) { var model = (Cantina    ) modelo; bd.Entry(model).State = EntityState.Modified; }
            if (modelo is Bazar      ) { var model = (Bazar      ) modelo; bd.Entry(model).State = EntityState.Modified; }
            if (modelo is Lava_Rapido) { var model = (Lava_Rapido) modelo; bd.Entry(model).State = EntityState.Modified; }
            if (modelo is Aluguel    ) { var model = (Aluguel    ) modelo; bd.Entry(model).State = EntityState.Modified; }
            if (modelo is Compra     ) { var model = (Compra     ) modelo; bd.Entry(model).State = EntityState.Modified; }
            if (modelo is Retiro     ) { var model = (Retiro     ) modelo; bd.Entry(model).State = EntityState.Modified; }
            if (modelo is Transacao  ) { var model = (Transacao  ) modelo; bd.Entry(model).State = EntityState.Modified; }
            if (modelo is Transporte ) { var model = (Transporte ) modelo; bd.Entry(model).State = EntityState.Modified; }

            bd.SaveChanges();
        }

        public  void excluir(modelocrud modelo)
        {
            if (this is Admin      ) { var model = (Admin      )modelo; bd.Pessoa      .Remove(model); }
            if (this is Comprador  ) { var model = (Comprador  )modelo; bd.Pessoa      .Remove(model); }
            if (this is Dizimo     ) { var model = (Dizimo     )modelo; bd.Movimentacao.Remove(model); }
            if (this is Oferta     ) { var model = (Oferta     )modelo; bd.Movimentacao.Remove(model); }
            if (this is Cantina    ) { var model = (Cantina    )modelo; bd.Movimentacao.Remove(model); }
            if (this is Bazar      ) { var model = (Bazar      )modelo; bd.Movimentacao.Remove(model); }
            if (this is Lava_Rapido) { var model = (Lava_Rapido)modelo; bd.Movimentacao.Remove(model); }
            if (this is Aluguel    ) { var model = (Aluguel    )modelo; bd.Movimentacao.Remove(model); }
            if (this is Compra     ) { var model = (Compra     )modelo; bd.Movimentacao.Remove(model); }
            if (this is Retiro     ) { var model = (Retiro     )modelo; bd.Movimentacao.Remove(model); }
            if (this is Transacao  ) { var model = (Transacao  )modelo; bd.Movimentacao.Remove(model); }
            if (this is Transporte ) { var model = (Transporte )modelo; bd.Movimentacao.Remove(model); }

            bd.SaveChanges();
        }

        public  modelocrud  recuperar(Type tipo, int id)
        {
            if (tipo.GetType() == typeof(Admin      )) { return bd.Pessoa      .First(m => m.Id == id); }
            if (tipo.GetType() == typeof(Comprador  )) { return bd.Pessoa      .First(m => m.Id == id); }
            if (tipo.GetType() == typeof(Dizimo     )) { return bd.Movimentacao.First(m => m.Id == id); }
            if (tipo.GetType() == typeof(Oferta     )) { return bd.Movimentacao.First(m => m.Id == id); }
            if (tipo.GetType() == typeof(Cantina    )) { return bd.Movimentacao.First(m => m.Id == id); }
            if (tipo.GetType() == typeof(Bazar      )) { return bd.Movimentacao.First(m => m.Id == id); }
            if (tipo.GetType() == typeof(Lava_Rapido)) { return bd.Movimentacao.First(m => m.Id == id); }
            if (tipo.GetType() == typeof(Aluguel    )) { return bd.Movimentacao.First(m => m.Id == id); }
            if (tipo.GetType() == typeof(Compra     )) { return bd.Movimentacao.First(m => m.Id == id); }
            if (tipo.GetType() == typeof(Retiro     )) { return bd.Movimentacao.First(m => m.Id == id); }
            if (tipo.GetType() == typeof(Transacao  )) { return bd.Movimentacao.First(m => m.Id == id); }
            if (tipo.GetType() == typeof(Transporte )) { return bd.Movimentacao.First(m => m.Id == id); }
            return null;
        }

        public List<modelocrud> recuperar(Type tipo)
        {
            if (tipo.GetType() == typeof(Admin      )) { return bd.Pessoa      .Cast<modelocrud>().ToList(); }
            if (tipo.GetType() == typeof(Comprador  )) { return bd.Pessoa      .Cast<modelocrud>().ToList(); }
            if (tipo.GetType() == typeof(Dizimo     )) { return bd.Movimentacao.Cast<modelocrud>().ToList(); }
            if (tipo.GetType() == typeof(Oferta     )) { return bd.Movimentacao.Cast<modelocrud>().ToList(); }
            if (tipo.GetType() == typeof(Cantina    )) { return bd.Movimentacao.Cast<modelocrud>().ToList(); }
            if (tipo.GetType() == typeof(Bazar      )) { return bd.Movimentacao.Cast<modelocrud>().ToList(); }
            if (tipo.GetType() == typeof(Lava_Rapido)) { return bd.Movimentacao.Cast<modelocrud>().ToList(); }
            if (tipo.GetType() == typeof(Aluguel    )) { return bd.Movimentacao.Cast<modelocrud>().ToList(); }
            if (tipo.GetType() == typeof(Compra     )) { return bd.Movimentacao.Cast<modelocrud>().ToList(); }
            if (tipo.GetType() == typeof(Retiro     )) { return bd.Movimentacao.Cast<modelocrud>().ToList(); }
            if (tipo.GetType() == typeof(Transacao  )) { return bd.Movimentacao.Cast<modelocrud>().ToList(); }
            if (tipo.GetType() == typeof(Transporte )) { return bd.Movimentacao.Cast<modelocrud>().ToList(); }
            return null;
        }       
        
    }
}
