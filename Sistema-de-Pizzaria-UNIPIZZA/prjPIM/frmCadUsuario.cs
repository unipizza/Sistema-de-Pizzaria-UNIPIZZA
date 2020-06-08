using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Engines;
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
    public partial class frmCadUsuario : Form
    {
        SQLcommand sql = new SQLcommand();
        string status = "";

        public frmCadUsuario()
        {
            InitializeComponent();
        }

        private void limpacampos()
        {
            txtIdFilial.Text = "";
            txtIdUsuario.Text = "";
            txtDescFilial.Text = "";
            txtNomeUsuario.Text = "";
            txtUser.Text = "";
            txtSenha.Text = "";
            chkAtivo.Checked = false;
        }

        private void validacampos()
        {
            if (txtNomeUsuario.Text != "" && txtUser.Text != "" && txtSenha.Text != "" && txtDescFilial.Text != "" && txtIdFilial.Text != "")
            {
                btnGravar.Enabled = true;
                if(txtIdUsuario.Text != "")
                {
                    btnExcluir.Enabled = true;
                }
            }
            else
            {
                btnGravar.Enabled = false;
                btnExcluir.Enabled = false;
            }
        }

        private void txtIdUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if ((Keys)e.KeyChar == Keys.Enter)
            {

            }
        }

        private void txtIdFilial_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                MySqlConnection conn = connectionString.conn();
                sql.cadunidadeselect_porID(txtIdFilial.Text);
                if (sql.dtcadunidade.Rows.Count != 0)
                {
                    if (sql.dtcadunidade.Rows[0]["status"].ToString() == "A")
                    {
                        txtDescFilial.Text = sql.dtcadunidade.Rows[0]["descricao"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Filial inativa!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDescFilial.Text = "";
                        txtIdFilial.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDescFilial.Text = "";
                    txtIdFilial.Text = "";
                }
                sql.dtcadunidade.Clear();
            }
        }

        private void btnPesqFilial_Click(object sender, EventArgs e)
        {
            frmPesquisaFilial searchUnidade = new frmPesquisaFilial();
            searchUnidade.ShowDialog();

            if (searchUnidade.Status == "A")
            {
                txtIdFilial.Text = searchUnidade.Id;
                txtDescFilial.Text = searchUnidade.Descricao;
            }
            else
            {
                MessageBox.Show("Filial inativa!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescFilial.Text = "";
                txtIdFilial.Text = "";
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIdUsuario_TextChanged(object sender, EventArgs e)
        {
            validacampos();
        }

        private void txtNomeUsuario_TextChanged(object sender, EventArgs e)
        {
            validacampos();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            validacampos();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            validacampos();
        }

        private void txtIdFilial_TextChanged(object sender, EventArgs e)
        {
            validacampos();
        }

        private void txtDescFilial_TextChanged(object sender, EventArgs e)
        {
            validacampos();
        }
    }
}
