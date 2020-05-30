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
    public partial class frmRelProdutos : Form
    {
        public frmRelProdutos()
        {
            InitializeComponent();
        }

        private void frmRelProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dtRelatorios.cadproduto'. Você pode movê-la ou removê-la conforme necessário.
            this.cadprodutoTableAdapter.Fill(this.dtRelatorios.cadproduto);
            // TODO: esta linha de código carrega dados na tabela 'dtRelatorios.cadpermissao'. Você pode movê-la ou removê-la conforme necessário.
            this.cadpermissaoTableAdapter.Fill(this.dtRelatorios.cadpermissao);

            this.reportViewer1.RefreshReport();
        }
    }
}
