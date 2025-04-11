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
            this.cbbEstados = new System.Windows.Forms.ComboBox();
            this.btnCarregarEstado = new System.Windows.Forms.Button();
            this.ltbEstado = new System.Windows.Forms.ListBox();
            this.btnLimparLista = new System.Windows.Forms.Button();
            this.lblListaEstados = new System.Windows.Forms.Label();
            this.lblListadeEstados = new System.Windows.Forms.Label();
            this.lblDigitarEstado = new System.Windows.Forms.Label();
            this.txtInserirEstado = new System.Windows.Forms.TextBox();
            this.btnLimparTxtBox = new System.Windows.Forms.Button();
            this.btnLimparSeleção = new System.Windows.Forms.Button();
            this.btnCarregarNaLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbEstados
            // 
            this.cbbEstados.FormattingEnabled = true;
            this.cbbEstados.Items.AddRange(new object[] {
            "--- Selecione um item ---"});
            this.cbbEstados.Location = new System.Drawing.Point(13, 43);
            this.cbbEstados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbEstados.Name = "cbbEstados";
            this.cbbEstados.Size = new System.Drawing.Size(232, 28);
            this.cbbEstados.TabIndex = 4;
            // 
            // btnCarregarEstado
            // 
            this.btnCarregarEstado.Location = new System.Drawing.Point(12, 277);
            this.btnCarregarEstado.Name = "btnCarregarEstado";
            this.btnCarregarEstado.Size = new System.Drawing.Size(103, 31);
            this.btnCarregarEstado.TabIndex = 1;
            this.btnCarregarEstado.Text = "Inserir";
            this.btnCarregarEstado.UseVisualStyleBackColor = true;
            this.btnCarregarEstado.Click += new System.EventHandler(this.btnCarregarEstado_Click);
            // 
            // ltbEstado
            // 
            this.ltbEstado.FormattingEnabled = true;
            this.ltbEstado.ItemHeight = 20;
            this.ltbEstado.Location = new System.Drawing.Point(273, 43);
            this.ltbEstado.Name = "ltbEstado";
            this.ltbEstado.Size = new System.Drawing.Size(232, 264);
            this.ltbEstado.TabIndex = 5;
            // 
            // btnLimparLista
            // 
            this.btnLimparLista.Location = new System.Drawing.Point(273, 351);
            this.btnLimparLista.Name = "btnLimparLista";
            this.btnLimparLista.Size = new System.Drawing.Size(232, 31);
            this.btnLimparLista.TabIndex = 7;
            this.btnLimparLista.Text = "Limpar Lista de Estados";
            this.btnLimparLista.UseVisualStyleBackColor = true;
            this.btnLimparLista.Click += new System.EventHandler(this.btnLimparLista_Click);
            // 
            // lblListaEstados
            // 
            this.lblListaEstados.AutoSize = true;
            this.lblListaEstados.Location = new System.Drawing.Point(12, 20);
            this.lblListaEstados.Name = "lblListaEstados";
            this.lblListaEstados.Size = new System.Drawing.Size(68, 20);
            this.lblListaEstados.TabIndex = 4;
            this.lblListaEstados.Text = "Estados";
            // 
            // lblListadeEstados
            // 
            this.lblListadeEstados.AutoSize = true;
            this.lblListadeEstados.Location = new System.Drawing.Point(278, 20);
            this.lblListadeEstados.Name = "lblListadeEstados";
            this.lblListadeEstados.Size = new System.Drawing.Size(128, 20);
            this.lblListadeEstados.TabIndex = 5;
            this.lblListadeEstados.Text = "Lista de Estados";
            // 
            // lblDigitarEstado
            // 
            this.lblDigitarEstado.AutoSize = true;
            this.lblDigitarEstado.Location = new System.Drawing.Point(12, 221);
            this.lblDigitarEstado.Name = "lblDigitarEstado";
            this.lblDigitarEstado.Size = new System.Drawing.Size(118, 20);
            this.lblDigitarEstado.TabIndex = 6;
            this.lblDigitarEstado.Text = "Digite o Estado";
            // 
            // txtInserirEstado
            // 
            this.txtInserirEstado.Location = new System.Drawing.Point(12, 244);
            this.txtInserirEstado.MaxLength = 100;
            this.txtInserirEstado.Name = "txtInserirEstado";
            this.txtInserirEstado.Size = new System.Drawing.Size(232, 26);
            this.txtInserirEstado.TabIndex = 0;
            this.txtInserirEstado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInserirEstado_KeyDown);
            // 
            // btnLimparTxtBox
            // 
            this.btnLimparTxtBox.Location = new System.Drawing.Point(141, 277);
            this.btnLimparTxtBox.Name = "btnLimparTxtBox";
            this.btnLimparTxtBox.Size = new System.Drawing.Size(103, 31);
            this.btnLimparTxtBox.TabIndex = 2;
            this.btnLimparTxtBox.Text = "Limpar";
            this.btnLimparTxtBox.UseVisualStyleBackColor = true;
            this.btnLimparTxtBox.Click += new System.EventHandler(this.btnLimparTxtBox_Click);
            // 
            // btnLimparSeleção
            // 
            this.btnLimparSeleção.Location = new System.Drawing.Point(273, 314);
            this.btnLimparSeleção.Name = "btnLimparSeleção";
            this.btnLimparSeleção.Size = new System.Drawing.Size(232, 31);
            this.btnLimparSeleção.TabIndex = 6;
            this.btnLimparSeleção.Text = "Remover item selecionado";
            this.btnLimparSeleção.UseVisualStyleBackColor = true;
            this.btnLimparSeleção.Click += new System.EventHandler(this.btnLimparSeleção_Click);
            // 
            // btnCarregarNaLista
            // 
            this.btnCarregarNaLista.Location = new System.Drawing.Point(12, 314);
            this.btnCarregarNaLista.Name = "btnCarregarNaLista";
            this.btnCarregarNaLista.Size = new System.Drawing.Size(232, 31);
            this.btnCarregarNaLista.TabIndex = 3;
            this.btnCarregarNaLista.Text = "Carregar Estado";
            this.btnCarregarNaLista.UseVisualStyleBackColor = true;
            this.btnCarregarNaLista.Click += new System.EventHandler(this.btnCarregarNaLista_Click);
            // 
            // frmRepeticao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 394);
            this.Controls.Add(this.btnCarregarNaLista);
            this.Controls.Add(this.btnLimparSeleção);
            this.Controls.Add(this.btnLimparTxtBox);
            this.Controls.Add(this.txtInserirEstado);
            this.Controls.Add(this.lblDigitarEstado);
            this.Controls.Add(this.lblListadeEstados);
            this.Controls.Add(this.lblListaEstados);
            this.Controls.Add(this.btnLimparLista);
            this.Controls.Add(this.ltbEstado);
            this.Controls.Add(this.btnCarregarEstado);
            this.Controls.Add(this.cbbEstados);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRepeticao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRepetição";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbEstados;
        private System.Windows.Forms.Button btnCarregarEstado;
        private System.Windows.Forms.ListBox ltbEstado;
        private System.Windows.Forms.Button btnLimparLista;
        private System.Windows.Forms.Label lblListaEstados;
        private System.Windows.Forms.Label lblListadeEstados;
        private System.Windows.Forms.Label lblDigitarEstado;
        private System.Windows.Forms.TextBox txtInserirEstado;
        private System.Windows.Forms.Button btnLimparTxtBox;
        private System.Windows.Forms.Button btnLimparSeleção;
        private System.Windows.Forms.Button btnCarregarNaLista;
    }
}