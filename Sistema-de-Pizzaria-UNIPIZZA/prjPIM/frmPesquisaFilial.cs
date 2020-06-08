using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MySql.Data.MySqlClient;
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
    public partial class frmPesquisaFilial : Form
    {
        public frmPesquisaFilial()
        {
            InitializeComponent();
        }
        private string _descricao;
        public string Descricao
        {
            get => _descricao;
            set => _descricao = value;
        }

        private string _id;
        public string Id
        {
            get => _id;
            set => _id = value;
        }

        private string _status;
        public string Status
        {
            get => _status;
            set => _status = value;
        }

        private void setdados()
        {
            Id = dgvFilial.CurrentRow.Cells["id_unidade"].Value.ToString();
            Descricao = dgvFilial.CurrentRow.Cells["descricao"].Value.ToString();
            Status = dgvFilial.CurrentRow.Cells["status"].Value.ToString();
            this.Close();
        }

        private void select()
        {
            DataTable dt = new DataTable();
            string cmd = "";

            if (rdbID.Checked)
            {
                MySqlConnection conn = connectionString.conn();
                if (rdbTodos.Checked)
                {
                    cmd = "select * from cadunidade where id_unidade = '" + txtFiltro.Text + "'";
                }
                else if (rdbAtivo.Checked)
                {
                    cmd = "select * from cadunidade where id_unidade = '" + txtFiltro.Text + "' and status = 'A'";
                }
                else if (rdbInativo.Checked)
                {
                    cmd = "select * from cadunidade where id_unidade = '" + txtFiltro.Text + "' and status = 'I'";
                }
                MySqlDataAdapter da = new MySqlDataAdapter(cmd, conn);
                da.Fill(dt);
                dgvFilial.DataSource = dt;
                conn.Close();
                cmd = "";
            }
            else
            {
                MySqlConnection conn = connectionString.conn();
                if (rdbTodos.Checked)
                {
                    cmd = "select * from cadunidade where descricao like '%" + txtFiltro.Text + "%'";
                }
                else if (rdbAtivo.Checked)
                {
                    cmd = "select * from cadunidade where descricao like '%" + txtFiltro.Text + "%' and status = 'A'";
                }
                else if (rdbInativo.Checked)
                {
                    cmd = "select * from cadunidade where descricao like '%" + txtFiltro.Text + "%' and status = 'I'";
                }
                MySqlDataAdapter da = new MySqlDataAdapter(cmd, conn);
                da.Fill(dt);
                dgvFilial.DataSource = dt;
                conn.Close();
                cmd = "";
            }
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rdbID.Checked)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }

            if ((Keys)e.KeyChar == Keys.Enter)
            {
                select();
            }
        }

        private void dgvFilial_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            setdados();
        }

        private void dgvFilial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            setdados();
        }

        private void frmPesquisaFilial_Load(object sender, EventArgs e)
        {
            select();
        }
    }
}
