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
    public partial class FrmCadastrarLavaRapido : FrmCrud
    {
        public FrmCadastrarLavaRapido(modelocrud modelo, bool deletar, bool atualizar, bool detalhes)
            : base(modelo, deletar, atualizar, detalhes)
        {
            InitializeComponent();
        }

        private void FrmCadastrarLavaRapido_Load(object sender, EventArgs e)
        {
            var form = "Lava-Rápido";
            if (CondicaoAtualizar) this.Text = "Atualizar registro - " + form;
            if (CondicaoDeletar) this.Text = "Deletar registro - " + form;
            if (CondicaoDetalhes) this.Text = "Detalhes registro - " + form;
            if (!CondicaoDeletar && !CondicaoAtualizar && !CondicaoDetalhes) this.Text = "Cadastro - " + form;

            Lava_Rapido a = (Lava_Rapido)modelo;
            txtValor.Text = a.Valor.ToString();
            checkBoxPagou.Checked = a.Pago;
            if (a.Pessoa_ != null)
            txt_numero_id.Text = a.Pessoa_.ToString();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            Lava_Rapido a = (Lava_Rapido)modelo;
            try
            {
                a.Valor = double.Parse(txtValor.Text);
                a.Valor = double.Parse(a.Valor.ToString("F2"));
            }
            catch { MessageBox.Show("digite numeros"); txtValor.Text = ""; }
        }

        private void txt_numero_id_TextChanged(object sender, EventArgs e)
        {
            Lava_Rapido a = (Lava_Rapido)modelo;
            try
            {
                a.Pessoa_ = int.Parse(txt_numero_id.Text);
            }
            catch { MessageBox.Show("Informe um numero de identificação do comprador."); }
        }
    }
}
