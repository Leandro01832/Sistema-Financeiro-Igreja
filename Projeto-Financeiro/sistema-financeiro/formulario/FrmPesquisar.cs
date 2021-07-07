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
    public partial class FrmPesquisar : Form
    {
        public FrmPesquisar(Type tipo)
        {
            InitializeComponent();
            Tipo = tipo;
        }

        public Type Tipo { get; }

        private void FrmPesquisar_Load(object sender, EventArgs e)
        {

        }
    }
}
