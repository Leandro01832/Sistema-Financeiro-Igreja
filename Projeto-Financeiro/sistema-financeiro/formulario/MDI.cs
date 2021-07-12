using business.Classe;
using database;
using sistema_financeiro.formulario.formularioCadastrarMovimentacaoSaida;
using sistema_financeiro.formulario.formularioCadastrarMovvimentacaoEntrada;
using sistema_financeiro.formulario.formularioCadastrarPessoa;
using System;
using System.Windows.Forms;

namespace sistema_financeiro.formulario
{
    public partial class MDI : Form
    {
        private int childFormNumber = 0;

        public MDI()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Janela " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastrarAdmin form = new FrmCadastrarAdmin(new Admin(), false, false, false);
            form.MdiParent = this;
            form.Show();
        }

        private void compradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastrarComprador form = new FrmCadastrarComprador(new Comprador(), false, false, false);
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            FrmCadastrarDizimo form = new FrmCadastrarDizimo(new Dizimo(), false, false, false);
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            FrmCadastrarCantina form = new FrmCadastrarCantina(new Cantina(), false, false, false);
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            FrmCadastrarOferta form = new FrmCadastrarOferta(new Oferta(), false, false, false);
            form.MdiParent = this;
            form.Show();
        }

        private void bazarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCadastrarBazar form = new FrmCadastrarBazar(new Bazar(), false, false, false);
            form.MdiParent = this;
            form.Show();
        }

        private void lavaRapidoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCadastrarLavaRapido form = new FrmCadastrarLavaRapido(new Lava_Rapido(), false, false, false);
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            FrmCadastrarCompra form = new FrmCadastrarCompra(new Compra(), false, false, false);
            form.MdiParent = this;
            form.Show();

        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            FrmCadastrarTransporte form = new FrmCadastrarTransporte(new Transporte(), false, false, false);
            form.MdiParent = this;
            form.Show();

        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            FrmCadastrarTransacao form = new FrmCadastrarTransacao(new Transacao(), false, false, false);
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            FrmCadastrarRetiro form = new FrmCadastrarRetiro(new Retiro(), false, false, false);
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            FrmCadastrarAluguel form = new FrmCadastrarAluguel(new Aluguel(), false, false, false);
            form.MdiParent = this;
            form.Show();
        }

        private void fileMenu_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MDI_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmListagem lista = new FrmListagem(typeof(Pessoa));
            lista.MdiParent = this;
            lista.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmListagem lista = new FrmListagem(typeof(Admin));
            lista.MdiParent = this;
            lista.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmListagem lista = new FrmListagem(typeof(Comprador));
            lista.MdiParent = this;
            lista.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FrmListagem lista = new FrmListagem(typeof(Movimentacao));
            lista.MdiParent = this;
            lista.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            FrmListagem lista = new FrmListagem(typeof(MovimentacaoEntrada));
            lista.MdiParent = this;
            lista.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            FrmListagem lista = new FrmListagem(typeof(MovimentacaoSaida));
            lista.MdiParent = this;
            lista.Show();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListagem lista = new FrmListagem(typeof(Compra));
            lista.MdiParent = this;
            lista.Show();
        }

        private void transporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListagem lista = new FrmListagem(typeof(Transporte));
            lista.MdiParent = this;
            lista.Show();
        }

        private void transaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListagem lista = new FrmListagem(typeof(Transacao));
            lista.MdiParent = this;
            lista.Show();
        }

        private void retiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListagem lista = new FrmListagem(typeof(Retiro));
            lista.MdiParent = this;
            lista.Show();
        }

        private void aluguelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListagem lista = new FrmListagem(typeof(Aluguel));
            lista.MdiParent = this;
            lista.Show();
        }

        private void dizimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListagem lista = new FrmListagem(typeof(Dizimo));
            lista.MdiParent = this;
            lista.Show();
        }

        private void cantinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListagem lista = new FrmListagem(typeof(Cantina));
            lista.MdiParent = this;
            lista.Show();
        }

        private void ofertaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListagem lista = new FrmListagem(typeof(Oferta));
            lista.MdiParent = this;
            lista.Show();
        }

        private void bazarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListagem lista = new FrmListagem(typeof(Bazar));
            lista.MdiParent = this;
            lista.Show();
        }

        private void lavaRapidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListagem lista = new FrmListagem(typeof(Lava_Rapido));
            lista.MdiParent = this;
            lista.Show();
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            ImprimirRelatorio ir = new ImprimirRelatorio(modelocrud.modelos);
            ir.imprimir(typeof(Pessoa));
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            ImprimirRelatorio ir = new ImprimirRelatorio(modelocrud.modelos);
            ir.imprimir(typeof(Admin));
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            ImprimirRelatorio ir = new ImprimirRelatorio(modelocrud.modelos);
            ir.imprimir(typeof(Comprador));
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            ImprimirRelatorio ir = new ImprimirRelatorio(modelocrud.modelos);
            ir.imprimir(typeof(Movimentacao));
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            ImprimirRelatorio ir = new ImprimirRelatorio(modelocrud.modelos);
            ir.imprimir(typeof(MovimentacaoEntrada));
        }

        private void toolStripMenuItem26_Click(object sender, EventArgs e)
        {
            ImprimirRelatorio ir = new ImprimirRelatorio(modelocrud.modelos);
            ir.imprimir(typeof(MovimentacaoSaida));
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            ImprimirRelatorio ir = new ImprimirRelatorio(modelocrud.modelos);
            ir.imprimir(typeof(Dizimo));
        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            ImprimirRelatorio ir = new ImprimirRelatorio(modelocrud.modelos);
            ir.imprimir(typeof(Cantina));
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            ImprimirRelatorio ir = new ImprimirRelatorio(modelocrud.modelos);
            ir.imprimir(typeof(Oferta));
        }

        private void toolStripMenuItem24_Click(object sender, EventArgs e)
        {
            ImprimirRelatorio ir = new ImprimirRelatorio(modelocrud.modelos);
            ir.imprimir(typeof(Bazar));
        }

        private void toolStripMenuItem25_Click(object sender, EventArgs e)
        {
            ImprimirRelatorio ir = new ImprimirRelatorio(modelocrud.modelos);
            ir.imprimir(typeof(Lava_Rapido));
        }

        private void toolStripMenuItem27_Click(object sender, EventArgs e)
        {
            ImprimirRelatorio ir = new ImprimirRelatorio(modelocrud.modelos);
            ir.imprimir(typeof(Compra));
        }

        private void toolStripMenuItem28_Click(object sender, EventArgs e)
        {
            ImprimirRelatorio ir = new ImprimirRelatorio(modelocrud.modelos);
            ir.imprimir(typeof(Transporte));
        }

        private void toolStripMenuItem29_Click(object sender, EventArgs e)
        {
            ImprimirRelatorio ir = new ImprimirRelatorio(modelocrud.modelos);
            ir.imprimir(typeof(Transacao));
        }

        private void toolStripMenuItem30_Click(object sender, EventArgs e)
        {
            ImprimirRelatorio ir = new ImprimirRelatorio(modelocrud.modelos);
            ir.imprimir(typeof(Retiro));
        }

        private void toolStripMenuItem31_Click(object sender, EventArgs e)
        {
            ImprimirRelatorio ir = new ImprimirRelatorio(modelocrud.modelos);
            ir.imprimir(typeof(Aluguel));
        }

        private void toolStripMenuItem32_Click(object sender, EventArgs e)
        {
            FrmPesquisar form = new FrmPesquisar(typeof(Pessoa));
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripMenuItem33_Click(object sender, EventArgs e)
        {
            FrmPesquisar form = new FrmPesquisar(typeof(Admin));
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripMenuItem34_Click(object sender, EventArgs e)
        {
            FrmPesquisar form = new FrmPesquisar(typeof(Comprador));
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripMenuItem36_Click(object sender, EventArgs e)
        {
            FrmPesquisar form = new FrmPesquisar(typeof(MovimentacaoEntrada));
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripMenuItem42_Click(object sender, EventArgs e)
        {
            FrmPesquisar form = new FrmPesquisar(typeof(MovimentacaoSaida));
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripMenuItem35_Click(object sender, EventArgs e)
        {
            FrmPesquisar form = new FrmPesquisar(typeof(Movimentacao));
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripMenuItem37_Click(object sender, EventArgs e)
        {
            FrmPesquisar form = new FrmPesquisar(typeof(Dizimo));
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripMenuItem38_Click(object sender, EventArgs e)
        {
            FrmPesquisar form = new FrmPesquisar(typeof(Cantina));
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripMenuItem39_Click(object sender, EventArgs e)
        {
            FrmPesquisar form = new FrmPesquisar(typeof(Oferta));
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripMenuItem40_Click(object sender, EventArgs e)
        {
            FrmPesquisar form = new FrmPesquisar(typeof(Bazar));
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripMenuItem41_Click(object sender, EventArgs e)
        {
            FrmPesquisar form = new FrmPesquisar(typeof(Lava_Rapido));
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripMenuItem43_Click(object sender, EventArgs e)
        {
            FrmPesquisar form = new FrmPesquisar(typeof(Compra));
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripMenuItem44_Click(object sender, EventArgs e)
        {
            FrmPesquisar form = new FrmPesquisar(typeof(Transporte));
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripMenuItem45_Click(object sender, EventArgs e)
        {
            FrmPesquisar form = new FrmPesquisar(typeof(Transacao));
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripMenuItem46_Click(object sender, EventArgs e)
        {
            FrmPesquisar form = new FrmPesquisar(typeof(Retiro));
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripMenuItem47_Click(object sender, EventArgs e)
        {
            FrmPesquisar form = new FrmPesquisar(typeof(Aluguel));
            form.MdiParent = this;
            form.Show();
        }

        private void graficosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void gráficoDeMovimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGrafico form = new FrmGrafico();
            form.MdiParent = this;
            form.Show();
        }

        private void gráficoCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGraficoCaixa form = new FrmGraficoCaixa();
            form.MdiParent = this;
            form.Show();
        }
    }
}
