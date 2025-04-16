namespace ProjetoArrays
{
    partial class frmNumAleatorio
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
            this.gpbValores = new System.Windows.Forms.GroupBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumeroInput = new System.Windows.Forms.TextBox();
            this.ltbNumerosGerados = new System.Windows.Forms.ListBox();
            this.gpbValores.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbValores
            // 
            this.gpbValores.Controls.Add(this.ltbNumerosGerados);
            this.gpbValores.Controls.Add(this.txtNumeroInput);
            this.gpbValores.Controls.Add(this.lblNumero);
            this.gpbValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbValores.Location = new System.Drawing.Point(12, 12);
            this.gpbValores.Name = "gpbValores";
            this.gpbValores.Size = new System.Drawing.Size(499, 358);
            this.gpbValores.TabIndex = 0;
            this.gpbValores.TabStop = false;
            this.gpbValores.Text = "Valores";
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(12, 376);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(135, 44);
            this.btnGerar.TabIndex = 1;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(376, 376);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(135, 44);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(196, 376);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(135, 44);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(29, 45);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(123, 20);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Insira o múmero";
            // 
            // txtNumeroInput
            // 
            this.txtNumeroInput.Location = new System.Drawing.Point(33, 68);
            this.txtNumeroInput.Name = "txtNumeroInput";
            this.txtNumeroInput.Size = new System.Drawing.Size(119, 26);
            this.txtNumeroInput.TabIndex = 1;
            // 
            // ltbNumerosGerados
            // 
            this.ltbNumerosGerados.FormattingEnabled = true;
            this.ltbNumerosGerados.ItemHeight = 20;
            this.ltbNumerosGerados.Location = new System.Drawing.Point(236, 68);
            this.ltbNumerosGerados.Name = "ltbNumerosGerados";
            this.ltbNumerosGerados.Size = new System.Drawing.Size(226, 264);
            this.ltbNumerosGerados.TabIndex = 2;
            // 
            // frmNumAleatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 435);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.gpbValores);
            this.Name = "frmNumAleatorio";
            this.Text = "frmNumAleatorio";
            this.gpbValores.ResumeLayout(false);
            this.gpbValores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbValores;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ListBox ltbNumerosGerados;
        private System.Windows.Forms.TextBox txtNumeroInput;
        private System.Windows.Forms.Label lblNumero;
    }
}