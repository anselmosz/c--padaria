using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
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

        public void limparItems()
        {
            txtNomeAluno.Clear();
            txtNomeAluno.Focus();

            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNota4.Clear();
        }
        public void limparNotas()
        {
            txtNota1.Clear();
            txtNota1.Focus();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNota4.Clear();
        }

        int a, l, c = 0;
        string[,] alunos = new string[3, 3];
        double[,] nota1 = new double[3, 3];
        double[,] nota2 = new double[3, 3];
        double[,] nota3 = new double[3, 3];
        double[,] nota4 = new double[3, 3];


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                alunos[l, c] = txtNomeAluno.Text;
                nota1[l, c] = int.Parse(txtNota1.Text);
                nota2[l, c] = int.Parse(txtNota2.Text);
                nota3[l, c] = int.Parse(txtNota3.Text);
                nota4[l, c] = int.Parse(txtNota4.Text);

                ltbAlunos.Items.Add(alunos[l, c]);

                c++;

                if (c == 3)
                {
                    l++;
                    c = 0;
                }
                a++;

                limparItems();
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha todos os campos!");

                if (a == 9)
                {
                    MessageBox.Show("Não é possível inserir mais alunos na matriz!");
                }

                if (int.Parse(txtNota1.Text) < 0 || int.Parse(txtNota1.Text) > 10 ||
                    int.Parse(txtNota1.Text) < 0 || nota2[l, c] > 10 ||
                    int.Parse(txtNota1.Text) < 0 || nota3[l, c] > 10 ||
                    int.Parse(txtNota1.Text) < 0 || nota4[l, c] > 10)
                {
                    MessageBox.Show("Valores inválidos!");
                    limparNotas();
                }
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparItems();
        }

        private void btnGerarResumo_Click(object sender, EventArgs e)
        {
            double media = (nota1[l, c] + nota2[l, c] + nota3[l, c] + nota4[l, c]) / 4;
            
            //if ()
        }
    }
}
