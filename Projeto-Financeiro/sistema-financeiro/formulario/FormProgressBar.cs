
using database;
using sistema_financeiro.formulario;
using System;
using System.Data;
using System.Windows.Forms;

namespace sistema_financeiro.formulario
{
    public partial class FormProgressBar : FrmPadrao
    {
        public FormProgressBar()
        {
            InitializeComponent();
            
            label1.Text = modelocrud.textoPorcentagem;
        }

        private void FormProgressBar_Load(object sender, EventArgs e)
        {
        }

        private void ProgressBar_Tick(object sender, EventArgs e)
        {
            label1.Text = modelocrud.textoPorcentagem;
            var numero = modelocrud.textoPorcentagem.Replace("%", "");

            if (int.Parse(numero) <= 100)
                progressBar1.Value = int.Parse(numero);
            else
                progressBar1.Value = 100;
        }
    }
}
