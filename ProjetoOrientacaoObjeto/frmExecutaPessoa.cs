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
    public partial class frmExecutaPessoa : Form
    {
        public frmExecutaPessoa()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Pessoa ps = new Pessoa();

            try
            {                
                ps.setNome(txtNome.Text);
                ps.setEmail(txtEmail.Text);
                ps.setCPF(mskCPF.Text);
                ps.setTelefone(mskTelefone.Text);
                ps.setIdade(Convert.ToInt32(txtIdade.Text));

                lblNomeRegistrado.Text = ps.getNome();
                lblEmailRegistrado.Text = ps.getEmail();
                lblCpfRegistrado.Text = ps.getCPF();
                lblTelefoneRegistrado.Text = ps.getTelefone();
                lblIdadeRegistrada.Text = ps.getIdade().ToString();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Insira valores válidos!",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1
                );

                txtNome.Clear();
                txtNome.Focus();
                txtEmail.Clear();
                txtIdade.Clear();
                mskCPF.Clear();
                mskTelefone.Clear();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtNome.Focus();
            txtEmail.Clear();
            txtIdade.Clear();
            mskCPF.Clear();
            mskTelefone.Clear();

            lblNomeRegistrado.Text = "Nome";
            lblEmailRegistrado.Text = "Email";
            lblCpfRegistrado.Text = "CPF";
            lblTelefoneRegistrado.Text = "Telefone";
            lblIdadeRegistrada.Text = "Idade";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
