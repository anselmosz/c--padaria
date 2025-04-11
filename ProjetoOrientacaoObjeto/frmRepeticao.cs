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
    public partial class frmRepeticao : Form
    {
        public frmRepeticao()
        {
            InitializeComponent();
        }

        public void InserirEstadoCbb()
        {
            if (txtInserirEstado.Text.Length >= 2)
            {
                cbbEstados.Items.Add(txtInserirEstado.Text);
                txtInserirEstado.Focus();
                txtInserirEstado.Clear();
            }
            else
            {
                MessageBox.Show("Digite um nome ou sigla válidos");
            }
        }
        public void InserirEstadoLtb()
        {
            if (cbbEstados.SelectedIndex != 0)
            { 
                ltbEstado.Items.Add(cbbEstados.SelectedItem);
                cbbEstados.SelectedIndex = 0;
            }
            else 
            {
                MessageBox.Show("Selecione um item válido");
                cbbEstados.SelectedIndex = 0;
                cbbEstados.Focus();
            }
        }

        private void btnCarregarEstado_Click(object sender, EventArgs e)
        {
            InserirEstadoCbb();
        }

        // Insere o valor dentro de txtInserirTexto na combo box quando o usuário aperta enter 
        private void txtInserirEstado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InserirEstadoCbb();
            }
        }

        // Limpa a textbox
        private void btnLimparTxtBox_Click(object sender, EventArgs e)
        {
            txtInserirEstado.Clear();
            txtInserirEstado.Focus();
        }

        // Limpa os items dentro da lista de estados
        private void btnLimparSeleção_Click(object sender, EventArgs e)
        {
            try
            {
                if (ltbEstado.SelectedIndex > 0)
                {
                    ltbEstado.Items.RemoveAt(ltbEstado.SelectedIndex);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um item da lista");
            }
        }

        private void btnLimparLista_Click(object sender, EventArgs e)
        {
            ltbEstado.Items.Clear();
        }

        private void btnCarregarNaLista_Click(object sender, EventArgs e)
        {
            InserirEstadoLtb();
        }
    }
}
