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
        }

        Random rnd = new Random();

        public void metodo()
        {

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {   
            try
            {
                int valor = int.Parse(txtNumeroInput.Text);
                int num = rnd.Next(valor);
                ltbNumerosGerados.Items.Add(num);
            }
            catch (Exception)
            {
                MessageBox.Show("error")
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ltbNumerosGerados.Items.Clear();
            txtNumeroInput.Clear(); 
            txtNumeroInput.Focus(); 
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
