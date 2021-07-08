
using business;
using business.banco;
using business.Classe;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Linq;

namespace database
{
    public abstract class  modelocrud 
    {
        public modelocrud()
        {
            bd = new BD();
        }

        [Key]
        public int Id { get; set; }

        public BD bd;

        [NotMapped]
        public static string textoPorcentagem = "0%";

        [NotMapped]
        public static List<modelocrud> modelos = new List<modelocrud>();

        [NotMapped]
        public static int condicaoTexto { get; set; }

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


        public  void alterar()
        {
            if (this is Admin      ) { var model = (Admin      ) this; bd.Entry(model).State = EntityState.Modified; }
            if (this is Comprador  ) { var model = (Comprador  ) this; bd.Entry(model).State = EntityState.Modified; }
            if (this is Dizimo     ) { var model = (Dizimo     ) this; bd.Entry(model).State = EntityState.Modified; }
            if (this is Oferta     ) { var model = (Oferta     ) this; bd.Entry(model).State = EntityState.Modified; }
            if (this is Cantina    ) { var model = (Cantina    ) this; bd.Entry(model).State = EntityState.Modified; }
            if (this is Bazar      ) { var model = (Bazar      ) this; bd.Entry(model).State = EntityState.Modified; }
            if (this is Lava_Rapido) { var model = (Lava_Rapido) this; bd.Entry(model).State = EntityState.Modified; }
            if (this is Aluguel    ) { var model = (Aluguel    ) this; bd.Entry(model).State = EntityState.Modified; }
            if (this is Compra     ) { var model = (Compra     ) this; bd.Entry(model).State = EntityState.Modified; }
            if (this is Retiro     ) { var model = (Retiro     ) this; bd.Entry(model).State = EntityState.Modified; }
            if (this is Transacao  ) { var model = (Transacao  ) this; bd.Entry(model).State = EntityState.Modified; }
            if (this is Transporte ) { var model = (Transporte ) this; bd.Entry(model).State = EntityState.Modified; }

            bd.SaveChanges();
        }

        public  void excluir()
        {
            if (this is Admin      ) { var model = (Admin      )this; bd.Pessoa      .Remove(model); }
            if (this is Comprador  ) { var model = (Comprador  )this; bd.Pessoa      .Remove(model); }
            if (this is Dizimo     ) { var model = (Dizimo     )this; bd.Movimentacao.Remove(model); }
            if (this is Oferta     ) { var model = (Oferta     )this; bd.Movimentacao.Remove(model); }
            if (this is Cantina    ) { var model = (Cantina    )this; bd.Movimentacao.Remove(model); }
            if (this is Bazar      ) { var model = (Bazar      )this; bd.Movimentacao.Remove(model); }
            if (this is Lava_Rapido) { var model = (Lava_Rapido)this; bd.Movimentacao.Remove(model); }
            if (this is Aluguel    ) { var model = (Aluguel    )this; bd.Movimentacao.Remove(model); }
            if (this is Compra     ) { var model = (Compra     )this; bd.Movimentacao.Remove(model); }
            if (this is Retiro     ) { var model = (Retiro     )this; bd.Movimentacao.Remove(model); }
            if (this is Transacao  ) { var model = (Transacao  )this; bd.Movimentacao.Remove(model); }
            if (this is Transporte ) { var model = (Transporte )this; bd.Movimentacao.Remove(model); }

            bd.SaveChanges();
        }

        public  modelocrud  recuperar(int id)
        {
            if ( this is Admin      ) { return bd.Pessoa      .FirstOrDefault(m => m.Id == id); }
            if ( this is Comprador  ) { return bd.Pessoa      .FirstOrDefault(m => m.Id == id); }
            if ( this is Dizimo     ) { return bd.Movimentacao.FirstOrDefault(m => m.Id == id); }
            if ( this is Oferta     ) { return bd.Movimentacao.FirstOrDefault(m => m.Id == id); }
            if ( this is Cantina    ) { return bd.Movimentacao.FirstOrDefault(m => m.Id == id); }
            if ( this is Bazar      ) { return bd.Movimentacao.FirstOrDefault(m => m.Id == id); }
            if ( this is Lava_Rapido) { return bd.Movimentacao.FirstOrDefault(m => m.Id == id); }
            if ( this is Aluguel    ) { return bd.Movimentacao.FirstOrDefault(m => m.Id == id); }
            if ( this is Compra     ) { return bd.Movimentacao.FirstOrDefault(m => m.Id == id); }
            if ( this is Retiro     ) { return bd.Movimentacao.FirstOrDefault(m => m.Id == id); }
            if ( this is Transacao  ) { return bd.Movimentacao.FirstOrDefault(m => m.Id == id); }
            if ( this is Transporte ) { return bd.Movimentacao.FirstOrDefault(m => m.Id == id); }
            return null;
        }

        public List<modelocrud> recuperar()
        {
             modelos.AddRange( bd.Pessoa      .ToList());
             modelos.AddRange( bd.Movimentacao.ToList());
            return modelos;
        }

        public List<modelocrud> PesquisarPorData(List<modelocrud> modelos, DateTime comecar, DateTime terminar, string campo)
        {
            List<modelocrud> q = null;
            if (modelos.OfType<Movimentacao>().ToList().Count > 0 && campo == "Data")
                q = modelos.OfType<Movimentacao>().Where(i => i.Data >= comecar && i.Data <= terminar).Cast<modelocrud>().ToList();

            if (modelos.OfType<MovimentacaoEntrada>().ToList().Count > 0 && campo == "DataRecebimento")
                q = modelos.OfType<MovimentacaoEntrada>().Where(i => i.DataRecebimento >= comecar && i.DataRecebimento <= terminar).Cast<modelocrud>().ToList();
            return q;
        }

        public List<modelocrud> PesquisarPorData(List<modelocrud> modelos, DateTime apenasUmDia, string campo)
        {
            List<modelocrud> q = null;
            return q;
        }

        public List<modelocrud> PesquisarPorMoeda(List<modelocrud> modelos, double comecar, double terminar, string campo)
        {
            List<modelocrud> q = null;
            if (modelos.OfType<Movimentacao>().ToList().Count > 0 && campo == "Valor")
            q = modelos.OfType<Movimentacao>().Where(i => i.Valor >= comecar && i.Valor <= terminar).Cast<modelocrud>().ToList();
            return q;
        }

        public List<modelocrud> PesquisarPorNumero(List<modelocrud> modelos, int comecar, int terminar, string campo)
        {
            List<modelocrud> q = null;
            if (modelos.OfType<Movimentacao>().ToList().Count > 0 && campo == "Id")
                q = modelos.OfType<Movimentacao>().Where(i => i.Id >= comecar && i.Id <= terminar).Cast<modelocrud>().ToList();

            if (modelos.OfType<Pessoa>().ToList().Count > 0 && campo == "Id")
                q = modelos.OfType<Pessoa>().Where(i => i.Id >= comecar && i.Id <= terminar).Cast<modelocrud>().ToList();

            if (modelos.OfType<MovimentacaoEntrada>().ToList().Count > 0 && campo == "Pessoa_")
                q = modelos.OfType<MovimentacaoEntrada>().Where(i => i.Pessoa_ >= comecar && i.Pessoa_ <= terminar).Cast<modelocrud>().ToList();
            return q;
        }

        public List<modelocrud> PesquisarPorNumero(List<modelocrud> modelos, int apenasUmNumero, string campo)
        {
            List<modelocrud> q = null;
            if (modelos.OfType<Movimentacao>().ToList().Count > 0 && campo == "Id")
                q = modelos.OfType<Movimentacao>().Where(i => i.Id >= apenasUmNumero).Cast<modelocrud>().ToList();

            if (modelos.OfType<Pessoa>().ToList().Count > 0 && campo == "Id")
                q = modelos.OfType<Pessoa>().Where(i => i.Id >= apenasUmNumero).Cast<modelocrud>().ToList();

            if (modelos.OfType<MovimentacaoEntrada>().ToList().Count > 0 && campo == "Pessoa_")
                q = modelos.OfType<MovimentacaoEntrada>().Where(i => i.Pessoa_ >= apenasUmNumero).Cast<modelocrud>().ToList();
            return q;
        }

        public List<modelocrud> PesquisarPorTexto(List<modelocrud> modelos, string texto, string campo)
        {
            List<modelocrud> q = null;

            if (modelos.OfType<Pessoa>().ToList().Count > 0 && campo == "Email")
                q = modelos.OfType<Pessoa>().Where(p => p.Contato.Email.Contains(texto)).Cast<modelocrud>().ToList();

            if (modelos.OfType<Pessoa>().ToList().Count > 0 && campo == "Nome")
                q = modelos.OfType<Pessoa>().Where(p => p.Nome.Contains(texto)).Cast<modelocrud>().ToList();

            if (modelos.OfType<Comprador>().ToList().Count > 0 && campo == "Email")
                q = modelos.OfType<Comprador>().Where(p => p.Contato.Email.Contains(texto)).Cast<modelocrud>().ToList();

            if (modelos.OfType<Comprador>().ToList().Count > 0 && campo == "Nome")
                q = modelos.OfType<Comprador>().Where(p => p.Nome.Contains(texto)).Cast<modelocrud>().ToList();
            return q;
        }

        public List<modelocrud> PesquisarPorHorario(List<modelocrud> modelos, TimeSpan comecar, TimeSpan terminar, string campo)
        {
            List<modelocrud> q = null;

            return q;
        }

        public List<modelocrud> PesquisarPorHorario(List<modelocrud> modelos, TimeSpan apenasUmHorario, string campo)
        {
            List<modelocrud> q = null;
            return q;
        }
    }
}
