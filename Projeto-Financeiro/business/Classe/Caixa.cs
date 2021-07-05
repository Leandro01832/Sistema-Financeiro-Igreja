using database;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business.Classe
{
    public class Caixa : modelocrud
    {
        [NotMapped]
        public static int DiaMesFechamento { get; set; }
        [NotMapped]
        public static string Status { get; set; }
        [NotMapped]
        public static decimal Saldo{get;set;}


        public void calcularSaldoCaixa(bool liquido)
        {
            decimal valorPagar = 0;
            decimal valorReceber = 0;
            var contasPagar = this.recuperar(typeof(MovimentacaoSaida));
            var contasReceber = this.recuperar(typeof(MovimentacaoEntrada));

            if(contasPagar != null)
            foreach (var item in contasPagar.OfType<MovimentacaoSaida>().Where(c => !c.Pago && c.Data.Day < DiaMesFechamento))
                valorPagar += item.Valor;


            if (liquido)
            {
                if(contasReceber != null)
                foreach (var item in contasReceber.OfType<MovimentacaoEntrada>().Where(c => !c.Pago 
                && c.Data.Day < DiaMesFechamento || c.Pago && c.Data.Day < DiaMesFechamento))
                    valorReceber += item.Valor;

                Saldo = valorReceber - valorPagar;

                if (Saldo > 0) Status = "Saldo Positivo liquido: " + Saldo.ToString();
                else Status = "Saldo Negativo liquido: " + Saldo.ToString(); 
            }

            else
            {
                Saldo = valorReceber - valorPagar;
                if (contasReceber != null)
                    foreach (var item in contasReceber.OfType<MovimentacaoEntrada>().Where(c => c.Pago
                    && c.Data.Day < DiaMesFechamento))
                        valorReceber += item.Valor;

                Saldo = valorReceber - valorPagar;

                if (Saldo > 0) Status = "Saldo Positivo bruto: " + Saldo.ToString();
                else Status = "Saldo Negativo bruto: " + Saldo.ToString(); 
            }

        }
    }


}
