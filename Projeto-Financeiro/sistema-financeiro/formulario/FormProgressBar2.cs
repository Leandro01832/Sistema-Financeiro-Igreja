using sistema_financeiro.formulario;
using System;
using System.Windows.Forms;

namespace sistema_financeiro.formulario
{
    public partial class FormProgressBar2 : FrmPadrao
    {
        public FormProgressBar2()
        {
            InitializeComponent();
        }

        private void FormProgressBar2_Load(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Marquee;
        }
    }
}
