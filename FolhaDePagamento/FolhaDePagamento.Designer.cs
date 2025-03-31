namespace FolhaDePagamento
{
    partial class FolhaDePagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolhaDePagamento));
            this.lblDataDaFolha = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblClube = new System.Windows.Forms.Label();
            this.lblSalarioEmFolha = new System.Windows.Forms.Label();
            this.lblImposto = new System.Windows.Forms.Label();
            this.lblSalarioLiq = new System.Windows.Forms.Label();
            this.ckbPlanoDeSaude = new System.Windows.Forms.CheckBox();
            this.cmbClubes = new System.Windows.Forms.ComboBox();
            this.txtbSalarioInput = new System.Windows.Forms.TextBox();
            this.txtbSalarioBruto = new System.Windows.Forms.TextBox();
            this.txtbImpostoDeRenda = new System.Windows.Forms.TextBox();
            this.txtbSalarioLiq = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDataDaFolha
            // 
            this.lblDataDaFolha.AutoSize = true;
            this.lblDataDaFolha.Location = new System.Drawing.Point(23, 31);
            this.lblDataDaFolha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataDaFolha.Name = "lblDataDaFolha";
            this.lblDataDaFolha.Size = new System.Drawing.Size(110, 20);
            this.lblDataDaFolha.TabIndex = 0;
            this.lblDataDaFolha.Text = "Data da Folha";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(23, 102);
            this.lblSalario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(58, 20);
            this.lblSalario.TabIndex = 1;
            this.lblSalario.Text = "Salário";
            // 
            // lblClube
            // 
            this.lblClube.AutoSize = true;
            this.lblClube.Location = new System.Drawing.Point(23, 220);
            this.lblClube.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClube.Name = "lblClube";
            this.lblClube.Size = new System.Drawing.Size(116, 20);
            this.lblClube.TabIndex = 2;
            this.lblClube.Text = "Clube de Lazer";
            // 
            // lblSalarioEmFolha
            // 
            this.lblSalarioEmFolha.AutoSize = true;
            this.lblSalarioEmFolha.Location = new System.Drawing.Point(245, 43);
            this.lblSalarioEmFolha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalarioEmFolha.Name = "lblSalarioEmFolha";
            this.lblSalarioEmFolha.Size = new System.Drawing.Size(128, 20);
            this.lblSalarioEmFolha.TabIndex = 3;
            this.lblSalarioEmFolha.Text = "Salário em Folha";
            // 
            // lblImposto
            // 
            this.lblImposto.AutoSize = true;
            this.lblImposto.Location = new System.Drawing.Point(245, 102);
            this.lblImposto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImposto.Name = "lblImposto";
            this.lblImposto.Size = new System.Drawing.Size(141, 20);
            this.lblImposto.TabIndex = 4;
            this.lblImposto.Text = "Imposto de Renda";
            // 
            // lblSalarioLiq
            // 
            this.lblSalarioLiq.AutoSize = true;
            this.lblSalarioLiq.Location = new System.Drawing.Point(245, 222);
            this.lblSalarioLiq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalarioLiq.Name = "lblSalarioLiq";
            this.lblSalarioLiq.Size = new System.Drawing.Size(113, 20);
            this.lblSalarioLiq.TabIndex = 5;
            this.lblSalarioLiq.Text = "Salário Líquido";
            // 
            // ckbPlanoDeSaude
            // 
            this.ckbPlanoDeSaude.AutoSize = true;
            this.ckbPlanoDeSaude.Location = new System.Drawing.Point(27, 186);
            this.ckbPlanoDeSaude.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckbPlanoDeSaude.Name = "ckbPlanoDeSaude";
            this.ckbPlanoDeSaude.Size = new System.Drawing.Size(141, 24);
            this.ckbPlanoDeSaude.TabIndex = 2;
            this.ckbPlanoDeSaude.TabStop = false;
            this.ckbPlanoDeSaude.Text = "Plano de Saúde";
            this.ckbPlanoDeSaude.UseVisualStyleBackColor = true;
            // 
            // cmbClubes
            // 
            this.cmbClubes.FormattingEnabled = true;
            this.cmbClubes.Items.AddRange(new object[] {
            "Nenhum",
            "Clube A",
            "Clube B",
            "Clube C"});
            this.cmbClubes.Location = new System.Drawing.Point(27, 245);
            this.cmbClubes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbClubes.Name = "cmbClubes";
            this.cmbClubes.Size = new System.Drawing.Size(141, 28);
            this.cmbClubes.TabIndex = 3;
            // 
            // txtbSalarioInput
            // 
            this.txtbSalarioInput.Location = new System.Drawing.Point(27, 127);
            this.txtbSalarioInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbSalarioInput.Name = "txtbSalarioInput";
            this.txtbSalarioInput.Size = new System.Drawing.Size(148, 26);
            this.txtbSalarioInput.TabIndex = 1;
            // 
            // txtbSalarioBruto
            // 
            this.txtbSalarioBruto.Enabled = false;
            this.txtbSalarioBruto.Location = new System.Drawing.Point(249, 68);
            this.txtbSalarioBruto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbSalarioBruto.Name = "txtbSalarioBruto";
            this.txtbSalarioBruto.Size = new System.Drawing.Size(148, 26);
            this.txtbSalarioBruto.TabIndex = 4;
            // 
            // txtbImpostoDeRenda
            // 
            this.txtbImpostoDeRenda.Enabled = false;
            this.txtbImpostoDeRenda.Location = new System.Drawing.Point(249, 127);
            this.txtbImpostoDeRenda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbImpostoDeRenda.Name = "txtbImpostoDeRenda";
            this.txtbImpostoDeRenda.Size = new System.Drawing.Size(148, 26);
            this.txtbImpostoDeRenda.TabIndex = 5;
            // 
            // txtbSalarioLiq
            // 
            this.txtbSalarioLiq.Enabled = false;
            this.txtbSalarioLiq.Location = new System.Drawing.Point(249, 247);
            this.txtbSalarioLiq.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbSalarioLiq.Name = "txtbSalarioLiq";
            this.txtbSalarioLiq.Size = new System.Drawing.Size(148, 26);
            this.txtbSalarioLiq.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(106, 26);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(491, 223);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(120, 50);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(491, 138);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(120, 50);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.Location = new System.Drawing.Point(491, 56);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(120, 50);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // FolhaDePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 309);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtbSalarioLiq);
            this.Controls.Add(this.txtbImpostoDeRenda);
            this.Controls.Add(this.txtbSalarioBruto);
            this.Controls.Add(this.txtbSalarioInput);
            this.Controls.Add(this.cmbClubes);
            this.Controls.Add(this.ckbPlanoDeSaude);
            this.Controls.Add(this.lblSalarioLiq);
            this.Controls.Add(this.lblImposto);
            this.Controls.Add(this.lblSalarioEmFolha);
            this.Controls.Add(this.lblClube);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblDataDaFolha);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FolhaDePagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FolhaDePagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataDaFolha;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblClube;
        private System.Windows.Forms.Label lblSalarioEmFolha;
        private System.Windows.Forms.Label lblImposto;
        private System.Windows.Forms.Label lblSalarioLiq;
        private System.Windows.Forms.CheckBox ckbPlanoDeSaude;
        private System.Windows.Forms.ComboBox cmbClubes;
        private System.Windows.Forms.TextBox txtbSalarioInput;
        private System.Windows.Forms.TextBox txtbSalarioBruto;
        private System.Windows.Forms.TextBox txtbImpostoDeRenda;
        private System.Windows.Forms.TextBox txtbSalarioLiq;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
    }
}