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
        }

        public void carregaVetor()
        {
            int listaTamanho = int.Parse(txtTamanho.Text);

            string[] nomes = new string[listaTamanho];

            for (int i = 0; i < nomes.Length; i++)
            {

            }

            //nomes[0] = "Eudardo";
            //nomes[1] = "Giovanne";
            //nomes[2] = "Larissa";
            //nomes[3] = "Matheus";
            //nomes[4] = "Hugo";
            //nomes[5] = "Edna";
            //nomes[6] = "Raphaela";
            //nomes[7] = "João";
            //nomes[8] = "Dharla";
            //nomes[9] = "Pedro";

        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            carregaVetor();
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
