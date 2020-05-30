namespace prjPIM
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.stStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblOperador = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblData = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadPizza = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMatPrima = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBebidas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFilial = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFaturamento = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuControleAcc = new System.Windows.Forms.ToolStripMenuItem();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.stStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // stStrip
            // 
            this.stStrip.BackColor = System.Drawing.Color.White;
            this.stStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblOperador,
            this.toolStripStatusLabel2,
            this.lblData});
            this.stStrip.Location = new System.Drawing.Point(0, 723);
            this.stStrip.Name = "stStrip";
            this.stStrip.Size = new System.Drawing.Size(984, 22);
            this.stStrip.TabIndex = 0;
            this.stStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(60, 17);
            this.toolStripStatusLabel1.Text = "Operador:";
            // 
            // lblOperador
            // 
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(103, 17);
            this.lblOperador.Text = "NOMEOPERADOR";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(733, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // lblData
            // 
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(73, 17);
            this.lblData.Text = "DATA/HORA";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.movimentaçãoToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.manutençãoToolStripMenuItem});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(984, 25);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadPizza,
            this.menuMatPrima,
            this.menuBebidas,
            this.toolStripSeparator3,
            this.menuUsuarios,
            this.menuFilial});
            this.cadastroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroToolStripMenuItem.Image")));
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(89, 21);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // menuCadPizza
            // 
            this.menuCadPizza.Name = "menuCadPizza";
            this.menuCadPizza.Size = new System.Drawing.Size(180, 22);
            this.menuCadPizza.Text = "Pizzas";
            this.menuCadPizza.Click += new System.EventHandler(this.PizzasToolStripMenuItem_Click);
            // 
            // menuMatPrima
            // 
            this.menuMatPrima.Name = "menuMatPrima";
            this.menuMatPrima.Size = new System.Drawing.Size(180, 22);
            this.menuMatPrima.Text = "Matéria Prima";
            this.menuMatPrima.Click += new System.EventHandler(this.matériaPrimaToolStripMenuItem_Click);
            // 
            // menuBebidas
            // 
            this.menuBebidas.Name = "menuBebidas";
            this.menuBebidas.Size = new System.Drawing.Size(180, 22);
            this.menuBebidas.Text = "Produtos";
            this.menuBebidas.Click += new System.EventHandler(this.menuBebidas_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(180, 22);
            this.menuUsuarios.Text = "Usuários";
            this.menuUsuarios.Click += new System.EventHandler(this.menuUsuarios_Click);
            // 
            // menuFilial
            // 
            this.menuFilial.Name = "menuFilial";
            this.menuFilial.Size = new System.Drawing.Size(180, 22);
            this.menuFilial.Text = "Filial";
            this.menuFilial.Click += new System.EventHandler(this.menuFilial_Click);
            // 
            // movimentaçãoToolStripMenuItem
            // 
            this.movimentaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPedidos,
            this.menuEstoque});
            this.movimentaçãoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("movimentaçãoToolStripMenuItem.Image")));
            this.movimentaçãoToolStripMenuItem.Name = "movimentaçãoToolStripMenuItem";
            this.movimentaçãoToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.movimentaçãoToolStripMenuItem.Text = "Movimentação";
            // 
            // menuPedidos
            // 
            this.menuPedidos.Name = "menuPedidos";
            this.menuPedidos.Size = new System.Drawing.Size(180, 22);
            this.menuPedidos.Text = "Pedidos";
            this.menuPedidos.Click += new System.EventHandler(this.menuPedidos_Click);
            // 
            // menuEstoque
            // 
            this.menuEstoque.Name = "menuEstoque";
            this.menuEstoque.Size = new System.Drawing.Size(180, 22);
            this.menuEstoque.Text = "Estoque";
            this.menuEstoque.Click += new System.EventHandler(this.menuEstoque_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFaturamento,
            this.produtosToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("relatóriosToolStripMenuItem.Image")));
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // menuFaturamento
            // 
            this.menuFaturamento.Name = "menuFaturamento";
            this.menuFaturamento.Size = new System.Drawing.Size(180, 22);
            this.menuFaturamento.Text = "Faturamento";
            this.menuFaturamento.Click += new System.EventHandler(this.faturamentoToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // manutençãoToolStripMenuItem
            // 
            this.manutençãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuControleAcc});
            this.manutençãoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manutençãoToolStripMenuItem.Image")));
            this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.manutençãoToolStripMenuItem.Text = "Manutenção";
            // 
            // menuControleAcc
            // 
            this.menuControleAcc.Name = "menuControleAcc";
            this.menuControleAcc.Size = new System.Drawing.Size(180, 22);
            this.menuControleAcc.Text = "Controle de Acesso";
            this.menuControleAcc.Click += new System.EventHandler(this.menuControleAcc_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 745);
            this.Controls.Add(this.stStrip);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gerenciamento de Pizzaria - UNIPIZZA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.stStrip.ResumeLayout(false);
            this.stStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblOperador;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblData;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ToolStripMenuItem menuCadPizza;
        private System.Windows.Forms.ToolStripMenuItem menuMatPrima;
        private System.Windows.Forms.ToolStripMenuItem menuBebidas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem menuFilial;
        private System.Windows.Forms.ToolStripMenuItem menuPedidos;
        private System.Windows.Forms.ToolStripMenuItem menuEstoque;
        private System.Windows.Forms.ToolStripMenuItem menuControleAcc;
        private System.Windows.Forms.ToolStripMenuItem menuFaturamento;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
    }
}

