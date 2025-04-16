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
    public partial class frmVetores : Form
    {
        public frmVetores()
        {
            InitializeComponent();
            int a = int.Parse(txtTamanho.Text);
        }
            static int a;
            int i = 0;
            string[] nomes = new string[a];

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            //a = int.Parse(txtTamanho.Text);

            nomes[a] = txtNome.Text;
            txtNome.Clear();
            txtNome.Focus();

            if (a == 4)
            {
                for (int i = 0; i < nomes.Length; i++)
                {
                    ltbNomes.Items.Add(nomes[i]);
                }
            }
            a++;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                ltbNomes.Items.RemoveAt(ltbNomes.SelectedIndex);
            }
            catch (Exception) 
            {
                MessageBox.Show("Nenhum item foi selecionado!","Mensagem do sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
