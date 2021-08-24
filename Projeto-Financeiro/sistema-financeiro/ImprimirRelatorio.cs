using business.Classe;
using database;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace sistema_financeiro
{
    public class ImprimirRelatorio
    {
        public ImprimirRelatorio(List<modelocrud> modelos)
        {
            Modelos = modelos;
        }

        public List<modelocrud> Modelos { get; }

        public void imprimir(Type Tipo)
        {
            PdfPTable table = null;
            var valorTipo = "";
            var porcentagem = "";
            decimal totalPessoas = Modelos.OfType<Pessoa>().ToList().Count;
            decimal totalMovimentacao = Modelos.OfType<Movimentacao>().ToList().Count;

            if (Tipo.IsSubclassOf(typeof(Pessoa)) || Tipo == typeof(Pessoa))
            {
                table = new PdfPTable(2);
                decimal quant = Modelos.OfType<Pessoa>().Where(i =>  i.GetType().Name == Tipo.Name).ToList().Count;
                if(Tipo == typeof(Pessoa))
                    quant = Modelos.OfType<Pessoa>().ToList().Count;
                decimal p = (quant / totalPessoas);
                porcentagem = "A procentagem em relação ao total de pessoas é "
                    + (p * 100).ToString("f2") + "%. Quantidade de registros é: "
                    + quant;
            }

            if (Tipo.IsSubclassOf(typeof(Movimentacao)) || Tipo == typeof(Movimentacao))
            {
                decimal quant = 0;
                var quantDizimo      = Modelos.OfType<Dizimo     >().ToList().Count;
                var quantOferta      = Modelos.OfType<Oferta     >().ToList().Count;
                var quantCantina     = Modelos.OfType<Cantina    >().ToList().Count;
                var quantBazar       = Modelos.OfType<Bazar      >().ToList().Count;
                var quantLava_Rapido = Modelos.OfType<Lava_Rapido>().ToList().Count;
                var quantAluguel     = Modelos.OfType<Aluguel    >().ToList().Count;
                var quantCompra      = Modelos.OfType<Compra     >().ToList().Count;
                var quantRetiro      = Modelos.OfType<Retiro     >().ToList().Count;
                var quantTransacao   = Modelos.OfType<Transacao  >().ToList().Count;
                var quantTransporte = Modelos.OfType<Transporte  >().ToList().Count;
                if(Tipo == typeof(Dizimo     )) quant = quantDizimo     ;
                if(Tipo == typeof(Oferta     )) quant = quantOferta     ;
                if(Tipo == typeof(Cantina    )) quant = quantCantina    ;
                if(Tipo == typeof(Bazar      )) quant = quantBazar      ;
                if(Tipo == typeof(Lava_Rapido)) quant = quantLava_Rapido;
                if(Tipo == typeof(Aluguel    )) quant = quantAluguel    ;
                if(Tipo == typeof(Compra     )) quant = quantCompra     ;
                if(Tipo == typeof(Retiro     )) quant = quantRetiro     ;
                if(Tipo == typeof(Transacao  )) quant = quantTransacao  ;
                if (Tipo == typeof(Transporte)) quant = quantTransporte;
                if (Tipo == typeof(Movimentacao))
                quant = Modelos.OfType<Movimentacao>().ToList().Count;
                if (Tipo == typeof(MovimentacaoEntrada))
                    quant = Modelos.OfType<MovimentacaoEntrada>().ToList().Count;
                if (Tipo == typeof(MovimentacaoSaida))
                    quant = Modelos.OfType<MovimentacaoSaida>().ToList().Count;
                decimal p =  ( quant / totalMovimentacao);
                porcentagem = "A procentagem em relação ao total de movimentações é "
                 + (p * 100).ToString("f2") + "%. Quantidade de registros é: "
                 + quant;
            }
            

            if (Tipo == typeof(Pessoa) || Tipo.IsSubclassOf(typeof(Pessoa))) table = new PdfPTable(2);

            if (Tipo == typeof(Movimentacao) || Tipo.IsSubclassOf(typeof(Movimentacao))) table = new PdfPTable(4);

            valorTipo = Tipo.Name;

            modelocrud.condicaoTexto = 1;

            if (Tipo == typeof(Pessoa) || Tipo.IsSubclassOf(typeof(Pessoa)))            
                foreach (var item in Modelos.OfType<Pessoa>())
                {
                    table.AddCell("ID: " + item.Id.ToString());
                    table.AddCell("Nome: " + item.Nome.ToString());
                }

            if (Tipo == typeof(Movimentacao) || Tipo.IsSubclassOf(typeof(Movimentacao)))
            {
                List<Movimentacao> lista = new List<Movimentacao>();

                if (Tipo == typeof(Dizimo      ))    lista = Modelos.OfType<Dizimo      >().Cast<Movimentacao>().ToList();
                if (Tipo == typeof(Oferta      ))    lista = Modelos.OfType<Oferta      >().Cast<Movimentacao>().ToList();
                if (Tipo == typeof(Cantina     ))    lista = Modelos.OfType<Cantina     >().Cast<Movimentacao>().ToList();
                if (Tipo == typeof(Bazar       ))    lista = Modelos.OfType<Bazar       >().Cast<Movimentacao>().ToList();
                if (Tipo == typeof(Lava_Rapido ))    lista = Modelos.OfType<Lava_Rapido >().Cast<Movimentacao>().ToList();
                if (Tipo == typeof(Aluguel     ))    lista = Modelos.OfType<Aluguel     >().Cast<Movimentacao>().ToList();
                if (Tipo == typeof(Compra      ))    lista = Modelos.OfType<Compra      >().Cast<Movimentacao>().ToList();
                if (Tipo == typeof(Retiro      ))    lista = Modelos.OfType<Retiro      >().Cast<Movimentacao>().ToList();
                if (Tipo == typeof(Transacao   ))    lista = Modelos.OfType<Transacao   >().Cast<Movimentacao>().ToList();
                if (Tipo == typeof(Transporte  ))    lista = Modelos.OfType<Transporte  >().Cast<Movimentacao>().ToList();

                foreach (var item in lista)
                {
                    table.AddCell("ID: " + item.Id.ToString());
                    table.AddCell("Valor: " + item.Valor.ToString());
                    table.AddCell("Data: " + item.Data.ToString("dd/MM/yyyy"));
                    if (item is Dizimo)      table.AddCell("Tipo: " + "Dizimo     ");
                    if (item is Oferta)      table.AddCell("Tipo: " + "Oferta     ");
                    if (item is Cantina)     table.AddCell("Tipo: " + "Cantina    ");
                    if (item is Bazar)       table.AddCell("Tipo: " + "Bazar      ");
                    if (item is Lava_Rapido) table.AddCell("Tipo: " + "Lava_Rapido");
                    if (item is Aluguel)     table.AddCell("Tipo: " + "Aluguel    ");
                    if (item is Compra)      table.AddCell("Tipo: " + "Compra     ");
                    if (item is Retiro)      table.AddCell("Tipo: " + "Retiro     ");
                    if (item is Transacao)   table.AddCell("Tipo: " + "Transacao  ");
                    if (item is Transporte)  table.AddCell("Tipo: " + "Transporte ");
                }
            }
                


            Document doc = new Document(PageSize.A4);
            doc.SetMargins(40, 40, 40, 80);

            string path = Directory.GetCurrentDirectory();

            string caminho = path + @"\relatorio\" + "relatorio-" + valorTipo + "-" + DateTime.Now.ToString("dd-MM-yyyy") + ".pdf";

            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

            doc.Open();

            Paragraph titulo = new Paragraph();
            titulo.Font = new Font(Font.FontFamily.COURIER, 40);
            titulo.Alignment = Element.ALIGN_CENTER;
            titulo.Add("Relatório \n\n");
            doc.Add(titulo);



            Paragraph paragrafo = new Paragraph("", new Font(Font.NORMAL, 12));
            string conteudo = "Este é um relatório do dia " + DateTime.Now.ToString("dd/MM/yyyy") +
            " cujo o conteudo é referente a " + valorTipo + $". {porcentagem} \n\n";

            paragrafo.Add(conteudo);
            doc.Add(paragrafo);

           doc.Add(table);

            string caminhoImg =
            "http://www.clickfamilia.org.br/oikos2015/wp-content/uploads/2019/07/what-is-family-ministry-lead-300x225.jpg";
            Image img = Image.GetInstance(caminhoImg);

            doc.Add(img);

            doc.Close();

            System.Diagnostics.Process.Start(caminho);
        }
    }
}
