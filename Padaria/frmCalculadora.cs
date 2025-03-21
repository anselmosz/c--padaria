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
            /* Declarando uma variável no C#
             *  tipo e nome
             */

            int valor1, valor4, resp;
            double valor2; 
            float valor3;
            bool flag;
            string name;
            char sexo;

            // Inicializando as variáveis

            valor1 = 10;
            valor4 = 20;
            resp = valor1 + valor4;
        }
    }
}
