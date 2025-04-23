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
    public partial class frmMatriz : Form
    {
        public frmMatriz()
        {
            InitializeComponent();
            int a = int.Parse(txtNome.Text);
        }
        static int a;
        int i = 0;
        string[,] numeros = new string[2, 2];

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            numeros[a, a] = txtNome.Text;
            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    ltbMatriz.Items.Add(numeros[i,j]);
                }
            }
            ltbMatriz.Items.Add("------");
        }
    }
}
