using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoOrientacaoObjeto
{
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Produtos pdt = new Produtos();

            try
            {
                string codProd, nomeProd, dtEntrada, dtSaida;
                double valorProd, qtdProd, total = 0;

                codProd = txtCodigoProduto.Text;
                nomeProd = txtNomeProduto.Text;
                dtEntrada = dtpcEntrada.Text;
                dtSaida = dtpcSaida.Text;

                valorProd = Convert.ToDouble(txtValor.Text);
                qtdProd = Convert.ToDouble(txtQuantidade.Text);
                total = pdt.Total(valorProd, qtdProd);

                // Envia os valores acima para os atributos da classe
                pdt.setCod(codProd);
                pdt.setNome(nomeProd);
                pdt.setDtEntrada(dtEntrada);
                pdt.setDtSaida(dtSaida);
                pdt.setValor(valorProd);
                pdt.setQtd(qtdProd);

                // Retorna o total em R$ do estoque de produtos 

                lblCodCadastrado.Text = codProd;
                lblNomeCadastrado.Text = nomeProd;
                lblValorCadastrado.Text = valorProd.ToString();
                lblQtdCadastrada.Text = qtdProd.ToString();
                lblDataEntrCadastrada.Text = dtEntrada;
                lblDataSaidaCadastrada.Text = dtSaida;
                lblTotalCadastrado.Text = total.ToString();

                txtCodigoProduto.Clear();
                txtNomeProduto.Clear();
                txtValor.Clear();
                txtQuantidade.Clear();
            }
            catch (Exception) 
            {
                MessageBox.Show("Insira valores válidos!", 
                    "Mensagem do sistema", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error, 
                    MessageBoxDefaultButton.Button1);

                txtNomeProduto.Clear();
                txtNomeProduto.Focus();
                txtCodigoProduto.Clear();
                txtValor.Clear();
                txtQuantidade.Clear();

                lblCodCadastrado.Text = "0";
                lblNomeCadastrado.Text = "Nome do produto";
                lblValorCadastrado.Text = "0,00";
                lblQtdCadastrada.Text = "0";
                lblDataEntrCadastrada.Text = "00/00/0000";
                lblDataSaidaCadastrada.Text = "00/00/0000";
                lblTotalCadastrado.Text = "0,00";
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeProduto.Clear();
            txtNomeProduto.Focus();
            txtCodigoProduto.Clear();
            txtValor.Clear();
            txtQuantidade.Clear();

            lblCodCadastrado.Text = "0";
            lblNomeCadastrado.Text = "Nome do produto";
            lblValorCadastrado.Text = "0,00";
            lblQtdCadastrada.Text = "0";
            lblDataEntrCadastrada.Text = "00/00/0000";
            lblDataSaidaCadastrada.Text = "00/00/0000";
            lblTotalCadastrado.Text = "0,00";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
