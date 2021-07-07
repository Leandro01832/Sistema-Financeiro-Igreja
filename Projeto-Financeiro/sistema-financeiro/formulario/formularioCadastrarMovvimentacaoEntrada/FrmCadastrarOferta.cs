using business.Classe;
using database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_financeiro.formulario.formularioCadastrarMovvimentacaoEntrada
{
    public partial class FrmCadastrarOferta : FrmCrud
    {
        public FrmCadastrarOferta(modelocrud modelo, bool deletar, bool atualizar, bool detalhes)
            : base(modelo, deletar, atualizar, detalhes)
        {
            InitializeComponent();
        }

        private void FrmCadastrarOferta_Load(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            Aluguel a = (Aluguel)modelo;
            try
            {
                a.Valor = double.Parse(txtValor.Text);
                a.Valor = double.Parse(a.Valor.ToString("F2"));
            }
            catch { MessageBox.Show("digite numeros"); txtValor.Text = ""; }
        }
    }
}
