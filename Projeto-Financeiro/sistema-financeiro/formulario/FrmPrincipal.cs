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
    public partial class FrmPrincipal : Form
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
            Autenticação login = new Autenticação();
            login.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (FrmPadrao.condicaoSistema)
                sistemaToolStripMenuItem.Enabled = true;
            else
                sistemaToolStripMenuItem.Enabled = false;
        }
    }
}
