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
            int totalPessoas = Modelos.OfType<Pessoa>().ToList().Count;
            int totalMovimentacao = Modelos.OfType<Movimentacao>().ToList().Count;

            if (Tipo.IsSubclassOf(typeof(Pessoa)))
            {
                table = new PdfPTable(2);
                var quant = Modelos.OfType<Pessoa>().Where(i =>  i.GetType().Name == Tipo.Name).ToList().Count;
                decimal p = (quant / totalPessoas);
                porcentagem = "A procentagem em relação ao total de pessoas é "
                    + p.ToString("F2") + "%. Quantidade de registros é: "
                    + quant;
            }

            if (Tipo.IsSubclassOf(typeof(Movimentacao)))
            {
                var quant = Modelos.OfType<Movimentacao>().Where(i => i.GetType().Name == Tipo.Name).ToList().Count;
                decimal p = (quant / totalMovimentacao);
                porcentagem = "A procentagem em relação ao total de ministérios é "
                 + p.ToString("f2") + "%. Quantidade de registros é: "
                 + quant;
            }
            

            if (Tipo.IsSubclassOf(typeof(Pessoa))) table = new PdfPTable(2);

            if (Tipo == typeof(Movimentacao)) table = new PdfPTable(2);

            if (Tipo.IsAbstract)
                valorTipo = Tipo.Name;
            else
                valorTipo = Tipo.Name;

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


            if (Tipo == typeof(Pessoa))
            {
                foreach (var item in Modelos.OfType<Pessoa>())
                {
                    table.AddCell("ID: " + item.Id.ToString());
                    table.AddCell("Nome: " + item.Nome.ToString());
                }
            }
            else if (Tipo.IsSubclassOf(typeof(Movimentacao)))
            {
                foreach (var item in Modelos.OfType<Movimentacao>().Where(i => i.GetType().Name == Tipo.Name))
                {
                    table.AddCell("ID: " + item.Id.ToString());
                        table.AddCell("Data: " + item.Data.ToString());
                }
            }

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
