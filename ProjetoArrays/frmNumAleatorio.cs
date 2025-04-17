using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoArrays
{
    public partial class frmNumAleatorio : Form
    {
        public frmNumAleatorio()
        {
            InitializeComponent();
            disableTxtBoxes();
        }

        Random rnd = new Random();
         

        public void disableTxtBoxes()
        {
            txtNumeroInput.Enabled = false;
            txtTamanho.Enabled = false; 
            txtNumMinInput.Enabled = false;
            txtNumMaxInput.Enabled = false;
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {   
            if (rdInteirosRnd.Checked)
            {
                try
                {
                    int valor = int.Parse(txtNumeroInput.Text);
                    ltbNumerosGerados.Items.Add(rnd.Next(valor));
                    txtNumeroInput.Focus();
                }
                catch (Exception)
                {
                    MessageBox.Show("Favor inserir um número inteiro");
                    txtNumeroInput.Clear();
                    txtNumeroInput.Focus();
                }
            }

            if (rdVariosInteirosRnd.Checked)
            {
                try
                {
                    int valor = int.Parse(txtNumeroInput.Text);

                    for (int i = 0; i < valor; i++)
                    {
                        ltbNumerosGerados.Items.Add(rnd.Next(valor));
                    }
                    
                    txtNumeroInput.Focus();
                }
                catch (Exception)
                {
                    MessageBox.Show("Favor inserir um número inteiro");
                    txtNumeroInput.Clear();
                    txtNumeroInput.Focus();
                }
            }

            if (rdInteirosRndIntervalos.Checked)
            {
                try
                {
                    int valor1 = int.Parse(txtNumMinInput.Text);
                    int valor2 = int.Parse(txtNumMaxInput.Text);
                    ltbNumerosGerados.Items.Add(rnd.Next(valor1, valor2));
                    txtNumMinInput.Focus();
                }
                catch (Exception)
                {
                    MessageBox.Show("Favor inserir um interalo de números inteiros");
                    txtNumMinInput.Clear();
                    txtNumMaxInput.Clear();
                    txtNumMinInput.Focus();
                }
            }

            if (rdFloatRnd.Checked)
            {
                try
                {
                    double num = rnd.NextDouble();
                    ltbNumerosGerados.Items.Add(num);
                }
                catch (Exception)
                {
                    MessageBox.Show("Favor selecionar");
                }
            }

            if (rdRepeticao.Checked)
            {
                try
                {
                    int valor = int.Parse(txtNumeroInput.Text);
                    int tamanho = int.Parse(txtTamanho.Text);
                    for (int i = 0; i < tamanho; i++)
                    {
                        ltbNumerosGerados.Items.Add(rnd.Next(valor));
                    }
                    ltbNumerosGerados.Items.Add("------");
                }
                catch (Exception)
                {
                    MessageBox.Show("Favor inserir um interalo de números inteiros");
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ltbNumerosGerados.Items.Clear();
            txtTamanho.Clear();
            txtNumeroInput.Clear();
            txtNumMinInput.Clear();
            txtNumMaxInput.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdInteirosRnd_CheckedChanged(object sender, EventArgs e)
        {
            txtNumeroInput.Enabled = true;
            txtNumeroInput.Focus();
            txtNumMinInput.Enabled = false;
            txtNumMaxInput.Enabled = false;
        }

        private void rdVariosInteirosRnd_CheckedChanged(object sender, EventArgs e)
        {
            txtNumeroInput.Enabled = true;
            txtNumeroInput.Focus();
            txtNumMinInput.Enabled = false;
            txtNumMaxInput.Enabled = false;
        }

        private void rdInteirosRndIntervalos_CheckedChanged(object sender, EventArgs e)
        {
            txtNumeroInput.Enabled = false;
            txtNumMinInput.Enabled = true;
            txtNumMaxInput.Enabled = true;
            txtNumMinInput.Focus();
        }

        private void rdRepeticao_CheckedChanged(object sender, EventArgs e)
        {
            txtTamanho.Enabled = true;
            txtTamanho.Focus();
            txtNumeroInput.Enabled = true;
            txtNumMinInput.Enabled = false;
            txtNumMaxInput.Enabled = false;
        }
    }
}
