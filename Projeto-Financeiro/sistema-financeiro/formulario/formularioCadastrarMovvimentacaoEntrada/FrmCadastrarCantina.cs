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
    public partial class FrmCadastrarCantina : FrmCrud
    {
        public FrmCadastrarCantina(modelocrud modelo, bool deletar, bool atualizar, bool detalhes)
            : base(modelo, deletar, atualizar, detalhes)
        {
            InitializeComponent();
        }

        private void FrmCadastrarCantina_Load(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            Cantina a = (Cantina)modelo;
            try
            {
                a.Valor = double.Parse(txtValor.Text);
                a.Valor = double.Parse(a.Valor.ToString("F2"));
            }
            catch { MessageBox.Show("digite numeros"); txtValor.Text = ""; }
        }

        private void mask_data_recebimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Cantina a = (Cantina)modelo;
            try
            {
                a.DataRecebimento = Convert.ToDateTime(mask_data_recebimento.Text);
            }
            catch {  }
        }

        private void txt_numero_id_TextChanged(object sender, EventArgs e)
        {
            Bazar a = (Bazar)modelo;
            try
            {
                a.Pessoa_ = int.Parse(txt_numero_id.Text);
            }
            catch { MessageBox.Show("Informe um numero de identificação do comprador."); }
        }
    }
}
