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
    public partial class frmOuvidoria : Form
    {
        public frmOuvidoria()
        {
            InitializeComponent();
        }

        private void txtElogio_TextChanged(object sender, EventArgs e)
        {
            this.btnApagarElogio.Enabled = true;
            this.btnElogio.Enabled = true;
        }

        private void btnApagarElogio_Click(object sender, EventArgs e)
        {
            txtElogio.Clear();
        }

        private void btnElogio_Click(object sender, EventArgs e)
        {

        }

        private void txtReclama_TextChanged(object sender, EventArgs e)
        {
            this.btnApagarReclama.Enabled = true;
            this.btnReclama.Enabled = true;
        }

        private void btnApagarReclama_Click(object sender, EventArgs e)
        {
            txtReclama.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
