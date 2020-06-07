using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jdforsythe.MySQLConnection;
using MySql.Data.MySqlClient;

namespace prjPIM
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
       
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            string sqlCmd = "SELECT * FROM cadusuario WHERE username='" + txtLogin.Text + "'AND senha='" + txtSenha.Text + "'";

            MySqlConnection conn = connectionString.conn();
            MySqlCommand cmd = new MySqlCommand(sqlCmd, conn);

            try
            {
                MySqlDataReader dr = cmd.ExecuteReader();


                if (dr.Read())
                {
                    frmPrincipal novo = new frmPrincipal();
                    novo.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha incorretos.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                conn.Close();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
