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

        public void InserirEstado()
        {
            cbbWishlist.Items.Add(txtInserirEstado.Text);
            txtInserirEstado.Clear();
            txtInserirEstado.Focus();
        }

        private void btnCarregarEstado_Click(object sender, EventArgs e)
        {
            InserirEstado();
        }

        private void txtInserirEstado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InserirEstado();
            }
        }

        private void btnWishlist_Click(object sender, EventArgs e)
        {
            ltbEstado.Items.Add(cbbWishlist.SelectedIndex);
        }
    }
}
