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
    public partial class frmRelFaturamento : Form
    {
        public frmRelFaturamento()
        {
            InitializeComponent();
        }

        private void frmFaturamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dtRelatorios.cadpedido'. Você pode movê-la ou removê-la conforme necessário.
            this.cadpedidoTableAdapter.Fill(this.dtRelatorios.cadpedido);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
