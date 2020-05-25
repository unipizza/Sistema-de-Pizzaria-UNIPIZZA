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
    public partial class frmPrincipal : Form
    {
        public string acao;
        public frmPrincipal()
        {
            InitializeComponent();
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            else
            {
                if(MessageBox.Show("Deseja realmente sair do sistema?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void PizzasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadPizza frmpizza = new frmCadPizza();
            frmpizza.MdiParent = this;
            frmpizza.Show();
        }

        private void matériaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadMat frmmat = new frmCadMat();
            frmmat.MdiParent = this;
            frmmat.Show();
        }

        private void menuBebidas_Click(object sender, EventArgs e)
        {
            frmCadProdutos frmbeb = new frmCadProdutos();
            frmbeb.MdiParent = this;
            frmbeb.Show();
        }

        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            frmCadUsuario frmusu = new frmCadUsuario();
            frmusu.MdiParent = this;
            frmusu.Show();
        }

        private void menuFilial_Click(object sender, EventArgs e)
        {
            frmCadFilial frmfilial = new frmCadFilial();
            frmfilial.MdiParent = this;
            frmfilial.Show();
        }

        private void menuPedidos_Click(object sender, EventArgs e)
        {
            frmPedidos frmped = new frmPedidos();
            frmped.MdiParent = this;
            frmped.Show();
        }

        private void menuEstoque_Click(object sender, EventArgs e)
        {
            frmEstoque frmest = new frmEstoque();
            frmest.MdiParent = this;
            frmest.Show();
        }

        private void menuControleAcc_Click(object sender, EventArgs e)
        {
            frmPermissoes frmperm = new frmPermissoes();
            frmperm.MdiParent = this;
            frmperm.Show();
        }

        public void BtnNovo_Click(object sender, EventArgs e)
        {
            
        }

        private void ouvidoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOuvidoria frmovd = new frmOuvidoria();
            frmovd.MdiParent = this;
            frmovd.Show();
        }
    }
}
