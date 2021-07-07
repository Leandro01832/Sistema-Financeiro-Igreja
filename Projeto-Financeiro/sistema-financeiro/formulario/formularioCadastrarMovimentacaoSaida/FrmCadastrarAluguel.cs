using business.Classe;
using database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_financeiro.formulario.formularioCadastrarMovimentacaoSaida
{
    public partial class FrmCadastrarAluguel : FrmCrud
    {
        public FrmCadastrarAluguel() : base()
        {
            InitializeComponent();
        }

        public FrmCadastrarAluguel(modelocrud modelo, bool deletar, bool atualizar, bool detalhes)
            : base(modelo, deletar, atualizar, detalhes)
        {
            InitializeComponent();
        }

        private void FrmCadastrarAluguel_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxPagou_CheckedChanged(object sender, EventArgs e)
        {
            Aluguel a = (Aluguel)modelo;

            if (checkBoxPagou.Checked)
                a.Pago = true;
            else
                a.Pago = false;
        }        

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            Aluguel a = (Aluguel)modelo;
            try
            {
                a.Valor = double.Parse(txtValor.Text);
                a.Valor = double.Parse(a.Valor.ToString("F2"));
            }
            catch { MessageBox.Show("digite numeros"); txtValor.Text = "";}
        }
        
    }
}
