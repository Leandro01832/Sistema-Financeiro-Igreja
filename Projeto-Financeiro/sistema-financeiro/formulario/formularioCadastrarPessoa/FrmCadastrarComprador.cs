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

namespace sistema_financeiro.formulario.formularioCadastrarPessoa
{
    public partial class FrmCadastrarComprador : FrmCrud
    {
        public FrmCadastrarComprador(modelocrud modelo, bool deletar, bool atualizar, bool detalhes)
            : base(modelo, deletar, atualizar, detalhes)
        {
            InitializeComponent();
        }

        private void FrmCadastrarComprador_Load(object sender, EventArgs e)
        {
            
        }

        private void maskedWhatsapp_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Comprador c = (Comprador)modelo;
            c.Contato.Whatsapp = maskedWhatsapp.Text;

        }

        private void maskedTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Comprador c = (Comprador)modelo;
            c.Contato.Telefone = maskedTelefone.Text;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            Comprador c = (Comprador)modelo;
            c.Contato.Email = txtEmail.Text;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            Comprador c = (Comprador)modelo;
            c.Nome = txtNome.Text;
        }
    }
}
