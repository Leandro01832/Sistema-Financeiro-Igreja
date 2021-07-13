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
    public partial class FrmCadastrarAdmin : FrmCrud
    {
        public FrmCadastrarAdmin(modelocrud modelo, bool deletar, bool atualizar, bool detalhes)
            : base(modelo, deletar, atualizar, detalhes)
        {
            InitializeComponent();
        }

        private void FrmCadastrarAdmin_Load(object sender, EventArgs e)
        {

        }

        private void maskedWhatsapp_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Admin c = (Admin)modelo;
            c.Contato.Whatsapp = maskedWhatsapp.Text;

        }

        private void maskedTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Admin c = (Admin)modelo;
            c.Contato.Telefone = maskedTelefone.Text;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            Admin c = (Admin)modelo;
            c.Contato.Email = txtEmail.Text;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            Admin c = (Admin)modelo;
            c.Nome = txtNome.Text;
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            Admin c = (Admin)modelo;
            c.Password = txtSenha.Text;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            Admin c = (Admin)modelo;
            c.User = txtUsuario.Text;
        }

        private void txtPermissao_TextChanged(object sender, EventArgs e)
        {
            Admin c = (Admin)modelo;
            c.Permissao = txtPermissao.Text;
        }
    }
}
