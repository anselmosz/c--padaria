﻿namespace ProjetoArrays
{
    partial class frmMatriz
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
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpbListaMatries = new System.Windows.Forms.GroupBox();
            this.ltbMatriz = new System.Windows.Forms.ListBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblLinha = new System.Windows.Forms.Label();
            this.gpbListaMatries.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(6, 435);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(110, 45);
            this.btnCarregar.TabIndex = 0;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(122, 435);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(110, 45);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(307, 435);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 45);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // gpbListaMatries
            // 
            this.gpbListaMatries.Controls.Add(this.ltbMatriz);
            this.gpbListaMatries.Controls.Add(this.txtNome);
            this.gpbListaMatries.Controls.Add(this.lblLinha);
            this.gpbListaMatries.Controls.Add(this.btnLimpar);
            this.gpbListaMatries.Controls.Add(this.btnSair);
            this.gpbListaMatries.Controls.Add(this.btnCarregar);
            this.gpbListaMatries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbListaMatries.Location = new System.Drawing.Point(12, 12);
            this.gpbListaMatries.Name = "gpbListaMatries";
            this.gpbListaMatries.Size = new System.Drawing.Size(423, 486);
            this.gpbListaMatries.TabIndex = 3;
            this.gpbListaMatries.TabStop = false;
            this.gpbListaMatries.Text = "\'";
            // 
            // ltbMatriz
            // 
            this.ltbMatriz.FormattingEnabled = true;
            this.ltbMatriz.ItemHeight = 20;
            this.ltbMatriz.Location = new System.Drawing.Point(216, 37);
            this.ltbMatriz.Name = "ltbMatriz";
            this.ltbMatriz.Size = new System.Drawing.Size(183, 224);
            this.ltbMatriz.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(90, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 26);
            this.txtNome.TabIndex = 5;
            // 
            // lblLinha
            // 
            this.lblLinha.AutoSize = true;
            this.lblLinha.Location = new System.Drawing.Point(25, 40);
            this.lblLinha.Name = "lblLinha";
            this.lblLinha.Size = new System.Drawing.Size(48, 20);
            this.lblLinha.TabIndex = 3;
            this.lblLinha.Text = "Linha";
            // 
            // frmMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 513);
            this.Controls.Add(this.gpbListaMatries);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMatriz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matrizes";
            this.gpbListaMatries.ResumeLayout(false);
            this.gpbListaMatries.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox gpbListaMatries;
        private System.Windows.Forms.ListBox ltbMatriz;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblLinha;
    }
}