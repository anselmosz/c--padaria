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

            string codProd, nomeProd, dtEntrada, dtSaida;
            double valorProd, qtdProd;

            codProd = txtCodigoProduto.Text;
            nomeProd = txtNomeProduto.Text;
            dtEntrada = dtpcEntrada.Text;
            dtSaida = dtpcSaida.Text;

            valorProd = Convert.ToDouble(txtValor.Text);
            qtdProd = Convert.ToDouble(txtQuantidade.Text);

            // Envia os valores acima para os atributos da classe
            pdt.setCod(codProd);
            pdt.setNome(nomeProd);
            pdt.setDtEntrada(dtEntrada);
            pdt.setDtSaida(dtSaida);
            pdt.setValor(valorProd);
            pdt.setQtd(qtdProd);

            // Retorna o total em R$ do estoque de produtos 
            lblValorCadastrado.Text = pdt.Total(valorProd, qtdProd).ToString();
            

        }
    }
}
