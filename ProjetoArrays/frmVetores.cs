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

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            string[] nomes = new string[10];

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



            ltbNomes.Items.Clear();

            for (int i = 0; i < 10; i++)
            {
                ltbNomes.Items.Add(nomes[i]);
            }
        }
    }
}
