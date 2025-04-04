using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class frmCalculaIMC : Form
    {
        public frmCalculaIMC()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double idade, peso, altura, imc = 0;

            try
            {
                idade = Convert.ToDouble(txtIdade.Text);
                peso = Convert.ToDouble(txtPeso.Text);
                altura = Convert.ToDouble(txtAltura.Text);

                imc = peso / (altura * altura);

                if (rdbFem.Checked)
                {
                    if (imc < 19.1)
                    {
                        txtImcCategoria.Text = "Abaixo do peso";
                    }
                    if (imc >= 19.1 && imc <= 25.8) 
                    {
                        txtImcCategoria.Text = "Peso ideal";
                    }
                    if (imc >= 25.9 && imc <= 27.3)
                    {
                        txtImcCategoria.Text = "Pouco acima do peso";
                    }
                    if (imc >= 27.4 && imc <= 32.3)
                    {
                        txtImcCategoria.Text = "Acima do peso";
                    }
                    if (imc >= 32.4)
                    {
                        txtImcCategoria.Text = "Obesidade";
                    }
                }
                else if (rdbMasc.Checked)
                {
                    if (imc < 20.7)
                    {
                        txtImcCategoria.Text = "Abaixo do peso";
                    }
                    if (imc >= 20.7 && imc <= 26.4)
                    {
                        txtImcCategoria.Text = "Peso ideal";
                    }
                    if (imc >= 26.5 && imc <= 27.8)
                    {
                        txtImcCategoria.Text = "Pouco acima do peso";
                    }
                    if (imc >= 27.9 && imc <= 31.1)
                    {
                        txtImcCategoria.Text = "Acima do peso";
                    }
                    if (imc >= 31.2)
                    {
                        txtImcCategoria.Text = "Obesidade";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Insira valores válidos!",
                    "Mensagem do Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                gpbSexo.Focus();
                txtIdade.Clear();
                txtPeso.Clear();
                txtAltura.Clear();
                txtImcResultado.Clear();
                txtImcCategoria.Clear();
                rdbFem.Checked = false;
                rdbMasc.Checked = false;
            }

            txtImcResultado.Text = Convert.ToString(imc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gpbSexo.Focus();
            txtIdade.Clear();
            txtPeso.Clear();
            txtAltura.Clear();
            txtImcResultado.Clear();
            txtImcCategoria.Clear();
            rdbFem.Checked = false;
            rdbMasc.Checked = false;
        }
    }
}
