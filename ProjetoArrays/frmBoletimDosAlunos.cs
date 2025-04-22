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
            int a = int.Parse(txtQtdAlunos.Text);
        }

        static int a;
        int i = 0;
        string[,] alunos = new string[a,a];
        double[,] nota2 = new double[a,a];
        double[,] nota3 = new double[a,a];
        double[,] nota4 = new double[a,a];

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            alunos[a,a] = txtNomeAluno.Text;
            txtNomeAluno.Clear();
            txtNomeAluno.Focus();

            if (a == 10)
            {
                for (int i = 0; i < alunos.Length; i++)
                {
                    ltbAlunos.Items.Add(alunos[i,i]);
                }
            }
            a++;
        }
    }
}
