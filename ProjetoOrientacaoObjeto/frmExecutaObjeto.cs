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
    public partial class frmExecutaObjeto : Form
    {
        public frmExecutaObjeto()
        {
            InitializeComponent();
        }

        private void btnClacular_Click(object sender, EventArgs e)
        {
            Calculadora calcular = new Calculadora();

            double num1, num2, resp = 0;
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            resp = calcular.somar(num1, num2);
            txtResposta.Text = resp.ToString();
        }
    }
}
