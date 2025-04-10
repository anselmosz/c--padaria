namespace ProjetoOrientacaoObjeto
{
    partial class frmRepeticao
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
            this.cbbWishlist = new System.Windows.Forms.ComboBox();
            this.btnCarregarEstado = new System.Windows.Forms.Button();
            this.ltbEstado = new System.Windows.Forms.ListBox();
            this.btnWishlist = new System.Windows.Forms.Button();
            this.lblListaEstados = new System.Windows.Forms.Label();
            this.lblListadeEstados = new System.Windows.Forms.Label();
            this.lblDigitarEstado = new System.Windows.Forms.Label();
            this.txtInserirEstado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbbWishlist
            // 
            this.cbbWishlist.FormattingEnabled = true;
            this.cbbWishlist.Location = new System.Drawing.Point(12, 135);
            this.cbbWishlist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbWishlist.Name = "cbbWishlist";
            this.cbbWishlist.Size = new System.Drawing.Size(183, 28);
            this.cbbWishlist.TabIndex = 1;
            // 
            // btnCarregarEstado
            // 
            this.btnCarregarEstado.Location = new System.Drawing.Point(12, 68);
            this.btnCarregarEstado.Name = "btnCarregarEstado";
            this.btnCarregarEstado.Size = new System.Drawing.Size(183, 34);
            this.btnCarregarEstado.TabIndex = 1;
            this.btnCarregarEstado.Text = "Carregar estado";
            this.btnCarregarEstado.UseVisualStyleBackColor = true;
            this.btnCarregarEstado.Click += new System.EventHandler(this.btnCarregarEstado_Click);
            // 
            // ltbEstado
            // 
            this.ltbEstado.FormattingEnabled = true;
            this.ltbEstado.ItemHeight = 20;
            this.ltbEstado.Location = new System.Drawing.Point(226, 76);
            this.ltbEstado.Name = "ltbEstado";
            this.ltbEstado.Size = new System.Drawing.Size(206, 224);
            this.ltbEstado.TabIndex = 3;
            // 
            // btnWishlist
            // 
            this.btnWishlist.Location = new System.Drawing.Point(226, 36);
            this.btnWishlist.Name = "btnWishlist";
            this.btnWishlist.Size = new System.Drawing.Size(206, 34);
            this.btnWishlist.TabIndex = 2;
            this.btnWishlist.Text = "Carrega Lista de Estados";
            this.btnWishlist.UseVisualStyleBackColor = true;
            this.btnWishlist.Click += new System.EventHandler(this.btnWishlist_Click);
            // 
            // lblListaEstados
            // 
            this.lblListaEstados.AutoSize = true;
            this.lblListaEstados.Location = new System.Drawing.Point(12, 110);
            this.lblListaEstados.Name = "lblListaEstados";
            this.lblListaEstados.Size = new System.Drawing.Size(68, 20);
            this.lblListaEstados.TabIndex = 4;
            this.lblListaEstados.Text = "Estados";
            // 
            // lblListadeEstados
            // 
            this.lblListadeEstados.AutoSize = true;
            this.lblListadeEstados.Location = new System.Drawing.Point(222, 11);
            this.lblListadeEstados.Name = "lblListadeEstados";
            this.lblListadeEstados.Size = new System.Drawing.Size(127, 20);
            this.lblListadeEstados.TabIndex = 5;
            this.lblListadeEstados.Text = "Lista de Desejos";
            // 
            // lblDigitarEstado
            // 
            this.lblDigitarEstado.AutoSize = true;
            this.lblDigitarEstado.Location = new System.Drawing.Point(8, 13);
            this.lblDigitarEstado.Name = "lblDigitarEstado";
            this.lblDigitarEstado.Size = new System.Drawing.Size(118, 20);
            this.lblDigitarEstado.TabIndex = 6;
            this.lblDigitarEstado.Text = "Digite o Estado";
            // 
            // txtInserirEstado
            // 
            this.txtInserirEstado.Location = new System.Drawing.Point(12, 36);
            this.txtInserirEstado.Name = "txtInserirEstado";
            this.txtInserirEstado.Size = new System.Drawing.Size(183, 26);
            this.txtInserirEstado.TabIndex = 0;
            this.txtInserirEstado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInserirEstado_KeyDown);
            // 
            // frmRepeticao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 465);
            this.Controls.Add(this.txtInserirEstado);
            this.Controls.Add(this.lblDigitarEstado);
            this.Controls.Add(this.lblListadeEstados);
            this.Controls.Add(this.lblListaEstados);
            this.Controls.Add(this.btnWishlist);
            this.Controls.Add(this.ltbEstado);
            this.Controls.Add(this.btnCarregarEstado);
            this.Controls.Add(this.cbbWishlist);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRepeticao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRepetição";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbWishlist;
        private System.Windows.Forms.Button btnCarregarEstado;
        private System.Windows.Forms.ListBox ltbEstado;
        private System.Windows.Forms.Button btnWishlist;
        private System.Windows.Forms.Label lblListaEstados;
        private System.Windows.Forms.Label lblListadeEstados;
        private System.Windows.Forms.Label lblDigitarEstado;
        private System.Windows.Forms.TextBox txtInserirEstado;
    }
}