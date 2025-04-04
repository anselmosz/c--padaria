namespace CalculadoraIMC
{
    partial class frmCalculaIMC
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
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.rdbFem = new System.Windows.Forms.RadioButton();
            this.rdbMasc = new System.Windows.Forms.RadioButton();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtImcResultado = new System.Windows.Forms.TextBox();
            this.txtImcCategoria = new System.Windows.Forms.TextBox();
            this.lblCategoriaImc = new System.Windows.Forms.Label();
            this.gpbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(16, 120);
            this.lblIdade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(123, 20);
            this.lblIdade.TabIndex = 0;
            this.lblIdade.Text = "Digite sua idade";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(16, 185);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(124, 20);
            this.lblAltura.TabIndex = 1;
            this.lblAltura.Text = "Digite sua altura";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(16, 250);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(119, 20);
            this.lblPeso.TabIndex = 2;
            this.lblPeso.Text = "Digite seu peso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "IMC";
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.rdbMasc);
            this.gpbSexo.Controls.Add(this.rdbFem);
            this.gpbSexo.Location = new System.Drawing.Point(13, 14);
            this.gpbSexo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbSexo.Size = new System.Drawing.Size(164, 90);
            this.gpbSexo.TabIndex = 0;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "Selecione o sexo";
            // 
            // rdbFem
            // 
            this.rdbFem.AutoSize = true;
            this.rdbFem.Location = new System.Drawing.Point(19, 27);
            this.rdbFem.Name = "rdbFem";
            this.rdbFem.Size = new System.Drawing.Size(92, 24);
            this.rdbFem.TabIndex = 1;
            this.rdbFem.TabStop = true;
            this.rdbFem.Text = "Feminino";
            this.rdbFem.UseVisualStyleBackColor = true;
            // 
            // rdbMasc
            // 
            this.rdbMasc.AutoSize = true;
            this.rdbMasc.Location = new System.Drawing.Point(19, 57);
            this.rdbMasc.Name = "rdbMasc";
            this.rdbMasc.Size = new System.Drawing.Size(98, 24);
            this.rdbMasc.TabIndex = 2;
            this.rdbMasc.TabStop = true;
            this.rdbMasc.Text = "Masculino";
            this.rdbMasc.UseVisualStyleBackColor = true;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(20, 143);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(148, 26);
            this.txtIdade.TabIndex = 3;
            this.txtIdade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(20, 208);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(148, 26);
            this.txtAltura.TabIndex = 4;
            this.txtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(20, 273);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(148, 26);
            this.txtPeso.TabIndex = 5;
            this.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(202, 20);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(110, 45);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "&Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtImcResultado
            // 
            this.txtImcResultado.Enabled = false;
            this.txtImcResultado.Location = new System.Drawing.Point(271, 78);
            this.txtImcResultado.Name = "txtImcResultado";
            this.txtImcResultado.Size = new System.Drawing.Size(148, 26);
            this.txtImcResultado.TabIndex = 8;
            this.txtImcResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtImcCategoria
            // 
            this.txtImcCategoria.Enabled = false;
            this.txtImcCategoria.Location = new System.Drawing.Point(230, 143);
            this.txtImcCategoria.Name = "txtImcCategoria";
            this.txtImcCategoria.Size = new System.Drawing.Size(189, 26);
            this.txtImcCategoria.TabIndex = 10;
            this.txtImcCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCategoriaImc
            // 
            this.lblCategoriaImc.AutoSize = true;
            this.lblCategoriaImc.Location = new System.Drawing.Point(278, 120);
            this.lblCategoriaImc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoriaImc.Name = "lblCategoriaImc";
            this.lblCategoriaImc.Size = new System.Drawing.Size(97, 20);
            this.lblCategoriaImc.TabIndex = 9;
            this.lblCategoriaImc.Text = "Nível do IMC";
            // 
            // frmCalculaIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 326);
            this.Controls.Add(this.txtImcCategoria);
            this.Controls.Add(this.lblCategoriaImc);
            this.Controls.Add(this.txtImcResultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.gpbSexo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblIdade);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCalculaIMC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCalculaIMC";
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.RadioButton rdbMasc;
        private System.Windows.Forms.RadioButton rdbFem;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtImcResultado;
        private System.Windows.Forms.TextBox txtImcCategoria;
        private System.Windows.Forms.Label lblCategoriaImc;
    }
}