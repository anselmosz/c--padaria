using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padaria
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {  

            Calculadora2 calc = new Calculadora2();

            // Declaração das variáveis
            double n1, n2, resp = 0;

            try
            {
            // inicialização das variáveis com valores das caixas de texto
            n1 = Convert.ToDouble(txtbNum1.Text);
            n2 = Convert.ToDouble(txtbNum2.Text);
                if (rdbtnDividir.Checked == false && rdbtnMultiplicar.Checked == false && rdbtnSoma.Checked == false && rdbtnSubtrair.Checked == false) {
                    MessageBox.Show("Selecione uma operação!",
                        "Mensagem do sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                } else {
                    if (rdbtnSoma.Checked)
                    {
                        resp = calc.somar(n1, n2);
                    }
                    if (rdbtnSubtrair.Checked)
                    {
                        resp = calc.somar(n1, n2);
                    }
                    if (rdbtnMultiplicar.Checked)
                    {
                        resp = calc.somar(n1, n2);
                    }
                    if (rdbtnDividir.Checked)
                    {
                        if (n2 > 0)
                        {
                            resp = calc.somar(n1, n2);
                        }
                        else
                        {
                            MessageBox.Show("Impossível realizar divisão por 0",
                                "Mensagem do sistema",
                                MessageBoxButtons.YesNoCancel,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button3);
                            txtbResposta.Clear();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Insira valores válidos!",
                        "Mensagem do sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                txtbNum1.Clear();
                txtbNum1.Focus();
                txtbNum2.Clear();
                txtbResposta.Clear();
            }
            txtbResposta.Text = resp.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Altera a seleção dos radio buttons para false
            rdbtnSoma.Checked = false;
            rdbtnSubtrair.Checked = false;
            rdbtnMultiplicar.Checked = false;
            rdbtnDividir.Checked = false;

            // Limpa os valores dentro das caixas de texto
            txtbNum1.Clear();
            txtbNum2.Clear();
            txtbResposta.Clear();

            txtbNum1.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
