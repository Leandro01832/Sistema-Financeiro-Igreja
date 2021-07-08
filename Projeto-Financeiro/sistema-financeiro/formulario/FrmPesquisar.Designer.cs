namespace sistema_financeiro.formulario
{
    partial class FrmPesquisar
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pesquisa_texto = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.mask_data_valor2 = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.mask_data_valor1 = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.mask_horario_valor2 = new System.Windows.Forms.MaskedTextBox();
            this.mask_horario_valor1 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_pesquisa_numero2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_pesquisa_numero1 = new System.Windows.Forms.TextBox();
            this.btn_todos = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.dgdados = new System.Windows.Forms.DataGridView();
            this.radioPagou = new System.Windows.Forms.RadioButton();
            this.radioNaoPagou = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMoedaValor2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMoedaValor1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgdados)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1343, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 314;
            this.label2.Text = "Pesquisar por texto";
            // 
            // txt_pesquisa_texto
            // 
            this.txt_pesquisa_texto.Enabled = false;
            this.txt_pesquisa_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pesquisa_texto.Location = new System.Drawing.Point(1511, 157);
            this.txt_pesquisa_texto.Name = "txt_pesquisa_texto";
            this.txt_pesquisa_texto.Size = new System.Drawing.Size(245, 28);
            this.txt_pesquisa_texto.TabIndex = 313;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1642, 378);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 46);
            this.btnAdd.TabIndex = 312;
            this.btnAdd.Text = "Adicionar Restrição";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // mask_data_valor2
            // 
            this.mask_data_valor2.BeepOnError = true;
            this.mask_data_valor2.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mask_data_valor2.Enabled = false;
            this.mask_data_valor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mask_data_valor2.Location = new System.Drawing.Point(1655, 308);
            this.mask_data_valor2.Margin = new System.Windows.Forms.Padding(4);
            this.mask_data_valor2.Mask = "00/00/0000";
            this.mask_data_valor2.Name = "mask_data_valor2";
            this.mask_data_valor2.RejectInputOnFirstFailure = true;
            this.mask_data_valor2.Size = new System.Drawing.Size(101, 29);
            this.mask_data_valor2.TabIndex = 311;
            this.mask_data_valor2.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1619, 317);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 17);
            this.label16.TabIndex = 310;
            this.label16.Text = "Até";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1478, 317);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 17);
            this.label15.TabIndex = 309;
            this.label15.Text = "De";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1333, 317);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 17);
            this.label14.TabIndex = 308;
            this.label14.Text = "Pesquisar por data";
            // 
            // mask_data_valor1
            // 
            this.mask_data_valor1.BeepOnError = true;
            this.mask_data_valor1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mask_data_valor1.Enabled = false;
            this.mask_data_valor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mask_data_valor1.Location = new System.Drawing.Point(1511, 311);
            this.mask_data_valor1.Margin = new System.Windows.Forms.Padding(4);
            this.mask_data_valor1.Mask = "00/00/0000";
            this.mask_data_valor1.Name = "mask_data_valor1";
            this.mask_data_valor1.RejectInputOnFirstFailure = true;
            this.mask_data_valor1.Size = new System.Drawing.Size(101, 29);
            this.mask_data_valor1.TabIndex = 307;
            this.mask_data_valor1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1346, 262);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 17);
            this.label13.TabIndex = 306;
            this.label13.Text = "Pesquisar por horario";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1639, 265);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 17);
            this.label12.TabIndex = 305;
            this.label12.Text = "Até";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1510, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 17);
            this.label11.TabIndex = 304;
            this.label11.Text = "De";
            // 
            // mask_horario_valor2
            // 
            this.mask_horario_valor2.Enabled = false;
            this.mask_horario_valor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_horario_valor2.Location = new System.Drawing.Point(1687, 252);
            this.mask_horario_valor2.Mask = "00:00";
            this.mask_horario_valor2.Name = "mask_horario_valor2";
            this.mask_horario_valor2.Size = new System.Drawing.Size(69, 30);
            this.mask_horario_valor2.TabIndex = 303;
            this.mask_horario_valor2.ValidatingType = typeof(System.DateTime);
            // 
            // mask_horario_valor1
            // 
            this.mask_horario_valor1.Enabled = false;
            this.mask_horario_valor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_horario_valor1.Location = new System.Drawing.Point(1542, 252);
            this.mask_horario_valor1.Mask = "00:00";
            this.mask_horario_valor1.Name = "mask_horario_valor1";
            this.mask_horario_valor1.Size = new System.Drawing.Size(69, 30);
            this.mask_horario_valor1.TabIndex = 302;
            this.mask_horario_valor1.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1639, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 17);
            this.label7.TabIndex = 301;
            this.label7.Text = "Até";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1510, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 17);
            this.label6.TabIndex = 300;
            this.label6.Text = "De";
            // 
            // txt_pesquisa_numero2
            // 
            this.txt_pesquisa_numero2.Enabled = false;
            this.txt_pesquisa_numero2.Location = new System.Drawing.Point(1687, 200);
            this.txt_pesquisa_numero2.Name = "txt_pesquisa_numero2";
            this.txt_pesquisa_numero2.Size = new System.Drawing.Size(69, 22);
            this.txt_pesquisa_numero2.TabIndex = 299;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1343, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 298;
            this.label5.Text = "Pesquisar por numero";
            // 
            // txt_pesquisa_numero1
            // 
            this.txt_pesquisa_numero1.Enabled = false;
            this.txt_pesquisa_numero1.Location = new System.Drawing.Point(1542, 200);
            this.txt_pesquisa_numero1.Name = "txt_pesquisa_numero1";
            this.txt_pesquisa_numero1.Size = new System.Drawing.Size(69, 22);
            this.txt_pesquisa_numero1.TabIndex = 297;
            // 
            // btn_todos
            // 
            this.btn_todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_todos.Location = new System.Drawing.Point(1308, 546);
            this.btn_todos.Name = "btn_todos";
            this.btn_todos.Size = new System.Drawing.Size(245, 60);
            this.btn_todos.TabIndex = 296;
            this.btn_todos.Text = "Todos os registros";
            this.btn_todos.UseVisualStyleBackColor = true;
            this.btn_todos.Click += new System.EventHandler(this.btn_todos_Click);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar.Location = new System.Drawing.Point(1593, 546);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(163, 60);
            this.btn_pesquisar.TabIndex = 295;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // dgdados
            // 
            this.dgdados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdados.Location = new System.Drawing.Point(31, 187);
            this.dgdados.Name = "dgdados";
            this.dgdados.RowTemplate.Height = 24;
            this.dgdados.Size = new System.Drawing.Size(999, 493);
            this.dgdados.TabIndex = 293;
            // 
            // radioPagou
            // 
            this.radioPagou.AutoSize = true;
            this.radioPagou.Location = new System.Drawing.Point(1408, 65);
            this.radioPagou.Name = "radioPagou";
            this.radioPagou.Size = new System.Drawing.Size(70, 21);
            this.radioPagou.TabIndex = 315;
            this.radioPagou.TabStop = true;
            this.radioPagou.Text = "Pagou";
            this.radioPagou.UseVisualStyleBackColor = true;
            // 
            // radioNaoPagou
            // 
            this.radioNaoPagou.AutoSize = true;
            this.radioNaoPagou.Location = new System.Drawing.Point(1511, 65);
            this.radioNaoPagou.Name = "radioNaoPagou";
            this.radioNaoPagou.Size = new System.Drawing.Size(99, 21);
            this.radioNaoPagou.TabIndex = 316;
            this.radioNaoPagou.TabStop = true;
            this.radioNaoPagou.Text = "Não pagou";
            this.radioNaoPagou.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1638, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 321;
            this.label1.Text = "Até";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1509, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 320;
            this.label3.Text = "De";
            // 
            // txtMoedaValor2
            // 
            this.txtMoedaValor2.Enabled = false;
            this.txtMoedaValor2.Location = new System.Drawing.Point(1686, 112);
            this.txtMoedaValor2.Name = "txtMoedaValor2";
            this.txtMoedaValor2.Size = new System.Drawing.Size(69, 22);
            this.txtMoedaValor2.TabIndex = 319;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1322, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 17);
            this.label4.TabIndex = 318;
            this.label4.Text = "Pesquisar por moeda R$:";
            // 
            // txtMoedaValor1
            // 
            this.txtMoedaValor1.Enabled = false;
            this.txtMoedaValor1.Location = new System.Drawing.Point(1541, 112);
            this.txtMoedaValor1.Name = "txtMoedaValor1";
            this.txtMoedaValor1.Size = new System.Drawing.Size(69, 22);
            this.txtMoedaValor1.TabIndex = 317;
            // 
            // FrmPesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1767, 703);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMoedaValor2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMoedaValor1);
            this.Controls.Add(this.radioNaoPagou);
            this.Controls.Add(this.radioPagou);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_pesquisa_texto);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.mask_data_valor2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.mask_data_valor1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mask_horario_valor2);
            this.Controls.Add(this.mask_horario_valor1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_pesquisa_numero2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_pesquisa_numero1);
            this.Controls.Add(this.btn_todos);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.dgdados);
            this.Name = "FrmPesquisar";
            this.Text = "FrmPesquisar";
            this.Load += new System.EventHandler(this.FrmPesquisar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pesquisa_texto;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MaskedTextBox mask_data_valor2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox mask_data_valor1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mask_horario_valor2;
        private System.Windows.Forms.MaskedTextBox mask_horario_valor1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_pesquisa_numero2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_pesquisa_numero1;
        private System.Windows.Forms.Button btn_todos;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.DataGridView dgdados;
        private System.Windows.Forms.RadioButton radioPagou;
        private System.Windows.Forms.RadioButton radioNaoPagou;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMoedaValor2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMoedaValor1;
    }
}