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
    public partial class FrmPadrao : Form
    {
        public FrmPadrao()
        {
            InitializeComponent();
        }

        public static bool condicaoSistema { get; set; }

        private void FrmPadrao_Load(object sender, EventArgs e)
        {
            condicaoSistema = false;
        }
    }
}
