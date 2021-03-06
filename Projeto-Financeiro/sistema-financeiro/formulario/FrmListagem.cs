using business.Classe;
using database;
using sistema_financeiro.formulario.formularioCadastrarMovimentacaoSaida;
using sistema_financeiro.formulario.formularioCadastrarMovvimentacaoEntrada;
using sistema_financeiro.formulario.formularioCadastrarPessoa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_financeiro.formulario
{
    public partial class FrmListagem : FrmPadrao
    {
        bool atualizar = true;
        private Button botaoDetalhes { get; }
        private Button botaoAtualizar { get; }
        private Button botaoDeletar { get; }
        private Button botaoAtualizarLista { get; }
        private Type Tipo = null;
        public ListBox lista { get; }
        public int numero;

        public FrmListagem(Type tipo)
        {
            this.Tipo = tipo;
            this.Text = "Lista de ";

            if(tipo == typeof(Pessoa             )) this.Text += "Pessoas";
            if(tipo == typeof(Admin              )) this.Text += "Administradoes";
            if(tipo == typeof(Comprador          )) this.Text += "Compradores";
            if(tipo == typeof(Dizimo             )) this.Text += "Dizimos";
            if(tipo == typeof(Oferta             )) this.Text += "Ofertas";
            if(tipo == typeof(Cantina            )) this.Text += "Cantinas";
            if(tipo == typeof(Bazar              )) this.Text += "Bazar";
            if(tipo == typeof(Lava_Rapido        )) this.Text += "Lava-Rapido";
            if(tipo == typeof(Aluguel            )) this.Text += "Alugueis";
            if(tipo == typeof(Compra             )) this.Text += "Compras";
            if(tipo == typeof(Retiro             )) this.Text += "Retiro";
            if(tipo == typeof(Transacao          )) this.Text += "Transações";
            if(tipo == typeof(Transporte         )) this.Text += "Transporte";
            if(tipo == typeof(Movimentacao       )) this.Text += "Movimentação";
            if(tipo == typeof(MovimentacaoEntrada)) this.Text += "Movimentação de entrada";
            if(tipo == typeof(MovimentacaoSaida  )) this.Text += "Movimentação de saida";

            lista = new ListBox();
            lista.SelectedValueChanged += Lista_SelectedValueChanged;
            lista.Size = new Size(600, 300);
            lista.Location = new Point(50, 50);
            lista.Font = new Font("Arial", 15);

            botaoDeletar = new Button();
            botaoDeletar.Location = new Point(570, 120);
            botaoDeletar.Size = new Size(100, 50);
            botaoDeletar.Text = "Excluir";
            botaoDeletar.Click += BotaoDeletar_Click;
            botaoDeletar.Dock = DockStyle.Right;

            botaoAtualizar = new Button();
            botaoAtualizar.Location = new Point(570, 200);
            botaoAtualizar.Size = new Size(100, 50);
            botaoAtualizar.Text = "Atualizar";
            botaoAtualizar.Click += BotaoAtualizar_Click;
            botaoAtualizar.Dock = DockStyle.Right;

            botaoDetalhes = new Button();
            botaoDetalhes.Location = new Point(570, 280);
            botaoDetalhes.Size = new Size(100, 50);
            botaoDetalhes.Text = "Detalhes";
            botaoDetalhes.Click += BotaoDetalhes_Click;
            botaoDetalhes.Dock = DockStyle.Right;

            botaoAtualizarLista = new Button();
            botaoAtualizarLista.Location = new Point(570, 360);
            botaoAtualizarLista.Size = new Size(100, 50);
            botaoAtualizarLista.Text = "Atualizar lista";
            botaoAtualizarLista.Click += BotaoAtualizarLista_Click;
            botaoAtualizarLista.Dock = DockStyle.Right;

            botaoAtualizarLista.Enabled = atualizar;
            botaoDetalhes.Enabled = atualizar;
            botaoAtualizar.Enabled = atualizar;
            botaoDeletar.Enabled = atualizar;

            Controls.Add(botaoDetalhes);
            Controls.Add(botaoAtualizar);
            Controls.Add(botaoDeletar);
            Controls.Add(botaoAtualizarLista);
            Controls.Add(lista);

            InitializeComponent();
        }

        private void Lista_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                lista.Text = lista.SelectedValue.ToString();
                this.numero = int.Parse(Regex.Match(lista.Text, @"\d+").Value);
            }
            catch (Exception)
            {
            }
        }

        private void BotaoAtualizarLista_Click(object sender, EventArgs e)
        {
        }

        private void BotaoDeletar_Click(object sender, EventArgs e)
        {
            if (numero == 0)
            {
                MessageBox.Show("Escolha um item da lista.");
                return;
            }

            if(Tipo.IsSubclassOf(typeof(Movimentacao)) || Tipo == typeof(Movimentacao))
            {
                try
                {
                    var Modelo = modelocrud.modelos.OfType<Movimentacao>().First(i => i.Id == numero);
                    if(Modelo is Dizimo     ) { FrmCadastrarDizimo form = new FrmCadastrarDizimo        (Modelo, true, false, false); form.MdiParent = this.MdiParent; form.Show(); }
                    if(Modelo is Oferta     ) { FrmCadastrarOferta form = new FrmCadastrarOferta        (Modelo, true, false, false); form.MdiParent = this.MdiParent; form.Show(); }
                    if(Modelo is Cantina    ) { FrmCadastrarCantina form = new FrmCadastrarCantina      (Modelo, true, false, false); form.MdiParent = this.MdiParent; form.Show(); }
                    if(Modelo is Bazar      ) { FrmCadastrarBazar form = new FrmCadastrarBazar          (Modelo, true, false, false); form.MdiParent = this.MdiParent; form.Show(); }
                    if(Modelo is Lava_Rapido) { FrmCadastrarLavaRapido form = new FrmCadastrarLavaRapido(Modelo, true, false, false); form.MdiParent = this.MdiParent; form.Show(); }
                    if(Modelo is Aluguel    ) { FrmCadastrarAluguel form = new FrmCadastrarAluguel      (Modelo, true, false, false); form.MdiParent = this.MdiParent; form.Show(); }
                    if(Modelo is Compra     ) { FrmCadastrarCompra form = new FrmCadastrarCompra        (Modelo, true, false, false); form.MdiParent = this.MdiParent; form.Show(); }
                    if(Modelo is Retiro     ) {FrmCadastrarRetiro form = new FrmCadastrarRetiro         (Modelo, true, false, false); form.MdiParent = this.MdiParent; form.Show(); }
                    if(Modelo is Transacao  ) { FrmCadastrarTransacao form = new FrmCadastrarTransacao  (Modelo, true, false, false); form.MdiParent = this.MdiParent; form.Show(); }
                    if(Modelo is Transporte)  { FrmCadastrarTransporte form = new FrmCadastrarTransporte(Modelo, true, false, false); form.MdiParent = this.MdiParent; form.Show(); }                
                                        
                }
                catch { }
            }

            if (Tipo.IsSubclassOf(typeof(Pessoa)) || Tipo == typeof(Pessoa))
            {
                try
                {
                    var Modelo = modelocrud.modelos.OfType<Pessoa>().First(i => i.Id == numero);
                    if (Modelo is Comprador) { FrmCadastrarComprador form = new FrmCadastrarComprador(Modelo, true, false, false); form.MdiParent = this.MdiParent; form.Show(); }
                    if (Modelo is Admin) { FrmCadastrarAdmin form = new FrmCadastrarAdmin            (Modelo, true, false, false); form.MdiParent = this.MdiParent; form.Show(); }

                }
                catch { }
            }

        }       

        private void BotaoDetalhes_Click(object sender, EventArgs e)
        {
            if (numero == 0)
            {
                MessageBox.Show("Escolha um item da lista.");
                return;
            }

            if (Tipo.IsSubclassOf(typeof(Movimentacao)) || Tipo == typeof(Movimentacao))
            {
                try
                {
                    var Modelo = modelocrud.modelos.OfType<Movimentacao>().First(i => i.Id == numero);
                    if (Modelo is Dizimo)      { FrmCadastrarDizimo form = new FrmCadastrarDizimo        (Modelo, false, false, true); form.MdiParent = this.MdiParent; form.Show(); }
                    if (Modelo is Oferta     ) { FrmCadastrarOferta form = new FrmCadastrarOferta        (Modelo, false, false, true); form.MdiParent = this.MdiParent; form.Show(); }
                     if(Modelo is Cantina    ) { FrmCadastrarCantina form = new FrmCadastrarCantina      (Modelo, false, false, true); form.MdiParent = this.MdiParent; form.Show(); }
                     if(Modelo is Bazar      ) { FrmCadastrarBazar form = new FrmCadastrarBazar          (Modelo, false, false, true); form.MdiParent = this.MdiParent; form.Show(); }
                     if(Modelo is Lava_Rapido) { FrmCadastrarLavaRapido form = new FrmCadastrarLavaRapido(Modelo, false, false, true); form.MdiParent = this.MdiParent; form.Show(); }
                     if(Modelo is Aluguel    ) { FrmCadastrarAluguel form = new FrmCadastrarAluguel      (Modelo, false, false, true); form.MdiParent = this.MdiParent; form.Show(); }
                     if(Modelo is Compra     ) { FrmCadastrarCompra form = new FrmCadastrarCompra        (Modelo, false, false, true); form.MdiParent = this.MdiParent; form.Show(); }
                     if(Modelo is Retiro     ) {FrmCadastrarRetiro form = new FrmCadastrarRetiro         (Modelo, false, false, true); form.MdiParent = this.MdiParent; form.Show(); }
                     if(Modelo is Transacao  ) { FrmCadastrarTransacao form = new FrmCadastrarTransacao  (Modelo, false, false, true); form.MdiParent = this.MdiParent; form.Show(); }
                     if(Modelo is Transporte)  { FrmCadastrarTransporte form = new FrmCadastrarTransporte(Modelo, false, false, true); form.MdiParent = this.MdiParent; form.Show(); } 

                }
                catch { }
            }

            if (Tipo.IsSubclassOf(typeof(Pessoa)) || Tipo == typeof(Pessoa))
            {
                try
                {
                    var Modelo = modelocrud.modelos.OfType<Pessoa>().First(i => i.Id == numero);
                    if (Modelo is Comprador) { FrmCadastrarComprador form = new FrmCadastrarComprador(Modelo, false, false, true); form.MdiParent = this.MdiParent; form.Show(); }
                    if (Modelo is Admin) { FrmCadastrarAdmin form = new FrmCadastrarAdmin            (Modelo, false, false, true); form.MdiParent = this.MdiParent; form.Show(); }

                }
                catch { }
            }
        }

        private void BotaoAtualizar_Click(object sender, EventArgs e)
        {
            if (numero == 0)
            {
                MessageBox.Show("Escolha um item da lista.");
                return;
            }

            if (Tipo.IsSubclassOf(typeof(Movimentacao)) || Tipo == typeof(Movimentacao))
            {
                try
                {
                    var Modelo = modelocrud.modelos.OfType<Movimentacao>().First(i => i.Id == numero);
                    if (Modelo is Dizimo    ) { FrmCadastrarDizimo form = new FrmCadastrarDizimo        (Modelo, false, true, false); form.MdiParent = this.MdiParent; form.Show(); }
                    if (Modelo is Oferta    ) { FrmCadastrarOferta form = new FrmCadastrarOferta        (Modelo, false, true, false); form.MdiParent = this.MdiParent; form.Show(); }
                    if(Modelo is Cantina    ) { FrmCadastrarCantina form = new FrmCadastrarCantina      (Modelo, false, true, false); form.MdiParent = this.MdiParent; form.Show(); }
                    if(Modelo is Bazar      ) { FrmCadastrarBazar form = new FrmCadastrarBazar          (Modelo, false, true, false); form.MdiParent = this.MdiParent; form.Show(); }
                    if(Modelo is Lava_Rapido) { FrmCadastrarLavaRapido form = new FrmCadastrarLavaRapido(Modelo, false, true, false); form.MdiParent = this.MdiParent; form.Show(); }
                    if(Modelo is Aluguel    ) { FrmCadastrarAluguel form = new FrmCadastrarAluguel      (Modelo, false, true, false); form.MdiParent = this.MdiParent; form.Show(); }
                    if(Modelo is Compra     ) { FrmCadastrarCompra form = new FrmCadastrarCompra        (Modelo, false, true, false); form.MdiParent = this.MdiParent; form.Show(); }
                    if(Modelo is Retiro     ) {FrmCadastrarRetiro form = new FrmCadastrarRetiro         (Modelo, false, true, false); form.MdiParent = this.MdiParent; form.Show(); }
                    if(Modelo is Transacao  ) { FrmCadastrarTransacao form = new FrmCadastrarTransacao  (Modelo, false, true, false); form.MdiParent = this.MdiParent; form.Show(); }
                    if(Modelo is Transporte)  { FrmCadastrarTransporte form = new FrmCadastrarTransporte(Modelo, false, true, false); form.MdiParent = this.MdiParent; form.Show(); }

                }
                catch { }
            }

            if (Tipo.IsSubclassOf(typeof(Pessoa)) || Tipo == typeof(Pessoa))
            {
                try
                {
                    var Modelo = modelocrud.modelos.OfType<Pessoa>().First(i => i.Id == numero);
                    if (Modelo is Comprador) { FrmCadastrarComprador form = new FrmCadastrarComprador(Modelo, false, true, false); form.MdiParent = this.MdiParent; form.Show(); }
                    if (Modelo is Admin)     { FrmCadastrarAdmin form = new FrmCadastrarAdmin        (Modelo, false, true, false); form.MdiParent = this.MdiParent; form.Show(); }

                }
                catch { }
            }
        }


        private void FrmListagem_Load(object sender, EventArgs e)
        {
            modelocrud.condicaoTexto = 1;
            this.Size = new Size(900, 350);
            lista.Dock = DockStyle.Left;

            if (!Tipo.IsAbstract)
            {
                atualizar = false;
                botaoAtualizarLista.Enabled = atualizar;
                botaoDetalhes.Enabled = atualizar;
                botaoAtualizar.Enabled = atualizar;
                botaoDeletar.Enabled = atualizar;


                if (Tipo.IsSubclassOf(typeof(Movimentacao)))
                {
                    if (Tipo == typeof(MovimentacaoEntrada))
                    lista.DataSource = modelocrud.modelos.OfType<MovimentacaoEntrada>().OrderBy(p => p.Id).ToList();
                    if (Tipo == typeof(MovimentacaoSaida))
                    lista.DataSource = modelocrud.modelos.OfType<MovimentacaoSaida>().OrderBy(p => p.Id).ToList();
                    if (Tipo == typeof(Dizimo))
                    lista.DataSource = modelocrud.modelos.OfType<Dizimo>().OrderBy(p => p.Id).ToList();
                    if (Tipo == typeof(Dizimo     ))
                    lista.DataSource = modelocrud.modelos.OfType<Dizimo     >().OrderBy(p => p.Id).ToList();
                    if (Tipo == typeof(Oferta     ))
                    lista.DataSource = modelocrud.modelos.OfType<Oferta     >().OrderBy(p => p.Id).ToList();
                    if (Tipo == typeof(Cantina    ))
                    lista.DataSource = modelocrud.modelos.OfType<Cantina    >().OrderBy(p => p.Id).ToList();
                    if (Tipo == typeof(Bazar      ))
                    lista.DataSource = modelocrud.modelos.OfType<Bazar      >().OrderBy(p => p.Id).ToList();
                    if (Tipo == typeof(Lava_Rapido))
                    lista.DataSource = modelocrud.modelos.OfType<Lava_Rapido>().OrderBy(p => p.Id).ToList();
                    if (Tipo == typeof(Aluguel    ))
                    lista.DataSource = modelocrud.modelos.OfType<Aluguel    >().OrderBy(p => p.Id).ToList();
                    if (Tipo == typeof(Compra     ))
                    lista.DataSource = modelocrud.modelos.OfType<Compra     >().OrderBy(p => p.Id).ToList();
                    if (Tipo == typeof(Retiro     ))
                    lista.DataSource = modelocrud.modelos.OfType<Retiro     >().OrderBy(p => p.Id).ToList();
                    if (Tipo == typeof(Transacao  ))
                    lista.DataSource = modelocrud.modelos.OfType<Transacao  >().OrderBy(p => p.Id).ToList();
                    if (Tipo == typeof(Transporte ))
                    lista.DataSource = modelocrud.modelos.OfType<Transporte>().OrderBy(p => p.Id).ToList();
                }

                if (Tipo.IsSubclassOf(typeof(Pessoa)))
                {
                    if (Tipo == typeof(Admin))
                        lista.DataSource = modelocrud.modelos.OfType<Admin>().OrderBy(p => p.Id).ToList();
                    if (Tipo == typeof(Comprador))
                        lista.DataSource = modelocrud.modelos.OfType<Comprador>().OrderBy(p => p.Id).ToList();
                }
                else
            if (Tipo == typeof(Movimentacao) || Tipo == typeof(Pessoa))
                {
                    if (Tipo == typeof(Movimentacao))
                        lista.DataSource = modelocrud.modelos.OfType<Movimentacao>().OrderBy(p => p.Id).ToList();

                    if (Tipo == typeof(Pessoa))
                        lista.DataSource = modelocrud.modelos.OfType<Pessoa>().OrderBy(p => p.Id).ToList();
                }

                atualizar = true;
                botaoAtualizarLista.Enabled = atualizar;
                botaoDetalhes.Enabled = atualizar;
                botaoAtualizar.Enabled = atualizar;
                botaoDeletar.Enabled = atualizar;
            }
            else
            {
                if (Tipo == typeof(Movimentacao))
                    lista.DataSource = modelocrud.modelos.OfType<Movimentacao>().ToList();
                if (Tipo == typeof(MovimentacaoEntrada))
                    lista.DataSource = modelocrud.modelos.OfType<MovimentacaoEntrada>().ToList();
                if (Tipo == typeof(MovimentacaoSaida))
                    lista.DataSource = modelocrud.modelos.OfType<MovimentacaoSaida>().ToList();
                if (Tipo == typeof(Pessoa))
                    lista.DataSource = modelocrud.modelos.OfType<Pessoa>().ToList();
            }
        }
    }

    
}
