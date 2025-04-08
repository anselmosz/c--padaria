namespace ProjetoOrientacaoObjeto
{
    partial class frmExecutaObjeto
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResposta = new System.Windows.Forms.Label();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdSomar = new System.Windows.Forms.RadioButton();
            this.rdSubtrair = new System.Windows.Forms.RadioButton();
            this.rdMultiplicar = new System.Windows.Forms.RadioButton();
            this.RdDividir = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(34, 307);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(169, 53);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnClacular_Click);
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(30, 420);
            this.lblResposta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(78, 20);
            this.lblResposta.TabIndex = 1;
            this.lblResposta.Text = "Resposta";
            // 
            // txtResposta
            // 
            this.txtResposta.Location = new System.Drawing.Point(34, 443);
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(169, 26);
            this.txtResposta.TabIndex = 2;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(34, 47);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(169, 26);
            this.txtNum1.TabIndex = 3;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(34, 99);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(169, 26);
            this.txtNum2.TabIndex = 4;
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(30, 24);
            this.lblNum1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(51, 20);
            this.lblNum1.TabIndex = 5;
            this.lblNum1.Text = "Num1";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(30, 76);
            this.lblNum2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(51, 20);
            this.lblNum2.TabIndex = 6;
            this.lblNum2.Text = "Num2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdDividir);
            this.groupBox1.Controls.Add(this.rdMultiplicar);
            this.groupBox1.Controls.Add(this.rdSubtrair);
            this.groupBox1.Controls.Add(this.rdSomar);
            this.groupBox1.Location = new System.Drawing.Point(34, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 156);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdSomar
            // 
            this.rdSomar.AutoSize = true;
            this.rdSomar.Location = new System.Drawing.Point(25, 25);
            this.rdSomar.Name = "rdSomar";
            this.rdSomar.Size = new System.Drawing.Size(69, 24);
            this.rdSomar.TabIndex = 0;
            this.rdSomar.TabStop = true;
            this.rdSomar.Text = "Soma";
            this.rdSomar.UseVisualStyleBackColor = true;
            // 
            // rdSubtrair
            // 
            this.rdSubtrair.AutoSize = true;
            this.rdSubtrair.Location = new System.Drawing.Point(25, 55);
            this.rdSubtrair.Name = "rdSubtrair";
            this.rdSubtrair.Size = new System.Drawing.Size(101, 24);
            this.rdSubtrair.TabIndex = 1;
            this.rdSubtrair.TabStop = true;
            this.rdSubtrair.Text = "Subtração";
            this.rdSubtrair.UseVisualStyleBackColor = true;
            // 
            // rdMultiplicar
            // 
            this.rdMultiplicar.AutoSize = true;
            this.rdMultiplicar.Location = new System.Drawing.Point(25, 85);
            this.rdMultiplicar.Name = "rdMultiplicar";
            this.rdMultiplicar.Size = new System.Drawing.Size(118, 24);
            this.rdMultiplicar.TabIndex = 2;
            this.rdMultiplicar.TabStop = true;
            this.rdMultiplicar.Text = "Multiplicação";
            this.rdMultiplicar.UseVisualStyleBackColor = true;
            // 
            // RdDividir
            // 
            this.RdDividir.AutoSize = true;
            this.RdDividir.Location = new System.Drawing.Point(25, 115);
            this.RdDividir.Name = "RdDividir";
            this.RdDividir.Size = new System.Drawing.Size(78, 24);
            this.RdDividir.TabIndex = 3;
            this.RdDividir.TabStop = true;
            this.RdDividir.Text = "Divisão";
            this.RdDividir.UseVisualStyleBackColor = true;
            // 
            // frmExecutaObjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 511);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.txtResposta);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.btnCalcular);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmExecutaObjeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Executar Objeto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdDividir;
        private System.Windows.Forms.RadioButton rdMultiplicar;
        private System.Windows.Forms.RadioButton rdSubtrair;
        private System.Windows.Forms.RadioButton rdSomar;
    }
}