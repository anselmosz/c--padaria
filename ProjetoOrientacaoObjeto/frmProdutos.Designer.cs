namespace ProjetoOrientacaoObjeto
{
    partial class frmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            this.lblCodigoProduto = new System.Windows.Forms.Label();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.gpgDadosProdutos = new System.Windows.Forms.GroupBox();
            this.dtpcSaida = new System.Windows.Forms.DateTimePicker();
            this.lblDataSaida = new System.Windows.Forms.Label();
            this.dtpcEntrada = new System.Windows.Forms.DateTimePicker();
            this.txtDataEntrada = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpbProdutoCadastrado = new System.Windows.Forms.GroupBox();
            this.lblDataSaidaCadastrada = new System.Windows.Forms.Label();
            this.lblDataEntrCadastrada = new System.Windows.Forms.Label();
            this.lblQtdCadastrada = new System.Windows.Forms.Label();
            this.lblValorCadastrado = new System.Windows.Forms.Label();
            this.lblNomeCadastrado = new System.Windows.Forms.Label();
            this.lblCodCadastrado = new System.Windows.Forms.Label();
            this.lblTotalCadastrado = new System.Windows.Forms.Label();
            this.lblValorTotalTitle = new System.Windows.Forms.Label();
            this.lblQtdTitle = new System.Windows.Forms.Label();
            this.lblDataSaidaTitle = new System.Windows.Forms.Label();
            this.lblDataEntraTitle = new System.Windows.Forms.Label();
            this.lblCodTitle = new System.Windows.Forms.Label();
            this.lblValorTitle = new System.Windows.Forms.Label();
            this.lblNomeTitle = new System.Windows.Forms.Label();
            this.gpgDadosProdutos.SuspendLayout();
            this.gpbProdutoCadastrado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigoProduto
            // 
            this.lblCodigoProduto.AutoSize = true;
            this.lblCodigoProduto.Location = new System.Drawing.Point(22, 64);
            this.lblCodigoProduto.Name = "lblCodigoProduto";
            this.lblCodigoProduto.Size = new System.Drawing.Size(140, 20);
            this.lblCodigoProduto.TabIndex = 1;
            this.lblCodigoProduto.Text = "Codigo do produto";
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Location = new System.Drawing.Point(168, 61);
            this.txtCodigoProduto.MaxLength = 10;
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(170, 26);
            this.txtCodigoProduto.TabIndex = 2;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(168, 29);
            this.txtNomeProduto.MaxLength = 100;
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(280, 26);
            this.txtNomeProduto.TabIndex = 1;
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(22, 32);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(132, 20);
            this.lblNomeProduto.TabIndex = 3;
            this.lblNomeProduto.Text = "Nome do produto";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(22, 96);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(46, 20);
            this.lblValor.TabIndex = 5;
            this.lblValor.Text = "Valor";
            // 
            // gpgDadosProdutos
            // 
            this.gpgDadosProdutos.Controls.Add(this.dtpcSaida);
            this.gpgDadosProdutos.Controls.Add(this.lblDataSaida);
            this.gpgDadosProdutos.Controls.Add(this.dtpcEntrada);
            this.gpgDadosProdutos.Controls.Add(this.txtDataEntrada);
            this.gpgDadosProdutos.Controls.Add(this.txtValor);
            this.gpgDadosProdutos.Controls.Add(this.txtQuantidade);
            this.gpgDadosProdutos.Controls.Add(this.lblQuantidade);
            this.gpgDadosProdutos.Controls.Add(this.lblCodigoProduto);
            this.gpgDadosProdutos.Controls.Add(this.txtCodigoProduto);
            this.gpgDadosProdutos.Controls.Add(this.lblValor);
            this.gpgDadosProdutos.Controls.Add(this.lblNomeProduto);
            this.gpgDadosProdutos.Controls.Add(this.txtNomeProduto);
            this.gpgDadosProdutos.Location = new System.Drawing.Point(12, 12);
            this.gpgDadosProdutos.Name = "gpgDadosProdutos";
            this.gpgDadosProdutos.Size = new System.Drawing.Size(462, 203);
            this.gpgDadosProdutos.TabIndex = 0;
            this.gpgDadosProdutos.TabStop = false;
            this.gpgDadosProdutos.Text = "Cadastrar Produto";
            // 
            // dtpcSaida
            // 
            this.dtpcSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpcSaida.Location = new System.Drawing.Point(153, 157);
            this.dtpcSaida.Name = "dtpcSaida";
            this.dtpcSaida.Size = new System.Drawing.Size(124, 26);
            this.dtpcSaida.TabIndex = 6;
            // 
            // lblDataSaida
            // 
            this.lblDataSaida.AutoSize = true;
            this.lblDataSaida.Location = new System.Drawing.Point(22, 160);
            this.lblDataSaida.Name = "lblDataSaida";
            this.lblDataSaida.Size = new System.Drawing.Size(108, 20);
            this.lblDataSaida.TabIndex = 13;
            this.lblDataSaida.Text = "Data de saída";
            // 
            // dtpcEntrada
            // 
            this.dtpcEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpcEntrada.Location = new System.Drawing.Point(153, 125);
            this.dtpcEntrada.Name = "dtpcEntrada";
            this.dtpcEntrada.Size = new System.Drawing.Size(124, 26);
            this.dtpcEntrada.TabIndex = 5;
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.AutoSize = true;
            this.txtDataEntrada.Location = new System.Drawing.Point(22, 128);
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.Size = new System.Drawing.Size(125, 20);
            this.txtDataEntrada.TabIndex = 11;
            this.txtDataEntrada.Text = "Data de entrada";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(74, 93);
            this.txtValor.MaxLength = 20;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(96, 26);
            this.txtValor.TabIndex = 3;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(274, 93);
            this.txtQuantidade.MaxLength = 100;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(64, 26);
            this.txtQuantidade.TabIndex = 4;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(176, 96);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(92, 20);
            this.lblQuantidade.TabIndex = 7;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(12, 543);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(110, 45);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(128, 543);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(110, 45);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(364, 543);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 45);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // gpbProdutoCadastrado
            // 
            this.gpbProdutoCadastrado.Controls.Add(this.lblDataSaidaCadastrada);
            this.gpbProdutoCadastrado.Controls.Add(this.lblDataEntrCadastrada);
            this.gpbProdutoCadastrado.Controls.Add(this.lblQtdCadastrada);
            this.gpbProdutoCadastrado.Controls.Add(this.lblValorCadastrado);
            this.gpbProdutoCadastrado.Controls.Add(this.lblNomeCadastrado);
            this.gpbProdutoCadastrado.Controls.Add(this.lblCodCadastrado);
            this.gpbProdutoCadastrado.Controls.Add(this.lblTotalCadastrado);
            this.gpbProdutoCadastrado.Controls.Add(this.lblValorTotalTitle);
            this.gpbProdutoCadastrado.Controls.Add(this.lblQtdTitle);
            this.gpbProdutoCadastrado.Controls.Add(this.lblDataSaidaTitle);
            this.gpbProdutoCadastrado.Controls.Add(this.lblDataEntraTitle);
            this.gpbProdutoCadastrado.Controls.Add(this.lblCodTitle);
            this.gpbProdutoCadastrado.Controls.Add(this.lblValorTitle);
            this.gpbProdutoCadastrado.Controls.Add(this.lblNomeTitle);
            this.gpbProdutoCadastrado.Location = new System.Drawing.Point(12, 230);
            this.gpbProdutoCadastrado.Name = "gpbProdutoCadastrado";
            this.gpbProdutoCadastrado.Size = new System.Drawing.Size(462, 294);
            this.gpbProdutoCadastrado.TabIndex = 10;
            this.gpbProdutoCadastrado.TabStop = false;
            this.gpbProdutoCadastrado.Text = "Dados do produto";
            // 
            // lblDataSaidaCadastrada
            // 
            this.lblDataSaidaCadastrada.AutoSize = true;
            this.lblDataSaidaCadastrada.Location = new System.Drawing.Point(204, 217);
            this.lblDataSaidaCadastrada.Name = "lblDataSaidaCadastrada";
            this.lblDataSaidaCadastrada.Size = new System.Drawing.Size(89, 20);
            this.lblDataSaidaCadastrada.TabIndex = 25;
            this.lblDataSaidaCadastrada.Text = "00/00/0000";
            // 
            // lblDataEntrCadastrada
            // 
            this.lblDataEntrCadastrada.AutoSize = true;
            this.lblDataEntrCadastrada.Location = new System.Drawing.Point(203, 179);
            this.lblDataEntrCadastrada.Name = "lblDataEntrCadastrada";
            this.lblDataEntrCadastrada.Size = new System.Drawing.Size(89, 20);
            this.lblDataEntrCadastrada.TabIndex = 24;
            this.lblDataEntrCadastrada.Text = "00/00/0000";
            // 
            // lblQtdCadastrada
            // 
            this.lblQtdCadastrada.AutoSize = true;
            this.lblQtdCadastrada.Location = new System.Drawing.Point(204, 142);
            this.lblQtdCadastrada.Name = "lblQtdCadastrada";
            this.lblQtdCadastrada.Size = new System.Drawing.Size(18, 20);
            this.lblQtdCadastrada.TabIndex = 23;
            this.lblQtdCadastrada.Text = "0";
            // 
            // lblValorCadastrado
            // 
            this.lblValorCadastrado.AutoSize = true;
            this.lblValorCadastrado.Location = new System.Drawing.Point(204, 108);
            this.lblValorCadastrado.Name = "lblValorCadastrado";
            this.lblValorCadastrado.Size = new System.Drawing.Size(40, 20);
            this.lblValorCadastrado.TabIndex = 22;
            this.lblValorCadastrado.Text = "0,00";
            // 
            // lblNomeCadastrado
            // 
            this.lblNomeCadastrado.AutoSize = true;
            this.lblNomeCadastrado.Location = new System.Drawing.Point(204, 73);
            this.lblNomeCadastrado.Name = "lblNomeCadastrado";
            this.lblNomeCadastrado.Size = new System.Drawing.Size(132, 20);
            this.lblNomeCadastrado.TabIndex = 21;
            this.lblNomeCadastrado.Text = "Nome do produto";
            // 
            // lblCodCadastrado
            // 
            this.lblCodCadastrado.AutoSize = true;
            this.lblCodCadastrado.Location = new System.Drawing.Point(204, 35);
            this.lblCodCadastrado.Name = "lblCodCadastrado";
            this.lblCodCadastrado.Size = new System.Drawing.Size(18, 20);
            this.lblCodCadastrado.TabIndex = 20;
            this.lblCodCadastrado.Text = "0";
            // 
            // lblTotalCadastrado
            // 
            this.lblTotalCadastrado.AutoSize = true;
            this.lblTotalCadastrado.Location = new System.Drawing.Point(204, 255);
            this.lblTotalCadastrado.Name = "lblTotalCadastrado";
            this.lblTotalCadastrado.Size = new System.Drawing.Size(40, 20);
            this.lblTotalCadastrado.TabIndex = 19;
            this.lblTotalCadastrado.Text = "0,00";
            // 
            // lblValorTotalTitle
            // 
            this.lblValorTotalTitle.AutoSize = true;
            this.lblValorTotalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotalTitle.Location = new System.Drawing.Point(13, 255);
            this.lblValorTotalTitle.Name = "lblValorTotalTitle";
            this.lblValorTotalTitle.Size = new System.Drawing.Size(174, 20);
            this.lblValorTotalTitle.TabIndex = 17;
            this.lblValorTotalTitle.Text = "Valor do estoque R$";
            // 
            // lblQtdTitle
            // 
            this.lblQtdTitle.AutoSize = true;
            this.lblQtdTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdTitle.Location = new System.Drawing.Point(14, 142);
            this.lblQtdTitle.Name = "lblQtdTitle";
            this.lblQtdTitle.Size = new System.Drawing.Size(102, 20);
            this.lblQtdTitle.TabIndex = 16;
            this.lblQtdTitle.Text = "Quantidade";
            // 
            // lblDataSaidaTitle
            // 
            this.lblDataSaidaTitle.AutoSize = true;
            this.lblDataSaidaTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataSaidaTitle.Location = new System.Drawing.Point(14, 217);
            this.lblDataSaidaTitle.Name = "lblDataSaidaTitle";
            this.lblDataSaidaTitle.Size = new System.Drawing.Size(121, 20);
            this.lblDataSaidaTitle.TabIndex = 15;
            this.lblDataSaidaTitle.Text = "Data de saída";
            // 
            // lblDataEntraTitle
            // 
            this.lblDataEntraTitle.AutoSize = true;
            this.lblDataEntraTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEntraTitle.Location = new System.Drawing.Point(13, 179);
            this.lblDataEntraTitle.Name = "lblDataEntraTitle";
            this.lblDataEntraTitle.Size = new System.Drawing.Size(140, 20);
            this.lblDataEntraTitle.TabIndex = 13;
            this.lblDataEntraTitle.Text = "Data de entrada";
            // 
            // lblCodTitle
            // 
            this.lblCodTitle.AutoSize = true;
            this.lblCodTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodTitle.Location = new System.Drawing.Point(14, 35);
            this.lblCodTitle.Name = "lblCodTitle";
            this.lblCodTitle.Size = new System.Drawing.Size(157, 20);
            this.lblCodTitle.TabIndex = 1;
            this.lblCodTitle.Text = "Codigo do produto";
            // 
            // lblValorTitle
            // 
            this.lblValorTitle.AutoSize = true;
            this.lblValorTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTitle.Location = new System.Drawing.Point(13, 108);
            this.lblValorTitle.Name = "lblValorTitle";
            this.lblValorTitle.Size = new System.Drawing.Size(144, 20);
            this.lblValorTitle.TabIndex = 5;
            this.lblValorTitle.Text = "Valor unitário R$";
            // 
            // lblNomeTitle
            // 
            this.lblNomeTitle.AutoSize = true;
            this.lblNomeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTitle.Location = new System.Drawing.Point(13, 73);
            this.lblNomeTitle.Name = "lblNomeTitle";
            this.lblNomeTitle.Size = new System.Drawing.Size(147, 20);
            this.lblNomeTitle.TabIndex = 3;
            this.lblNomeTitle.Text = "Nome do produto";
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 602);
            this.Controls.Add(this.gpbProdutoCadastrado);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.gpgDadosProdutos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.gpgDadosProdutos.ResumeLayout(false);
            this.gpgDadosProdutos.PerformLayout();
            this.gpbProdutoCadastrado.ResumeLayout(false);
            this.gpbProdutoCadastrado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCodigoProduto;
        private System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.GroupBox gpgDadosProdutos;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.GroupBox gpbProdutoCadastrado;
        private System.Windows.Forms.Label lblCodTitle;
        private System.Windows.Forms.Label lblValorTitle;
        private System.Windows.Forms.Label lblNomeTitle;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DateTimePicker dtpcSaida;
        private System.Windows.Forms.Label lblDataSaida;
        private System.Windows.Forms.DateTimePicker dtpcEntrada;
        private System.Windows.Forms.Label txtDataEntrada;
        private System.Windows.Forms.Label lblDataEntraTitle;
        private System.Windows.Forms.Label lblDataSaidaTitle;
        private System.Windows.Forms.Label lblQtdTitle;
        private System.Windows.Forms.Label lblValorTotalTitle;
        private System.Windows.Forms.Label lblTotalCadastrado;
        private System.Windows.Forms.Label lblDataSaidaCadastrada;
        private System.Windows.Forms.Label lblDataEntrCadastrada;
        private System.Windows.Forms.Label lblQtdCadastrada;
        private System.Windows.Forms.Label lblValorCadastrado;
        private System.Windows.Forms.Label lblNomeCadastrado;
        private System.Windows.Forms.Label lblCodCadastrado;
    }
}