using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjPIM
{
    public partial class frmPedidos : Form
    {
        public frmPedidos()
        {
            InitializeComponent();
            cmbCategoria.SelectedIndex = 0;
            txtData.Text = DateTime.Now.ToString();
        }

        private void chkDelivery_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDelivery.Checked)
            {
                txtEndRes.Enabled = true;
                txtEndRes.Text = "";
                txtTaxa.Enabled = true;
                txtTaxa.Text = "0.00";
            }
            else
            {
                txtEndRes.Enabled = false;
                txtEndRes.Text = "RETIRADA BALCAO";
                txtTaxa.Enabled = false;
                txtTaxa.Text = "0.00";
            }
        }

        private void txtIdPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtIdFilial_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtIdItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtQtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
