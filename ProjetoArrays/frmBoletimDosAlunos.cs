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
    public partial class frmBoletimDosAlunos : Form
    {
        public frmBoletimDosAlunos()
        {
            InitializeComponent();
        }

        int a, i, j = 0;
        string[,] alunos = new string[3, 3];
        double[,] nota1 = new double[3, 3];
        double[,] nota2 = new double[3, 3];
        double[,] nota3 = new double[3, 3];
        double[,] nota4 = new double[3, 3];

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    alunos[i, j] = txtNomeAluno.Text;
                }
            }
            ltbAlunos.Items.Add(alunos[i, j]);
            ltbAlunos.Items.Add("------");
            txtNomeAluno.Clear();
            txtNomeAluno.Focus();
        }
    }
}
