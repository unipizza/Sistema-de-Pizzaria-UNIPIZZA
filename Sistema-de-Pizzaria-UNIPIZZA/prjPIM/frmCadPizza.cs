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
                sql.dtpizza_porID.Clear();
                sql.selectpizza_porID(int.Parse(txtIdPizza.Text));
                if(sql.dtpizza_porID.Rows.Count != 0)
                {
                    txtDescPizza.Text = sql.dtpizza_porID.Rows[0]["cadprod_desc"].ToString();
                    txtValorPizza.Text = sql.dtpizza_porID.Rows[0]["cadprod_valor"].ToString();
                    string ativo = sql.dtpizza_porID.Rows[0]["cadprod_status"].ToString();
                    if (ativo == "ATIVO")
                    {
                        chkAtivo.Checked = true;
                    }
                    else
                    {
                        chkAtivo.Checked = false;
                    }
                    sql.dtmatprima_porIDPIZZA.Clear();
                    sql.selectmatprima_porDESC(int.Parse(txtIdPizza.Text));
                    dgvMat.DataSource = sql.dtmatprima_porIDPIZZA;
                }
                else
                {
                    MessageBox.Show("Registro não encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    varrercampos();
                }
                sql.dtpizza_porID.Clear();
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
            sql.dtpizza_porID.Clear();
            sql.selectpizza_porID(int.Parse(txtIdPizza.Text));
            if(sql.dtpizza_porID.Rows.Count != 0)
            {
                MessageBox.Show(sql.dtpizza_porID.Rows[0]["cadprod_desc"].ToString());
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            varrercampos();
        }
    }
}
