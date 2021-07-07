using business;
using business.Classe;
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
    public partial class Autenticação : FrmPadrao
    {
        private Admin admin;

        public Autenticação()
        {
            InitializeComponent();
            admin = new Admin();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            admin.User = txtUser.Text;
            admin.Password = txtPassword.Text;
            if (Admin.PrimeiroAdminPassword == admin.Password &&
                Admin.PrimeiroAdminUser == admin.User)
            {
                FrmPadrao.condicaoSistema = true;
                MessageBox.Show("Você esta autenticado!!! Agora você pode acessar o sistema");
                this.Dispose();
            }
            else if(admin.verificarTodos())
            {
                FrmPadrao.condicaoSistema = true;
                MessageBox.Show("Você esta autenticado!!! Agora você pode acessar o sistema");
                this.Dispose();
            }
            else
            {
                FrmPadrao.condicaoSistema = false;
                MessageBox.Show("Você não esta autenticado!!!");
            }
        }

        private void Autenticação_Load(object sender, EventArgs e)
        {

        }
    }
}
