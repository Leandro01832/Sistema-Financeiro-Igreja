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
    public partial class FrmPadrao : Form
    {
        public FrmPadrao()
        {
            InitializeComponent();
        }
        
        private static bool executar = true;

        public static bool condicaoSistema { get; set; }

        private void FrmPadrao_Load(object sender, EventArgs e)
        {
            condicaoSistema = false;

            this.Icon = new Icon("D:\\Downloads\\favicon.ico");
        }

        public async void UltimoRegistro()
        {
            if (executar)
            {
                executar = false;

                FormProgressBar form = new FormProgressBar();
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Text = "Barra de processamento - Processando dados";
                form.Show();

                var lc = await Task.Run(() => new Admin().recuperar());

                await Task.Run(() => {

                    while (int.Parse(modelocrud.textoPorcentagem.Replace("%", "")) < 99)
                    { executar = false;  }
                });


                if (!form.IsDisposed)
                    form.Dispose();

                executar = true; 
            }
        }
        

        private void recuperarRegistrosPessoa(int v1)
        {
            var v2 = v1 + 10;
            List<modelocrud> lista = new List<modelocrud>();
            while (v1 <= v2)
            {
                if (modelocrud.modelos.FirstOrDefault(i => i.Id == v1) == null)
                {
                    var model = new Comprador(); var modelo = model.recuperar( v1);
                    var model2 = new Admin(); var modelo2 = model2.recuperar(v1);

                    if (modelo != null) modelocrud.modelos.Add(model);
                    if (modelo2 != null) modelocrud.modelos.Add(model2);
                }

                v1++;
            }
        }

        private void recuperarRegistrosMovimentacao(int v1)
        {
            var v2 = v1 + 10;
            while (v1 <= v2)
            {
                if (modelocrud.modelos.FirstOrDefault(i => i.Id == v1) == null)
                {
                    var model = new  Dizimo     (); var modelo = model.recuperar(v1);
                    var model2 = new Oferta     (); var modelo2 = model2.recuperar(v1);
                    var model3 = new Cantina    (); var modelo3 = model3.recuperar(v1);
                    var model4 = new Bazar      (); var modelo4 = model4.recuperar(v1);
                    var model5 = new Lava_Rapido(); var modelo5 = model5.recuperar(v1);
                    var model6 = new Aluguel    (); var modelo6 = model6.recuperar(v1);
                    var model7 = new Compra     (); var modelo7 = model7.recuperar(v1);
                    var model8 = new Retiro     (); var modelo8 = model8.recuperar(v1);
                    var model9 = new Transacao  (); var modelo9 = model8.recuperar(v1);
                    var model10 = new Transporte(); var modelo10 = model8.recuperar(v1);

                    if (modelo  != null) modelocrud.modelos.Add(model);
                    if (modelo2 != null) modelocrud.modelos.Add(model2);
                    if (modelo3 != null) modelocrud.modelos.Add(model3);
                    if (modelo4 != null) modelocrud.modelos.Add(model4);
                    if (modelo5 != null) modelocrud.modelos.Add(model5);
                    if (modelo6 != null) modelocrud.modelos.Add(model6);
                    if (modelo7 != null) modelocrud.modelos.Add(model7);
                    if (modelo8 != null) modelocrud.modelos.Add(model8);
                }
                v1++;
            }
        }

        private  void timer1_Tick(object sender, EventArgs e)
        {

            if (this is FrmListagem && Width < 150)
                Width = 470;
        }

        private static void verificarBoleanos()
        {
            
        }
    }
}
