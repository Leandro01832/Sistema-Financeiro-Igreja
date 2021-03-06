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

namespace sistema_financeiro.formulario
{
    public partial class FrmCrud : FrmPadrao
    {
        public FrmCrud()
        {
            InitializeComponent();
        }

        public FrmCrud(modelocrud modelo, bool deletar, bool atualizar, bool detalhes)
        {
            this.modelo = modelo;

            condicaoDeletar = deletar;
            condicaoAtualizar = atualizar;
            condicaoDetalhes = detalhes;

            Cadastrar = new Button();
            Cadastrar.Click += Cadastrar_Click;
            Cadastrar.Text = "Finalizar Cadastro";
            Cadastrar.Location = new Point(650, 250);
            Cadastrar.Size = new Size(100, 50);
            Cadastrar.Visible = false;

            Atualizar = new Button();
            Atualizar.Click += Atualizar_Click;
            Atualizar.Text = "Atualizar";
            Atualizar.Location = new Point(650, 350);
            Atualizar.Size = new Size(100, 50);
            Atualizar.Visible = false;

            Excluir = new Button();
            Excluir.Click += Excluir_Click;
            Excluir.Text = "Deletar";
            Excluir.Location = new Point(650, 250);
            Excluir.Size = new Size(100, 50);
            Excluir.Visible = false;

            this.Controls.Add(Excluir);
            this.Controls.Add(Atualizar);
            this.Controls.Add(Cadastrar);

            InfoForm = new Label();
            InfoForm.Visible = false;
            this.Controls.Add(InfoForm);

            if (condicaoAtualizar || condicaoDeletar || condicaoDetalhes)
            {
                InfoForm.Visible = true;
                Cadastrar.Visible = false;
                modelocrud.condicaoTexto = 1;
                InfoForm.Text = modelo.ToString();
            }
            else
            {
                Cadastrar.Visible = true;
            }

            if (condicaoAtualizar) Atualizar.Visible = true;
            if (condicaoDeletar) Excluir.Visible = true;

            InitializeComponent();
        }

        private bool condicaoDeletar;
        private bool condicaoAtualizar;
        private bool condicaoDetalhes;
        public bool CondicaoDeletar { get => condicaoDeletar; set => condicaoDeletar = value; }
        public bool CondicaoAtualizar { get => condicaoAtualizar; set => condicaoAtualizar = value; }
        public bool CondicaoDetalhes { get => condicaoDetalhes; set => condicaoDetalhes = value; }

        private void Excluir_Click(object sender, EventArgs e)
        {
            modelo.excluir();
            modelocrud.modelos.Remove(modelo);
            MessageBox.Show("Registro apagado com sucesso!!!");
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            modelo.alterar();
            MessageBox.Show("Alteração realizada com sucesso!!!");
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            modelo.salvar();
            modelocrud.modelos.Add(modelo);
            MessageBox.Show("Cadastro realizado com sucesso!!!");
        }

        public modelocrud modelo { get; set; }

        public Button Cadastrar { get; set; }
        public Button Atualizar { get; set; }
        public Button Excluir { get; set; }

        private Label InfoForm;

        private void FrmCrud_Load(object sender, EventArgs e)
        {
            if(modelo is Dizimo      && !admin.Permissao.Contains("Dizimo"     ))
            { Cadastrar.Enabled = false; Atualizar.Enabled = false; Excluir.Enabled = false;}
            if(modelo is Oferta      && !admin.Permissao.Contains("Oferta"     ))
            { Cadastrar.Enabled = false; Atualizar.Enabled = false; Excluir.Enabled = false;}
            if(modelo is Cantina     && !admin.Permissao.Contains("Cantina"    ))
            { Cadastrar.Enabled = false; Atualizar.Enabled = false; Excluir.Enabled = false;}
            if(modelo is Bazar       && !admin.Permissao.Contains("Bazar"      ))
            { Cadastrar.Enabled = false; Atualizar.Enabled = false; Excluir.Enabled = false;}
            if(modelo is Lava_Rapido && !admin.Permissao.Contains("Lava_Rapido"))
            { Cadastrar.Enabled = false; Atualizar.Enabled = false; Excluir.Enabled = false;}
            if(modelo is Aluguel     && !admin.Permissao.Contains("Aluguel"    ))
            { Cadastrar.Enabled = false; Atualizar.Enabled = false; Excluir.Enabled = false;}
            if(modelo is Compra      && !admin.Permissao.Contains("Compra"     ))
            { Cadastrar.Enabled = false; Atualizar.Enabled = false; Excluir.Enabled = false;}
            if(modelo is Retiro      && !admin.Permissao.Contains("Retiro"     ))
            { Cadastrar.Enabled = false; Atualizar.Enabled = false; Excluir.Enabled = false;}
            if(modelo is Transacao   && !admin.Permissao.Contains("Transacao"  ))
            { Cadastrar.Enabled = false; Atualizar.Enabled = false; Excluir.Enabled = false;}
            if(modelo is Transporte && !admin.Permissao.Contains("Transporte"  ))
            { Cadastrar.Enabled = false; Atualizar.Enabled = false; Excluir.Enabled = false; }
        }                                                                        
    }
}
