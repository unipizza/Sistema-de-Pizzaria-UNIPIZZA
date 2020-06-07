using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjPIM
{
    public partial class frmCadFilial : Form
    {
        SQLcommand sql = new SQLcommand();
        string status = "";
        public frmCadFilial()
        {
            InitializeComponent();
        }

        public void validacampos()
        {
            if (txtFilialDesc.Text == "")
            {
                btnGravar.Enabled = false;
            }
            else
            {
                btnGravar.Enabled = true;
            }

            if (txtIdFilial.Text == "")
            {
                btnExcluir.Enabled = false;
            }
            else
            {
                btnExcluir.Enabled = true;
            }
        }

        private void txtIdFilial_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                try
                {
                    MySqlConnection conn = connectionString.conn();
                    MySqlDataAdapter da = new MySqlDataAdapter("select * from cadunidade where id_unidade = '" + txtIdFilial.Text + "'", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count != 0)
                    {
                        txtFilialDesc.Text = dt.Rows[0]["descricao"].ToString();
                        if (dt.Rows[0]["status"].ToString() == "A")
                        {
                            chkAtivo.Checked = true;
                        }
                        else
                        {
                            chkAtivo.Checked = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Registro não encontrado!", "Atenção", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtFilialDesc_TextChanged(object sender, EventArgs e)
        {
            validacampos();
        }

        private void txtIdFilial_TextChanged(object sender, EventArgs e)
        {
            validacampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtIdFilial.Text = "";
            txtFilialDesc.Text = "";
            chkAtivo.Checked = false;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (chkAtivo.Checked == true)
            {
                status = "A";
            }
            else if (chkAtivo.Checked == false)
            {
                status = "I";
            }
            
            if (txtIdFilial.Text == "")
            {
                try
                {
                    sql.cadunidadeinsert(txtFilialDesc.Text, status);
                    MessageBox.Show("Registro incluído!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                sql.cadunidadeselect_porID(txtIdFilial.Text);
                if (sql.dtcadunidade.Rows.Count != 0)
                {
                    if (MessageBox.Show("Registro existente!  Deseja alterar?\n\n\n" +
                        " Valor antigo:  " + sql.dtcadunidade.Rows[0]["id_unidade"].ToString() + " - " +
                          sql.dtcadunidade.Rows[0]["descricao"].ToString()+ "\n\n" +
                          "    Valor novo:  "+ txtIdFilial.Text + " - " + txtFilialDesc.Text,
                          "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        try
                        {
                            sql.cadunidadeupdate(txtFilialDesc.Text, status, txtIdFilial.Text);
                            MessageBox.Show("Registro alterado!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }            
                    }
                }
                else
                {
                    try
                    {
                        sql.cadunidadeinsert(txtFilialDesc.Text, status);
                        MessageBox.Show("Registro incluído!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaFilial search = new frmPesquisaFilial();
            search.ShowDialog();
            txtIdFilial.Text = search.Id;
            txtFilialDesc.Text = search.Descricao;
        }
    }
}
