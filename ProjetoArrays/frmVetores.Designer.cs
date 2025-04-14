namespace ProjetoArrays
{
    partial class frmVetores
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
            this.gpbNomes = new System.Windows.Forms.GroupBox();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.lblListaNomes = new System.Windows.Forms.Label();
            this.ltbNomes = new System.Windows.Forms.ListBox();
            this.lblDigitarNome = new System.Windows.Forms.Label();
            this.txtDigitarNome = new System.Windows.Forms.TextBox();
            this.gpbNomes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbNomes
            // 
            this.gpbNomes.Controls.Add(this.txtDigitarNome);
            this.gpbNomes.Controls.Add(this.lblDigitarNome);
            this.gpbNomes.Controls.Add(this.ltbNomes);
            this.gpbNomes.Controls.Add(this.lblListaNomes);
            this.gpbNomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbNomes.Location = new System.Drawing.Point(12, 11);
            this.gpbNomes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbNomes.Name = "gpbNomes";
            this.gpbNomes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbNomes.Size = new System.Drawing.Size(455, 315);
            this.gpbNomes.TabIndex = 0;
            this.gpbNomes.TabStop = false;
            this.gpbNomes.Text = "Nomes";
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(13, 332);
            this.btnCarregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(128, 36);
            this.btnCarregar.TabIndex = 0;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // lblListaNomes
            // 
            this.lblListaNomes.AutoSize = true;
            this.lblListaNomes.Location = new System.Drawing.Point(220, 63);
            this.lblListaNomes.Name = "lblListaNomes";
            this.lblListaNomes.Size = new System.Drawing.Size(119, 20);
            this.lblListaNomes.TabIndex = 0;
            this.lblListaNomes.Text = "Lista de Nomes";
            // 
            // ltbNomes
            // 
            this.ltbNomes.FormattingEnabled = true;
            this.ltbNomes.ItemHeight = 20;
            this.ltbNomes.Location = new System.Drawing.Point(224, 86);
            this.ltbNomes.Name = "ltbNomes";
            this.ltbNomes.Size = new System.Drawing.Size(212, 204);
            this.ltbNomes.TabIndex = 1;
            // 
            // lblDigitarNome
            // 
            this.lblDigitarNome.AutoSize = true;
            this.lblDigitarNome.Location = new System.Drawing.Point(10, 63);
            this.lblDigitarNome.Name = "lblDigitarNome";
            this.lblDigitarNome.Size = new System.Drawing.Size(120, 20);
            this.lblDigitarNome.TabIndex = 2;
            this.lblDigitarNome.Text = "Digite um nome";
            // 
            // txtDigitarNome
            // 
            this.txtDigitarNome.Location = new System.Drawing.Point(14, 86);
            this.txtDigitarNome.Name = "txtDigitarNome";
            this.txtDigitarNome.Size = new System.Drawing.Size(149, 26);
            this.txtDigitarNome.TabIndex = 3;
            // 
            // frmVetores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 561);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.gpbNomes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmVetores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vetores";
            this.gpbNomes.ResumeLayout(false);
            this.gpbNomes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbNomes;
        private System.Windows.Forms.TextBox txtDigitarNome;
        private System.Windows.Forms.Label lblDigitarNome;
        private System.Windows.Forms.ListBox ltbNomes;
        private System.Windows.Forms.Label lblListaNomes;
        private System.Windows.Forms.Button btnCarregar;
    }
}