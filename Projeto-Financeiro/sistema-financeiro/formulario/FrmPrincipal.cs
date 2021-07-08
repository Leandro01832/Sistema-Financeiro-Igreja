using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_financeiro.formulario
{
    public partial class FrmPrincipal : FrmPadrao
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI mdi = MDISingleton.InstanciaMDI();
            mdi.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            UltimoRegistro();
            Autenticação login = new Autenticação();
            login.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick_1(object sender, EventArgs e)
        {
            if (FrmPadrao.condicaoSistema)
                sistemaToolStripMenuItem.Enabled = true;
            else
                sistemaToolStripMenuItem.Enabled = false;
        }
    }
}
