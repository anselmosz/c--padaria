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
            this.rdInteirosRndIntervalos = new System.Windows.Forms.RadioButton();
            this.rdVariosInteirosRnd = new System.Windows.Forms.RadioButton();
            this.rdFloatRnd = new System.Windows.Forms.RadioButton();
            this.rdInteirosRnd = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumMaxInput = new System.Windows.Forms.TextBox();
            this.lblNumMax = new System.Windows.Forms.Label();
            this.txtNumMinInput = new System.Windows.Forms.TextBox();
            this.lblNumMin = new System.Windows.Forms.Label();
            this.ltbNumerosGerados = new System.Windows.Forms.ListBox();
            this.txtNumeroInput = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.rdRepeticao = new System.Windows.Forms.RadioButton();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.gpbValores.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbValores
            // 
            this.gpbValores.Controls.Add(this.txtTamanho);
            this.gpbValores.Controls.Add(this.lblTamanho);
            this.gpbValores.Controls.Add(this.rdRepeticao);
            this.gpbValores.Controls.Add(this.rdInteirosRndIntervalos);
            this.gpbValores.Controls.Add(this.rdVariosInteirosRnd);
            this.gpbValores.Controls.Add(this.rdFloatRnd);
            this.gpbValores.Controls.Add(this.rdInteirosRnd);
            this.gpbValores.Controls.Add(this.label3);
            this.gpbValores.Controls.Add(this.txtNumMaxInput);
            this.gpbValores.Controls.Add(this.lblNumMax);
            this.gpbValores.Controls.Add(this.txtNumMinInput);
            this.gpbValores.Controls.Add(this.lblNumMin);
            this.gpbValores.Controls.Add(this.ltbNumerosGerados);
            this.gpbValores.Controls.Add(this.txtNumeroInput);
            this.gpbValores.Controls.Add(this.lblNumero);
            this.gpbValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbValores.Location = new System.Drawing.Point(12, 12);
            this.gpbValores.Name = "gpbValores";
            this.gpbValores.Size = new System.Drawing.Size(721, 333);
            this.gpbValores.TabIndex = 0;
            this.gpbValores.TabStop = false;
            this.gpbValores.Text = "Valores";
            // 
            // rdInteirosRndIntervalos
            // 
            this.rdInteirosRndIntervalos.AutoSize = true;
            this.rdInteirosRndIntervalos.Location = new System.Drawing.Point(17, 154);
            this.rdInteirosRndIntervalos.Name = "rdInteirosRndIntervalos";
            this.rdInteirosRndIntervalos.Size = new System.Drawing.Size(228, 24);
            this.rdInteirosRndIntervalos.TabIndex = 10;
            this.rdInteirosRndIntervalos.TabStop = true;
            this.rdInteirosRndIntervalos.Text = "Inteiros Aleatórios Intervalos";
            this.rdInteirosRndIntervalos.UseVisualStyleBackColor = true;
            this.rdInteirosRndIntervalos.CheckedChanged += new System.EventHandler(this.rdInteirosRndIntervalos_CheckedChanged);
            // 
            // rdVariosInteirosRnd
            // 
            this.rdVariosInteirosRnd.AutoSize = true;
            this.rdVariosInteirosRnd.Location = new System.Drawing.Point(17, 124);
            this.rdVariosInteirosRnd.Name = "rdVariosInteirosRnd";
            this.rdVariosInteirosRnd.Size = new System.Drawing.Size(204, 24);
            this.rdVariosInteirosRnd.TabIndex = 9;
            this.rdVariosInteirosRnd.TabStop = true;
            this.rdVariosInteirosRnd.Text = "Vários Inteiros Aleatórios";
            this.rdVariosInteirosRnd.UseVisualStyleBackColor = true;
            this.rdVariosInteirosRnd.CheckedChanged += new System.EventHandler(this.rdVariosInteirosRnd_CheckedChanged);
            // 
            // rdFloatRnd
            // 
            this.rdFloatRnd.AutoSize = true;
            this.rdFloatRnd.Location = new System.Drawing.Point(17, 184);
            this.rdFloatRnd.Name = "rdFloatRnd";
            this.rdFloatRnd.Size = new System.Drawing.Size(191, 24);
            this.rdFloatRnd.TabIndex = 9;
            this.rdFloatRnd.TabStop = true;
            this.rdFloatRnd.Text = "Gerar Floats Aleatórios";
            this.rdFloatRnd.UseVisualStyleBackColor = true;
            // 
            // rdInteirosRnd
            // 
            this.rdInteirosRnd.AutoSize = true;
            this.rdInteirosRnd.Location = new System.Drawing.Point(17, 94);
            this.rdInteirosRnd.Name = "rdInteirosRnd";
            this.rdInteirosRnd.Size = new System.Drawing.Size(155, 24);
            this.rdInteirosRnd.TabIndex = 8;
            this.rdInteirosRnd.TabStop = true;
            this.rdInteirosRnd.Text = "Inteiros Aleatórios";
            this.rdInteirosRnd.UseVisualStyleBackColor = true;
            this.rdInteirosRnd.CheckedChanged += new System.EventHandler(this.rdInteirosRnd_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Selecione";
            // 
            // txtNumMaxInput
            // 
            this.txtNumMaxInput.Location = new System.Drawing.Point(281, 254);
            this.txtNumMaxInput.Name = "txtNumMaxInput";
            this.txtNumMaxInput.Size = new System.Drawing.Size(119, 26);
            this.txtNumMaxInput.TabIndex = 6;
            // 
            // lblNumMax
            // 
            this.lblNumMax.AutoSize = true;
            this.lblNumMax.Location = new System.Drawing.Point(277, 231);
            this.lblNumMax.Name = "lblNumMax";
            this.lblNumMax.Size = new System.Drawing.Size(123, 20);
            this.lblNumMax.TabIndex = 5;
            this.lblNumMax.Text = "Numero Máximo";
            // 
            // txtNumMinInput
            // 
            this.txtNumMinInput.Location = new System.Drawing.Point(281, 202);
            this.txtNumMinInput.Name = "txtNumMinInput";
            this.txtNumMinInput.Size = new System.Drawing.Size(119, 26);
            this.txtNumMinInput.TabIndex = 4;
            // 
            // lblNumMin
            // 
            this.lblNumMin.AutoSize = true;
            this.lblNumMin.Location = new System.Drawing.Point(277, 179);
            this.lblNumMin.Name = "lblNumMin";
            this.lblNumMin.Size = new System.Drawing.Size(119, 20);
            this.lblNumMin.TabIndex = 3;
            this.lblNumMin.Text = "Numero Minimo";
            // 
            // ltbNumerosGerados
            // 
            this.ltbNumerosGerados.FormattingEnabled = true;
            this.ltbNumerosGerados.ItemHeight = 20;
            this.ltbNumerosGerados.Location = new System.Drawing.Point(468, 37);
            this.ltbNumerosGerados.Name = "ltbNumerosGerados";
            this.ltbNumerosGerados.Size = new System.Drawing.Size(226, 264);
            this.ltbNumerosGerados.TabIndex = 2;
            // 
            // txtNumeroInput
            // 
            this.txtNumeroInput.Location = new System.Drawing.Point(281, 122);
            this.txtNumeroInput.Name = "txtNumeroInput";
            this.txtNumeroInput.Size = new System.Drawing.Size(119, 26);
            this.txtNumeroInput.TabIndex = 1;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(277, 99);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(123, 20);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Insira o múmero";
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(29, 351);
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
            this.btnSair.Location = new System.Drawing.Point(393, 351);
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
            this.btnLimpar.Location = new System.Drawing.Point(213, 351);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(135, 44);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // rdRepeticao
            // 
            this.rdRepeticao.AutoSize = true;
            this.rdRepeticao.Location = new System.Drawing.Point(17, 214);
            this.rdRepeticao.Name = "rdRepeticao";
            this.rdRepeticao.Size = new System.Drawing.Size(200, 24);
            this.rdRepeticao.TabIndex = 11;
            this.rdRepeticao.TabStop = true;
            this.rdRepeticao.Text = "Gerar inteiros Repetição";
            this.rdRepeticao.UseVisualStyleBackColor = true;
            this.rdRepeticao.CheckedChanged += new System.EventHandler(this.rdRepeticao_CheckedChanged);
            // 
            // txtTamanho
            // 
            this.txtTamanho.Location = new System.Drawing.Point(281, 70);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(119, 26);
            this.txtTamanho.TabIndex = 13;
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Location = new System.Drawing.Point(277, 47);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(76, 20);
            this.lblTamanho.TabIndex = 12;
            this.lblTamanho.Text = "Tamanho";
            // 
            // frmNumAleatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 405);
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
        private System.Windows.Forms.RadioButton rdInteirosRndIntervalos;
        private System.Windows.Forms.RadioButton rdVariosInteirosRnd;
        private System.Windows.Forms.RadioButton rdFloatRnd;
        private System.Windows.Forms.RadioButton rdInteirosRnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumMaxInput;
        private System.Windows.Forms.Label lblNumMax;
        private System.Windows.Forms.TextBox txtNumMinInput;
        private System.Windows.Forms.Label lblNumMin;
        private System.Windows.Forms.RadioButton rdRepeticao;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.Label lblTamanho;
    }
}