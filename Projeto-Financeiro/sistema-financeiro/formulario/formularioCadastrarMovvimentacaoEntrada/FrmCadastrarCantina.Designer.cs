﻿namespace sistema_financeiro.formulario.formularioCadastrarMovvimentacaoEntrada
{
    partial class FrmCadastrarCantina
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxPagou = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mask_data_recebimento = new System.Windows.Forms.MaskedTextBox();
            this.txt_numero_id = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 276;
            this.label2.Text = "Valor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 277;
            this.label1.Text = "Data de recebimento:";
            // 
            // checkBoxPagou
            // 
            this.checkBoxPagou.AutoSize = true;
            this.checkBoxPagou.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPagou.Location = new System.Drawing.Point(254, 158);
            this.checkBoxPagou.Name = "checkBoxPagou";
            this.checkBoxPagou.Size = new System.Drawing.Size(91, 29);
            this.checkBoxPagou.TabIndex = 278;
            this.checkBoxPagou.Text = "Pagou";
            this.checkBoxPagou.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 25);
            this.label3.TabIndex = 279;
            this.label3.Text = "Nº de identificação do comprador:";
            // 
            // mask_data_recebimento
            // 
            this.mask_data_recebimento.BeepOnError = true;
            this.mask_data_recebimento.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mask_data_recebimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mask_data_recebimento.Location = new System.Drawing.Point(254, 239);
            this.mask_data_recebimento.Margin = new System.Windows.Forms.Padding(4);
            this.mask_data_recebimento.Mask = "00/00/0000";
            this.mask_data_recebimento.Name = "mask_data_recebimento";
            this.mask_data_recebimento.RejectInputOnFirstFailure = true;
            this.mask_data_recebimento.Size = new System.Drawing.Size(132, 29);
            this.mask_data_recebimento.TabIndex = 282;
            this.mask_data_recebimento.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mask_data_recebimento.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mask_data_recebimento_MaskInputRejected);
            // 
            // txt_numero_id
            // 
            this.txt_numero_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero_id.Location = new System.Drawing.Point(323, 339);
            this.txt_numero_id.Name = "txt_numero_id";
            this.txt_numero_id.Size = new System.Drawing.Size(172, 30);
            this.txt_numero_id.TabIndex = 288;
            this.txt_numero_id.TextChanged += new System.EventHandler(this.txt_numero_id_TextChanged);
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(254, 76);
            this.txtValor.MaxLength = 9;
            this.txtValor.Name = "txtValor";
            this.txtValor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtValor.Size = new System.Drawing.Size(128, 30);
            this.txtValor.TabIndex = 289;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // FrmCadastrarCantina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txt_numero_id);
            this.Controls.Add(this.mask_data_recebimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxPagou);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FrmCadastrarCantina";
            this.Text = "FrmCadastrarCantina";
            this.Load += new System.EventHandler(this.FrmCadastrarCantina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxPagou;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mask_data_recebimento;
        private System.Windows.Forms.TextBox txt_numero_id;
        private System.Windows.Forms.TextBox txtValor;
    }
}