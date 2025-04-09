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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpbProdutoCadastrado = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDataEntrada = new System.Windows.Forms.Label();
            this.dtpcEntrada = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpcSaida = new System.Windows.Forms.DateTimePicker();
            this.lblDataSaida = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalCadastrado = new System.Windows.Forms.Label();
            this.lblCodCadastrado = new System.Windows.Forms.Label();
            this.lblNomeCadastrado = new System.Windows.Forms.Label();
            this.lblValorCadastrado = new System.Windows.Forms.Label();
            this.lblQtdCadastrada = new System.Windows.Forms.Label();
            this.lblDataEntrCadastrada = new System.Windows.Forms.Label();
            this.lblDataSaidaCadastrada = new System.Windows.Forms.Label();
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
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(364, 543);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 45);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
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
            this.gpbProdutoCadastrado.Controls.Add(this.label7);
            this.gpbProdutoCadastrado.Controls.Add(this.label6);
            this.gpbProdutoCadastrado.Controls.Add(this.label5);
            this.gpbProdutoCadastrado.Controls.Add(this.label2);
            this.gpbProdutoCadastrado.Controls.Add(this.label1);
            this.gpbProdutoCadastrado.Controls.Add(this.label3);
            this.gpbProdutoCadastrado.Controls.Add(this.label4);
            this.gpbProdutoCadastrado.Location = new System.Drawing.Point(12, 230);
            this.gpbProdutoCadastrado.Name = "gpbProdutoCadastrado";
            this.gpbProdutoCadastrado.Size = new System.Drawing.Size(462, 294);
            this.gpbProdutoCadastrado.TabIndex = 10;
            this.gpbProdutoCadastrado.TabStop = false;
            this.gpbProdutoCadastrado.Text = "Dados do produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo do produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor unitário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome do produto";
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
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(274, 93);
            this.txtQuantidade.MaxLength = 100;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(64, 26);
            this.txtQuantidade.TabIndex = 4;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(74, 93);
            this.txtValor.MaxLength = 20;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(96, 26);
            this.txtValor.TabIndex = 3;
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
            // dtpcEntrada
            // 
            this.dtpcEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpcEntrada.Location = new System.Drawing.Point(153, 125);
            this.dtpcEntrada.Name = "dtpcEntrada";
            this.dtpcEntrada.Size = new System.Drawing.Size(124, 26);
            this.dtpcEntrada.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Data de entrada";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Data de saída";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Quantidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Valor do estoque";
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
            // lblCodCadastrado
            // 
            this.lblCodCadastrado.AutoSize = true;
            this.lblCodCadastrado.Location = new System.Drawing.Point(204, 35);
            this.lblCodCadastrado.Name = "lblCodCadastrado";
            this.lblCodCadastrado.Size = new System.Drawing.Size(18, 20);
            this.lblCodCadastrado.TabIndex = 20;
            this.lblCodCadastrado.Text = "0";
            // 
            // lblNomeCadastrado
            // 
            this.lblNomeCadastrado.AutoSize = true;
            this.lblNomeCadastrado.Location = new System.Drawing.Point(204, 73);
            this.lblNomeCadastrado.Name = "lblNomeCadastrado";
            this.lblNomeCadastrado.Size = new System.Drawing.Size(64, 20);
            this.lblNomeCadastrado.TabIndex = 21;
            this.lblNomeCadastrado.Text = "produto";
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
            // lblQtdCadastrada
            // 
            this.lblQtdCadastrada.AutoSize = true;
            this.lblQtdCadastrada.Location = new System.Drawing.Point(204, 142);
            this.lblQtdCadastrada.Name = "lblQtdCadastrada";
            this.lblQtdCadastrada.Size = new System.Drawing.Size(18, 20);
            this.lblQtdCadastrada.TabIndex = 23;
            this.lblQtdCadastrada.Text = "0";
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
            // lblDataSaidaCadastrada
            // 
            this.lblDataSaidaCadastrada.AutoSize = true;
            this.lblDataSaidaCadastrada.Location = new System.Drawing.Point(204, 217);
            this.lblDataSaidaCadastrada.Name = "lblDataSaidaCadastrada";
            this.lblDataSaidaCadastrada.Size = new System.Drawing.Size(89, 20);
            this.lblDataSaidaCadastrada.TabIndex = 25;
            this.lblDataSaidaCadastrada.Text = "00/00/0000";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DateTimePicker dtpcSaida;
        private System.Windows.Forms.Label lblDataSaida;
        private System.Windows.Forms.DateTimePicker dtpcEntrada;
        private System.Windows.Forms.Label txtDataEntrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalCadastrado;
        private System.Windows.Forms.Label lblDataSaidaCadastrada;
        private System.Windows.Forms.Label lblDataEntrCadastrada;
        private System.Windows.Forms.Label lblQtdCadastrada;
        private System.Windows.Forms.Label lblValorCadastrado;
        private System.Windows.Forms.Label lblNomeCadastrado;
        private System.Windows.Forms.Label lblCodCadastrado;
    }
}