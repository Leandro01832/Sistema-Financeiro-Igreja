using business.Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Program
    {
           static Random random = new Random();
        static void Main(string[] args)
        {

            for(int i = 0; i <= 500; i++)
            {
                cadastrarDizimo     ();
                cadastrarOferta     ();
                cadastrarCantina    ();
                cadastrarBazar      ();
                cadastrarLavaRapido ();
                cadastrarAluguel    ();
                cadastrarCompra     ();
                cadastrarRetiro     ();
                cadastrarTransacao  ();
                cadastrarTransporte ();

                Console.WriteLine(i.ToString());
            }

            Console.ReadLine();
        }

        public static void cadastrarDizimo()
        {
            var model = new Dizimo();
            model.Valor = random.NextDouble() * 1000;
            model.Data = new DateTime(random.Next(2021, 2023), random.Next(1, 12), random.Next(1, 28));
            model.Pago = random.NextDouble() > 0.5;
            if(!model.Pago) model.DataRecebimento = model.Data.AddDays(random.Next(1, 15));
            else model.DataRecebimento = model.Data;
            model.Pessoa_ = null;
            model.salvar();
        }
        public static void cadastrarOferta()
        {
            
          var model = new Oferta();
            model.Valor = random.NextDouble() * 1000;
            model.Data = new DateTime(random.Next(2021, 2023), random.Next(1, 12), random.Next(1, 28));
            model.Pago = random.NextDouble() > 0.5;
            if(!model.Pago) model.DataRecebimento = model.Data.AddDays(random.Next(1, 15));
            else model.DataRecebimento = model.Data;
            model.Pessoa_ = null;
            model.salvar();
        }
        public static void cadastrarCantina()
        {
            
          var model = new Cantina();
            model.Valor = random.NextDouble() * 1000;
            model.Data = new DateTime(random.Next(2021, 2023), random.Next(1, 12), random.Next(1, 28));
            model.Pago = random.NextDouble() > 0.5;
            if(!model.Pago) model.DataRecebimento = model.Data.AddDays(random.Next(1, 15));
            else model.DataRecebimento = model.Data;
            model.Pessoa_ = null;
            model.salvar();
        }
        public static void cadastrarBazar()
        {
            
          var model = new Bazar();
            model.Valor = random.NextDouble() * 1000;
            model.Data = new DateTime(random.Next(2021, 2023), random.Next(1, 12), random.Next(1, 28));
            model.Pago = random.NextDouble() > 0.5;
            if(!model.Pago) model.DataRecebimento = model.Data.AddDays(random.Next(1, 15));
            else model.DataRecebimento = model.Data;
            model.Pessoa_ = null;
            model.salvar();
        }
        public static void cadastrarLavaRapido()
        {
            
          var model = new Lava_Rapido();
            model.Valor = random.NextDouble() * 1000;
            model.Data = new DateTime(random.Next(2021, 2023), random.Next(1, 12), random.Next(1, 28));
            model.Pago = random.NextDouble() > 0.5;
            if (!model.Pago) model.DataRecebimento = model.Data.AddDays(random.Next(1, 15));
            else model.DataRecebimento = model.Data;
            model.Pessoa_ = null;
            model.salvar();
        }
        public static void cadastrarAluguel()
        {
            
          var model = new Aluguel();
            model.Valor = random.NextDouble() * 1000;
            model.Data = new DateTime(random.Next(2021, 2023), random.Next(1, 12), random.Next(1, 28));
            model.Pago = random.NextDouble() > 0.5;
            model.salvar();
        }
        public static void cadastrarCompra()
        {
            
          var model = new Compra();
            model.Valor = random.NextDouble() * 1000;
            model.Data = new DateTime(random.Next(2021, 2023), random.Next(1, 12), random.Next(1, 28));
            model.Pago = random.NextDouble() > 0.5;
            model.salvar();
        }
        public static void cadastrarRetiro()
        {
            
          var model = new Retiro();
            model.Valor = random.NextDouble() * 1000;
            model.Data = new DateTime(random.Next(2021, 2023), random.Next(1, 12), random.Next(1, 28));
            model.Pago = random.NextDouble() > 0.5;
            model.salvar();
        }
        public static void cadastrarTransacao()
        {
            
          var model = new Transacao();
            model.Valor = random.NextDouble() * 1000;
            model.Data = new DateTime(random.Next(2021, 2023), random.Next(1, 12), random.Next(1, 28));
            model.Pago = random.NextDouble() > 0.5;
            model.salvar();
        }
        public static void cadastrarTransporte()
        {
            
          var model = new Transporte();
            model.Valor = random.NextDouble() * 1000;
            model.Data = new DateTime(random.Next(2021, 2023), random.Next(1, 12), random.Next(1, 28));
            model.Pago = random.NextDouble() > 0.5;
            model.salvar();
        }
        
    }
}
