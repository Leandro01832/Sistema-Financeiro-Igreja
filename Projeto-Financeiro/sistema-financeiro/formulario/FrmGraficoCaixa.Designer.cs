namespace sistema_financeiro.formulario
{
    partial class FrmGraficoCaixa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendCellColumn legendCellColumn13 = new System.Windows.Forms.DataVisualization.Charting.LegendCellColumn();
            System.Windows.Forms.DataVisualization.Charting.LegendCellColumn legendCellColumn14 = new System.Windows.Forms.DataVisualization.Charting.LegendCellColumn();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem31 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem32 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem33 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem34 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem35 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendCellColumn legendCellColumn15 = new System.Windows.Forms.DataVisualization.Charting.LegendCellColumn();
            System.Windows.Forms.DataVisualization.Charting.LegendCellColumn legendCellColumn16 = new System.Windows.Forms.DataVisualization.Charting.LegendCellColumn();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem36 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem37 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem38 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem39 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem40 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.numericGrau = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.checkEnable3D = new System.Windows.Forms.CheckBox();
            this.dateEscolhida = new System.Windows.Forms.DateTimePicker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.numericGrau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericGrau
            // 
            this.numericGrau.Location = new System.Drawing.Point(464, 3);
            this.numericGrau.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericGrau.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.numericGrau.Name = "numericGrau";
            this.numericGrau.Size = new System.Drawing.Size(82, 22);
            this.numericGrau.TabIndex = 10;
            this.numericGrau.ValueChanged += new System.EventHandler(this.numericGrau_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Grau";
            // 
            // checkEnable3D
            // 
            this.checkEnable3D.AutoSize = true;
            this.checkEnable3D.Location = new System.Drawing.Point(304, 0);
            this.checkEnable3D.Name = "checkEnable3D";
            this.checkEnable3D.Size = new System.Drawing.Size(88, 21);
            this.checkEnable3D.TabIndex = 8;
            this.checkEnable3D.Text = "Ativar 3D";
            this.checkEnable3D.UseVisualStyleBackColor = true;
            this.checkEnable3D.CheckedChanged += new System.EventHandler(this.checkEnable3D_CheckedChanged);
            // 
            // dateEscolhida
            // 
            this.dateEscolhida.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEscolhida.Location = new System.Drawing.Point(0, 0);
            this.dateEscolhida.Name = "dateEscolhida";
            this.dateEscolhida.Size = new System.Drawing.Size(287, 22);
            this.dateEscolhida.TabIndex = 7;
            this.dateEscolhida.ValueChanged += new System.EventHandler(this.dateEscolhida_ValueChanged);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Gray;
            this.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.FrameTitle1;
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legendCellColumn13.BackColor = System.Drawing.Color.DarkSalmon;
            legendCellColumn13.ColumnType = System.Windows.Forms.DataVisualization.Charting.LegendCellColumnType.SeriesSymbol;
            legendCellColumn13.ForeColor = System.Drawing.Color.Transparent;
            legendCellColumn13.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            legendCellColumn13.HeaderForeColor = System.Drawing.Color.Maroon;
            legendCellColumn13.HeaderText = "Cor";
            legendCellColumn13.Name = "Column1";
            legendCellColumn13.Text = "#leo2";
            legendCellColumn14.BackColor = System.Drawing.Color.DarkSalmon;
            legendCellColumn14.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            legendCellColumn14.HeaderForeColor = System.Drawing.Color.Maroon;
            legendCellColumn14.HeaderText = "Classe";
            legendCellColumn14.Name = "Column2";
            legend7.CellColumns.Add(legendCellColumn13);
            legend7.CellColumns.Add(legendCellColumn14);
            legendItem31.Color = System.Drawing.Color.Red;
            legendItem31.Name = "Bazar";
            legendItem32.Color = System.Drawing.Color.Yellow;
            legendItem32.Name = "Lava-Rápido";
            legendItem33.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            legendItem33.Name = "Dízimo";
            legendItem34.Color = System.Drawing.Color.Navy;
            legendItem34.Name = "Oferta";
            legendItem35.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            legendItem35.Name = "Cantina";
            legend7.CustomItems.Add(legendItem31);
            legend7.CustomItems.Add(legendItem32);
            legend7.CustomItems.Add(legendItem33);
            legend7.CustomItems.Add(legendItem34);
            legend7.CustomItems.Add(legendItem35);
            legend7.DockedToChartArea = "ChartArea1";
            legend7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend7.IsDockedInsideChartArea = false;
            legend7.IsEquallySpacedItems = true;
            legend7.IsTextAutoFit = false;
            legend7.Name = "Legend1";
            legend7.Title = "Movimentação de entrada";
            legend7.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend7.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend8.Alignment = System.Drawing.StringAlignment.Far;
            legendCellColumn15.BackColor = System.Drawing.Color.DarkSalmon;
            legendCellColumn15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legendCellColumn15.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            legendCellColumn15.HeaderForeColor = System.Drawing.Color.Maroon;
            legendCellColumn15.HeaderText = "Cor";
            legendCellColumn15.Name = "Column1";
            legendCellColumn15.Text = "#leo";
            legendCellColumn16.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            legendCellColumn16.BackColor = System.Drawing.Color.DarkSalmon;
            legendCellColumn16.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            legendCellColumn16.HeaderForeColor = System.Drawing.Color.Maroon;
            legendCellColumn16.HeaderText = "Classe";
            legendCellColumn16.Name = "Column2";
            legend8.CellColumns.Add(legendCellColumn15);
            legend8.CellColumns.Add(legendCellColumn16);
            legendItem36.Color = System.Drawing.Color.Red;
            legendItem36.Name = "Aluguel";
            legendItem37.Color = System.Drawing.Color.Yellow;
            legendItem37.Name = "Transação";
            legendItem38.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            legendItem38.Name = "Transporte";
            legendItem39.Color = System.Drawing.Color.Navy;
            legendItem39.Name = "Compra";
            legendItem40.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            legendItem40.Name = "Retiro";
            legend8.CustomItems.Add(legendItem36);
            legend8.CustomItems.Add(legendItem37);
            legend8.CustomItems.Add(legendItem38);
            legend8.CustomItems.Add(legendItem39);
            legend8.CustomItems.Add(legendItem40);
            legend8.DockedToChartArea = "ChartArea1";
            legend8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend8.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.DashLine;
            legend8.HeaderSeparatorColor = System.Drawing.Color.Silver;
            legend8.IsDockedInsideChartArea = false;
            legend8.IsEquallySpacedItems = true;
            legend8.IsTextAutoFit = false;
            legend8.Name = "Legend2";
            legend8.Title = "Movimentação de saída";
            legend8.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            this.chart1.Legends.Add(legend7);
            this.chart1.Legends.Add(legend8);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series7.ChartArea = "ChartArea1";
            series7.IsVisibleInLegend = false;
            series7.Legend = "Legend1";
            series7.LegendText = "...";
            series7.Name = "Series1";
            series7.XValueMember = "Data";
            series7.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series7.YValueMembers = "Valor";
            series7.YValuesPerPoint = 3;
            series7.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series8.ChartArea = "ChartArea1";
            series8.IsVisibleInLegend = false;
            series8.Legend = "Legend2";
            series8.LegendText = "...";
            series8.Name = "Series2";
            series8.XValueMember = "Data";
            series8.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series8.YValueMembers = "Valor";
            series8.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(1491, 712);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            title4.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.Name = "Title1";
            title4.Text = "Gráfico de movimentação";
            this.chart1.Titles.Add(title4);
            // 
            // FrmGraficoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 712);
            this.Controls.Add(this.numericGrau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkEnable3D);
            this.Controls.Add(this.dateEscolhida);
            this.Controls.Add(this.chart1);
            this.Name = "FrmGraficoCaixa";
            this.Text = "FrmGraficoCaixa";
            this.Load += new System.EventHandler(this.FrmGraficoCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericGrau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericGrau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkEnable3D;
        private System.Windows.Forms.DateTimePicker dateEscolhida;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}