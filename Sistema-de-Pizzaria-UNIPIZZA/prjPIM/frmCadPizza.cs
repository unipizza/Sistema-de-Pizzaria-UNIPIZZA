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
    public partial class frmCadPizza : Form
    {
        SQLcommand sql = new SQLcommand();
        bool idpizzaisnull;

        public frmCadPizza()
        {
            InitializeComponent();
        }

        public void verificamatnagrid()
        {

        }
        public void varrercampos()
        {
            bool altera = false;
            txtIdMat.Text = "";
            txtIdPizza.Text = "";
            txtDescMat.Text = "";
            txtDescPizza.Text = "";
            txtValorPizza.Text = "";
            txtQtMat.Text = "";
            dgvMat.DataSource = null;
            chkAtivo.Checked = false;
        }

        private void txtIdPizza_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if((Keys)e.KeyChar == Keys.Enter)
            {
                
                sql.dtcadunidade.Clear();
            }
        }

        private void txtIdMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtQtMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtValorPizza_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            varrercampos();
        }
    }
}
