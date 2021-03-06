using business.Classe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_financeiro.formulario
{
    public partial class FrmDescrimina : Form
    {
        public FrmDescrimina(List<Movimentacao> lista, DateTime dateTime)
        {
            InitializeComponent();
            Lista = lista;
            Data = dateTime;
        }

        public List<Movimentacao> Lista { get; }
        public DateTime Data { get; }

        private void FrmDescrimina_Load(object sender, EventArgs e)
        {
            label1.Text = "Identificações de movimento de entrada: ";
            label2.Text = "Identificações de movimento de saída: ";
            this.Text = "Movimentações da data :" + Data.ToString("dd/MM/yyyy");
            dgDados.DataSource = Lista;
            dgDados.Columns["Data"].Width = 140;
            dgDados.Columns["Id"].Width = 100;
            dgDados.Font = new Font("Arial", 18);

            foreach(var item in Lista)
            {
                if (item is MovimentacaoEntrada)
                    label1.Text += item.Id + ", ";

                if (item is MovimentacaoSaida)
                    label2.Text += item.Id + ", ";
            }
        }
    }
}
