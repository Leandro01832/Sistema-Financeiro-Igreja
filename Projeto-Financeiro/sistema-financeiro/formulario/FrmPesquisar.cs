using business.Classe;
using database;
using sistema_financeiro.formulario.formularioCadastrarMovimentacaoSaida;
using sistema_financeiro.formulario.formularioCadastrarMovvimentacaoEntrada;
using sistema_financeiro.formulario.formularioCadastrarPessoa;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace sistema_financeiro.formulario
{
    public partial class FrmPesquisar : Form
    {
        public FrmPesquisar(Type tipo)
        {            
            Resultado = new List<modelocrud>();

            Id = new CheckBox();
            Id.Visible = false;
            Id.Location = new Point(50, 50);
            Id.CheckedChanged += Id_CheckedChanged;
            Id.Width = 400;
            Id.Text = "Pesquisar por id";

            Nome = new CheckBox();
            Nome.Visible = false;
            Nome.Location = new Point(50, 100);
            Nome.CheckedChanged += Nome_CheckedChanged;
            Nome.Width = 400;
            Nome.Text = "Pesquisar por nome";

            Email = new CheckBox();
            Email.Visible = false;
            Email.Location = new Point(150, 50);
            Email.CheckedChanged += Email_CheckedChanged;
            Email.Width = 400;
            Email.Text = "Pesquisar por email";

           DataMovimetacao = new CheckBox();
           DataMovimetacao.Visible = false;
           DataMovimetacao.Location = new Point(150, 100);
            DataMovimetacao.CheckedChanged += DataMovimetacao_CheckedChanged;
            DataMovimetacao.Width = 400;
            DataMovimetacao.Text = "Pesquisar por data da movimentação";

           ValorMovimetacao = new CheckBox();
           ValorMovimetacao.Visible = false;
           ValorMovimetacao.Location = new Point(150, 150);
            ValorMovimetacao.CheckedChanged += ValorMovimetacao_CheckedChanged;
            ValorMovimetacao.Width = 400;
            ValorMovimetacao.Text = "Pesquisar por valor da movimentação";

           Pagou = new CheckBox();
           Pagou.Visible = false;
           Pagou.Location = new Point(250, 50);
            Pagou.CheckedChanged += Pagou_CheckedChanged;
            Pagou.Width = 400;
            Pagou.Text = "Pesquisar por status de pagamento";

           PessoaComprou = new CheckBox();
           PessoaComprou.Visible = false;
           PessoaComprou.Location = new Point(250, 100);
            PessoaComprou.CheckedChanged += PessoaComprou_CheckedChanged;
            PessoaComprou.Width = 400;
            PessoaComprou.Text = "Pesquisar por pessoa que comprou";

           DataRecebimento = new CheckBox();
           DataRecebimento.Visible = false;
           DataRecebimento.Location = new Point(250, 150);
            DataRecebimento.CheckedChanged += DataRecebimento_CheckedChanged;
            DataRecebimento.Width = 400;
            DataRecebimento.Text = "Pesquisar por data de recebimento da movimentação";

            this.Controls.Add(Nome);
            this.Controls.Add(Email);
            this.Controls.Add(DataMovimetacao);
            this.Controls.Add(ValorMovimetacao);
            this.Controls.Add(Pagou);
            this.Controls.Add(PessoaComprou);
            this.Controls.Add(DataRecebimento);
            
            InitializeComponent();
            dgdados.SelectionChanged += Dgdados_SelectionChanged;
            Tipo = tipo;
        }       

        private void Dgdados_SelectionChanged(object sender, EventArgs e)
        {
            var id = dgdados.CurrentRow.Cells["Id"];
            var value = int.Parse(id.Value.ToString());

            if (Tipo.IsAbstract)
            {
                if (Tipo == typeof(Pessoa) || Tipo.IsSubclassOf(typeof(Pessoa)))
                {
                    var Modelo = modelocrud.modelos.OfType<Pessoa>().FirstOrDefault(i => i.Id == value);
                    if (Modelo != null)
                    {
                        if(Modelo is Admin)
                        {
                            FrmCadastrarAdmin fc = new FrmCadastrarAdmin((Pessoa)Modelo
                    , false, false, true);
                            fc.MdiParent = this.MdiParent;
                            fc.Show();
                        }
                        if (Modelo is Comprador)
                        {
                            FrmCadastrarComprador fc = new FrmCadastrarComprador((Pessoa)Modelo
                    , false, false, true);
                            fc.MdiParent = this.MdiParent;
                            fc.Show();
                        }

                    }
                }

                if (Tipo == typeof(Movimentacao) || Tipo.IsSubclassOf(typeof(Movimentacao)))
                {
                    var Modelo = modelocrud.modelos.OfType<Movimentacao>().FirstOrDefault(i => i.Id == value);
                    if (Modelo != null)
                    {
                        if(Modelo is Dizimo     ) { FrmCadastrarDizimo      form = new FrmCadastrarDizimo     (Modelo, false, false, true); form.MdiParent = this.MdiParent; form.Show(); }
                        if(Modelo is Oferta     ) { FrmCadastrarOferta      form = new FrmCadastrarOferta     (Modelo, false, false, true); form.MdiParent = this.MdiParent; form.Show(); }
                        if(Modelo is Cantina    ) { FrmCadastrarCantina     form = new FrmCadastrarCantina    (Modelo, false, false, true); form.MdiParent = this.MdiParent; form.Show(); }
                        if(Modelo is Bazar      ) { FrmCadastrarBazar       form = new FrmCadastrarBazar      (Modelo, false, false, true); form.MdiParent = this.MdiParent; form.Show(); }
                        if(Modelo is Lava_Rapido) { FrmCadastrarLavaRapido  form = new FrmCadastrarLavaRapido (Modelo, false, false, true); form.MdiParent = this.MdiParent; form.Show(); }
                        if(Modelo is Aluguel    ) { FrmCadastrarAluguel     form = new FrmCadastrarAluguel    (Modelo, false, false, true); form.MdiParent = this.MdiParent; form.Show(); }
                        if(Modelo is Compra     ) { FrmCadastrarCompra      form = new FrmCadastrarCompra     (Modelo, false, false, true); form.MdiParent = this.MdiParent; form.Show(); }
                        if(Modelo is Retiro     ) { FrmCadastrarRetiro      form = new FrmCadastrarRetiro     (Modelo, false, false, true); form.MdiParent = this.MdiParent; form.Show(); }
                        if(Modelo is Transacao  ) { FrmCadastrarTransacao   form = new FrmCadastrarTransacao  (Modelo, false, false, true); form.MdiParent = this.MdiParent; form.Show(); }
                        if(Modelo is Transporte ) { FrmCadastrarTransporte  form = new FrmCadastrarTransporte (Modelo, false, false, true); form.MdiParent = this.MdiParent; form.Show(); }
                        
                    }
                }
            }
        }

        private CheckBox Id;
        private CheckBox Nome;
        private CheckBox Email;
        private CheckBox DataMovimetacao;
        private CheckBox ValorMovimetacao;
        private CheckBox Pagou;
        private CheckBox PessoaComprou;
        private CheckBox DataRecebimento;

        private List<modelocrud> Resultado;

        public Type Tipo { get; }

        private void FrmPesquisar_Load(object sender, EventArgs e)
        {
            
            dgdados.Font = new Font("Arial", 18);

            if (Tipo.IsAbstract)
            {
                if(Tipo == typeof(Pessoa))
                {
                Nome.Visible = true;
                Email.Visible = true;
                    dgdados.Columns.Clear();
                    Resultado = modelocrud.modelos.OfType<Pessoa>().Cast<modelocrud>().ToList();
                }
                if(Tipo == typeof(Movimentacao))
                {
                DataMovimetacao.Visible = true;
                ValorMovimetacao .Visible = true;
                Pagou            .Visible = true;
                    dgdados.Columns.Clear();
                    Resultado = modelocrud.modelos.OfType<Movimentacao>().Cast<modelocrud>().ToList();

                }
                if(Tipo == typeof(MovimentacaoEntrada))
                {
                PessoaComprou.Visible = true;
                DataRecebimento.Visible = true;
                    dgdados.Columns.Clear();
                    Resultado = modelocrud.modelos.OfType<MovimentacaoEntrada>().Cast<modelocrud>().ToList();
                }
                if (Tipo == typeof(MovimentacaoSaida))
                {
                    dgdados.Columns.Clear();
                    Resultado = modelocrud.modelos.OfType<MovimentacaoSaida>().Cast<modelocrud>().ToList();
                }
            }
            else
            {
                if (Tipo.IsSubclassOf(typeof(Movimentacao)))
                {
                    DataMovimetacao.Visible = true;
                    ValorMovimetacao.Visible = true;
                    Pagou.Visible = true;
                    if (Tipo.IsSubclassOf(typeof(MovimentacaoEntrada)))
                    {
                        PessoaComprou.Visible = true;
                        DataRecebimento.Visible = true;
                    }
                    dgdados.Columns.Clear();
                }
                else if (Tipo.IsSubclassOf(typeof(Pessoa)))
                {
                    Nome.Visible = true;
                    Email.Visible = true;
                    dgdados.Columns.Clear();
                }
                if(Tipo == typeof(Dizimo     )) Resultado = modelocrud.modelos.OfType<Dizimo     >().Cast<modelocrud>().ToList();
                if(Tipo == typeof(Oferta     )) Resultado = modelocrud.modelos.OfType<Oferta     >().Cast<modelocrud>().ToList();
                if(Tipo == typeof(Cantina    )) Resultado = modelocrud.modelos.OfType<Cantina    >().Cast<modelocrud>().ToList();
                if(Tipo == typeof(Bazar      )) Resultado = modelocrud.modelos.OfType<Bazar      >().Cast<modelocrud>().ToList();
                if(Tipo == typeof(Lava_Rapido)) Resultado = modelocrud.modelos.OfType<Lava_Rapido>().Cast<modelocrud>().ToList();
                if(Tipo == typeof(Aluguel    )) Resultado = modelocrud.modelos.OfType<Aluguel    >().Cast<modelocrud>().ToList();
                if(Tipo == typeof(Compra     )) Resultado = modelocrud.modelos.OfType<Compra     >().Cast<modelocrud>().ToList();
                if(Tipo == typeof(Retiro     )) Resultado = modelocrud.modelos.OfType<Retiro     >().Cast<modelocrud>().ToList();
                if(Tipo == typeof(Transacao  )) Resultado = modelocrud.modelos.OfType<Transacao  >().Cast<modelocrud>().ToList();
                if(Tipo == typeof(Transporte))  Resultado = modelocrud.modelos.OfType<Transporte>().Cast<modelocrud>().ToList();

                if (Tipo == typeof(Comprador)) Resultado = modelocrud.modelos.OfType<Comprador>().Cast<modelocrud>().ToList();
                if (Tipo == typeof(Admin)) Resultado = modelocrud.modelos.OfType<Admin>().Cast<modelocrud>().ToList();
            }

            ModificaDataGridView(Resultado);
        }

        private void ModificaDataGridView(List<modelocrud> resultado)
        {
            if (Tipo.IsAbstract)
            {
                if (Tipo == typeof(Pessoa))
                    dgdados.DataSource = resultado.OfType<Pessoa>().ToList();

                if (Tipo == typeof(Movimentacao))
                    dgdados.DataSource = resultado.OfType<Movimentacao>().ToList();

                if (Tipo == typeof(MovimentacaoEntrada))
                    dgdados.DataSource = resultado.OfType<MovimentacaoEntrada>().ToList();

                if (Tipo == typeof(MovimentacaoSaida))
                    dgdados.DataSource = resultado.OfType<MovimentacaoSaida>().ToList();
            }
            else
            {
                if (Tipo.IsSubclassOf(typeof(Movimentacao)))
                {
                    if (Tipo == typeof(Dizimo     )) dgdados.DataSource = resultado.OfType<Dizimo     >().ToList();
                    if (Tipo == typeof(Oferta     )) dgdados.DataSource = resultado.OfType<Oferta     >().ToList();
                    if (Tipo == typeof(Cantina    )) dgdados.DataSource = resultado.OfType<Cantina    >().ToList();
                    if (Tipo == typeof(Bazar      )) dgdados.DataSource = resultado.OfType<Bazar      >().ToList();
                    if (Tipo == typeof(Lava_Rapido)) dgdados.DataSource = resultado.OfType<Lava_Rapido>().ToList();
                    if (Tipo == typeof(Aluguel    )) dgdados.DataSource = resultado.OfType<Aluguel    >().ToList();
                    if (Tipo == typeof(Compra     )) dgdados.DataSource = resultado.OfType<Compra     >().ToList();
                    if (Tipo == typeof(Retiro     )) dgdados.DataSource = resultado.OfType<Retiro     >().ToList();
                    if (Tipo == typeof(Transacao  )) dgdados.DataSource = resultado.OfType<Transacao  >().ToList();
                    if (Tipo == typeof(Transporte )) dgdados.DataSource = resultado.OfType<Transporte>().ToList();
                }
                else if (Tipo.IsSubclassOf(typeof(Pessoa)))
                {
                    if (Tipo == typeof(Comprador)) dgdados.DataSource = resultado.OfType<Comprador>().ToList();
                    if (Tipo == typeof(Admin)) dgdados.DataSource = resultado.OfType<Admin>().ToList();
                }
            }
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            ModificaDataGridView(Resultado);
            Resultado.Clear();

            if (Tipo == typeof(Dizimo)) Resultado = modelocrud.modelos.OfType<Dizimo>().Cast<modelocrud>().ToList();
            if (Tipo == typeof(Oferta)) Resultado = modelocrud.modelos.OfType<Oferta>().Cast<modelocrud>().ToList();
            if (Tipo == typeof(Cantina)) Resultado = modelocrud.modelos.OfType<Cantina>().Cast<modelocrud>().ToList();
            if (Tipo == typeof(Bazar)) Resultado = modelocrud.modelos.OfType<Bazar>().Cast<modelocrud>().ToList();
            if (Tipo == typeof(Lava_Rapido)) Resultado = modelocrud.modelos.OfType<Lava_Rapido>().Cast<modelocrud>().ToList();
            if (Tipo == typeof(Aluguel)) Resultado = modelocrud.modelos.OfType<Aluguel>().Cast<modelocrud>().ToList();
            if (Tipo == typeof(Compra)) Resultado = modelocrud.modelos.OfType<Compra>().Cast<modelocrud>().ToList();
            if (Tipo == typeof(Retiro)) Resultado = modelocrud.modelos.OfType<Retiro>().Cast<modelocrud>().ToList();
            if (Tipo == typeof(Transacao)) Resultado = modelocrud.modelos.OfType<Transacao>().Cast<modelocrud>().ToList();
            if (Tipo == typeof(Transporte)) Resultado = modelocrud.modelos.OfType<Transporte>().Cast<modelocrud>().ToList();

            if (Tipo == typeof(Comprador)) Resultado = modelocrud.modelos.OfType<Comprador>().Cast<modelocrud>().ToList();
            if (Tipo == typeof(Admin)) Resultado = modelocrud.modelos.OfType<Admin>().Cast<modelocrud>().ToList();
        }

        private void btn_todos_Click(object sender, EventArgs e)
        {
            Nome              .Checked =  false;
            Email             .Checked =  false;
            DataMovimetacao   .Checked =  false;
            ValorMovimetacao  .Checked =  false;
            Pagou             .Checked =  false;
            PessoaComprou     .Checked =  false;
            DataRecebimento   .Checked =  false;

            Resultado.Clear();

            if (Tipo == typeof(Dizimo)) Resultado = modelocrud.modelos.OfType<Dizimo>().Cast<modelocrud>().ToList();
            if (Tipo == typeof(Oferta)) Resultado = modelocrud.modelos.OfType<Oferta>().Cast<modelocrud>().ToList();
            if (Tipo == typeof(Cantina)) Resultado = modelocrud.modelos.OfType<Cantina>().Cast<modelocrud>().ToList();
            if (Tipo == typeof(Bazar)) Resultado = modelocrud.modelos.OfType<Bazar>().Cast<modelocrud>().ToList();
            if (Tipo == typeof(Lava_Rapido)) Resultado = modelocrud.modelos.OfType<Lava_Rapido>().Cast<modelocrud>().ToList();
            if (Tipo == typeof(Aluguel)) Resultado = modelocrud.modelos.OfType<Aluguel>().Cast<modelocrud>().ToList();
            if (Tipo == typeof(Compra)) Resultado = modelocrud.modelos.OfType<Compra>().Cast<modelocrud>().ToList();
            if (Tipo == typeof(Retiro)) Resultado = modelocrud.modelos.OfType<Retiro>().Cast<modelocrud>().ToList();
            if (Tipo == typeof(Transacao)) Resultado = modelocrud.modelos.OfType<Transacao>().Cast<modelocrud>().ToList();
            if (Tipo == typeof(Transporte)) Resultado = modelocrud.modelos.OfType<Transporte>().Cast<modelocrud>().ToList();

            if (Tipo == typeof(Comprador)) Resultado = modelocrud.modelos.OfType<Comprador>().Cast<modelocrud>().ToList();
            if (Tipo == typeof(Admin)) Resultado = modelocrud.modelos.OfType<Admin>().Cast<modelocrud>().ToList();
        }

        private void Id_CheckedChanged(object sender, EventArgs e)
        {
            if (Id.Checked)
            {
                MessageBox.Show("Digite dois numeros de identificação e o resultado da pesquisa será entre esses dois valores.");
                txt_pesquisa_numero1.Enabled = true;
                txt_pesquisa_numero2.Enabled = true;
                txt_pesquisa_numero1.Focus();
            }
            else
            {
                txt_pesquisa_numero1.Text = "";
                txt_pesquisa_numero2.Text = "";
                txt_pesquisa_numero1.Enabled = false;
                txt_pesquisa_numero2.Enabled = false;
            }
        }

        private void DataRecebimento_CheckedChanged(object sender, EventArgs e)
        {
            if (DataRecebimento.Checked)
            {
                MessageBox.Show("Digite dois valores e o resultado da pesquisa será entre esses dois valores.");
                mask_data_valor1.Enabled = true;
                mask_data_valor2.Enabled = true;
            }
            else
            {
                mask_data_valor1.Enabled = false;
                mask_data_valor2.Enabled = false;
                mask_data_valor1.Text = "";
                mask_data_valor2.Text = "";
            }
        }

        private void PessoaComprou_CheckedChanged(object sender, EventArgs e)
        {
            if (PessoaComprou.Checked)
            {
                MessageBox.Show("Digite dois numeros de identificação e o resultado da pesquisa será entre esses dois valores.");
                txt_pesquisa_numero1.Enabled = true;
                txt_pesquisa_numero2.Enabled = true;
                txt_pesquisa_numero1.Focus();
            }
            else
            {
                txt_pesquisa_numero1.Text = "";
                txt_pesquisa_numero2.Text = "";
                txt_pesquisa_numero1.Enabled = false;
                txt_pesquisa_numero2.Enabled = false;
            }
        }

        private void Pagou_CheckedChanged(object sender, EventArgs e)
        {
            if (Pagou.Checked)
            {
                MessageBox.Show("Informe se teve pagamento ou não.");
            }
            else
            {
                radioNaoPagou.Enabled = false;
                radioPagou.Enabled = false;
            }
        }

        private void ValorMovimetacao_CheckedChanged(object sender, EventArgs e)
        {
            if (ValorMovimetacao.Checked)
            {
                MessageBox.Show("Digite dois valores em dinheiro e o resultado da pesquisa será entre esses dois valores.");
                txt_pesquisa_numero1.Enabled = true;
                txt_pesquisa_numero2.Enabled = true;
                txt_pesquisa_numero1.Focus();
            }
            else
            {
                txt_pesquisa_numero1.Text = "";
                txt_pesquisa_numero2.Text = "";
                txt_pesquisa_numero1.Enabled = false;
                txt_pesquisa_numero2.Enabled = false;
            }
        }

        private void DataMovimetacao_CheckedChanged(object sender, EventArgs e)
        {
            if (DataMovimetacao.Checked)
            {
                MessageBox.Show("Digite dois valores e o resultado da pesquisa será entre esses dois valores.");
                mask_data_valor1.Enabled = true;
                mask_data_valor2.Enabled = true;
            }
            else
            {
                mask_data_valor1.Enabled = false;
                mask_data_valor2.Enabled = false;
                mask_data_valor1.Text = "";
                mask_data_valor2.Text = "";
            }
        }

        private void Email_CheckedChanged(object sender, EventArgs e)
        {
            if (Email.Checked)
            {
                MessageBox.Show("Digite um email parecido com o que lembra para ser feito a pesquisa.");
                txt_pesquisa_texto.Enabled = true;
                txt_pesquisa_texto.Focus();
            }
            else
            {
                txt_pesquisa_texto.Enabled = false;
                txt_pesquisa_texto.Text = "";
            }
        }

        private void Nome_CheckedChanged(object sender, EventArgs e)
        {
            if (Nome.Checked)
            {
                MessageBox.Show("Digite um nome parecido com o que lembra para ser feito pesquisa.");
                txt_pesquisa_texto.Enabled = true;
                txt_pesquisa_texto.Focus();
            }
            else
            {
                txt_pesquisa_texto.Enabled = false;
                txt_pesquisa_texto.Text = "";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (Nome.Checked)
            {
                Resultado = Resultado[0].PesquisarPorTexto(Resultado, txt_pesquisa_texto.Text, "Nome");
            }

            if (Email.Checked)
            {
                Resultado = Resultado[0].PesquisarPorTexto(Resultado, txt_pesquisa_texto.Text, "Email");
            }

            if (DataMovimetacao.Checked)
            {
                try
                {
                    var v1 = Convert.ToDateTime(mask_data_valor1.Text);
                    var v2 = Convert.ToDateTime(mask_data_valor2.Text);
                    Resultado = Resultado[0].PesquisarPorData(Resultado, v1, v2, "Data");
                }
                catch
                {
                    MessageBox.Show("Digite dois valores e o resultado da pesquisa será entre esses dois valores.");
                    return;
                }
            }

            if (DataRecebimento.Checked)
            {
                try
                {
                    var v1 = Convert.ToDateTime(mask_data_valor1.Text);
                    var v2 = Convert.ToDateTime(mask_data_valor2.Text);
                    Resultado = Resultado[0].PesquisarPorData(Resultado, v1, v2, "DataRecebimento");
                }
                catch
                {
                    MessageBox.Show("Digite dois valores e o resultado da pesquisa será entre esses dois valores.");
                    return;
                }
            }

            if (ValorMovimetacao.Checked)
            {
                try
                {
                    var v1 = double.Parse(txtMoedaValor1.Text);
                    var v2 = double.Parse(txtMoedaValor2.Text);
                    Resultado = Resultado[0].PesquisarPorMoeda(Resultado, double.Parse(v1.ToString("F2")), double.Parse(v2.ToString("F2")), "Valor");
                }
                catch
                {
                    MessageBox.Show("Digite dois valores e o resultado da pesquisa será entre esses dois valores.");
                    return;
                }
            }


            if (Id.Checked)
            {
                try
                {
                    var v1 = int.Parse(txt_pesquisa_numero1.Text);
                    var v2 = int.Parse(txt_pesquisa_numero2.Text);
                    Resultado = Resultado[0].PesquisarPorNumero(Resultado, v1, v2, "Id");
                }
                catch
                {
                    MessageBox.Show("Digite dois valores e o resultado da pesquisa será entre esses dois valores.");
                    return;
                }
            }
        }
    }
}
