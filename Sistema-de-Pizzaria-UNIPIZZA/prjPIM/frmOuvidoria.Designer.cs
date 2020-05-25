namespace prjPIM
{
    partial class frmOuvidoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOuvidoria));
            this.btnApagarReclama = new System.Windows.Forms.Button();
            this.btnApagarElogio = new System.Windows.Forms.Button();
            this.btnReclama = new System.Windows.Forms.Button();
            this.btnElogio = new System.Windows.Forms.Button();
            this.txtReclama = new System.Windows.Forms.TextBox();
            this.txtElogio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.btnVoltar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApagarReclama
            // 
            this.btnApagarReclama.Enabled = false;
            this.btnApagarReclama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarReclama.Location = new System.Drawing.Point(238, 292);
            this.btnApagarReclama.Name = "btnApagarReclama";
            this.btnApagarReclama.Size = new System.Drawing.Size(123, 33);
            this.btnApagarReclama.TabIndex = 35;
            this.btnApagarReclama.Text = "APAGAR";
            this.btnApagarReclama.UseVisualStyleBackColor = true;
            this.btnApagarReclama.Click += new System.EventHandler(this.btnApagarReclama_Click);
            // 
            // btnApagarElogio
            // 
            this.btnApagarElogio.Enabled = false;
            this.btnApagarElogio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarElogio.Location = new System.Drawing.Point(238, 173);
            this.btnApagarElogio.Name = "btnApagarElogio";
            this.btnApagarElogio.Size = new System.Drawing.Size(123, 33);
            this.btnApagarElogio.TabIndex = 34;
            this.btnApagarElogio.Text = "APAGAR";
            this.btnApagarElogio.UseVisualStyleBackColor = true;
            this.btnApagarElogio.Click += new System.EventHandler(this.btnApagarElogio_Click);
            // 
            // btnReclama
            // 
            this.btnReclama.Enabled = false;
            this.btnReclama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReclama.Location = new System.Drawing.Point(367, 292);
            this.btnReclama.Name = "btnReclama";
            this.btnReclama.Size = new System.Drawing.Size(123, 33);
            this.btnReclama.TabIndex = 33;
            this.btnReclama.Text = "ENVIAR";
            this.btnReclama.UseVisualStyleBackColor = true;
            // 
            // btnElogio
            // 
            this.btnElogio.Enabled = false;
            this.btnElogio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElogio.Location = new System.Drawing.Point(367, 173);
            this.btnElogio.Name = "btnElogio";
            this.btnElogio.Size = new System.Drawing.Size(123, 33);
            this.btnElogio.TabIndex = 32;
            this.btnElogio.Text = "ENVIAR";
            this.btnElogio.UseVisualStyleBackColor = true;
            this.btnElogio.Click += new System.EventHandler(this.btnElogio_Click);
            // 
            // txtReclama
            // 
            this.txtReclama.Location = new System.Drawing.Point(15, 224);
            this.txtReclama.Multiline = true;
            this.txtReclama.Name = "txtReclama";
            this.txtReclama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReclama.Size = new System.Drawing.Size(480, 80);
            this.txtReclama.TabIndex = 31;
            this.txtReclama.TextChanged += new System.EventHandler(this.txtReclama_TextChanged);
            // 
            // txtElogio
            // 
            this.txtElogio.Location = new System.Drawing.Point(12, 87);
            this.txtElogio.Multiline = true;
            this.txtElogio.Name = "txtElogio";
            this.txtElogio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtElogio.Size = new System.Drawing.Size(480, 80);
            this.txtElogio.TabIndex = 30;
            this.txtElogio.TextChanged += new System.EventHandler(this.txtElogio_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(12, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "RECLAMAÇÃO:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "ELOGIO:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel3,
            this.btnVoltar,
            this.toolStripLabel2});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 4, 2, 0);
            this.toolStrip.Size = new System.Drawing.Size(517, 61);
            this.toolStrip.TabIndex = 27;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(10, 54);
            this.toolStripLabel1.Text = " ";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.AutoSize = false;
            this.toolStripLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(180, 55);
            this.toolStripLabel3.Text = "OUVIDORIA  ";
            // 
            // btnVoltar
            // 
            this.btnVoltar.AutoSize = false;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoltar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnVoltar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(60, 52);
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(0, 54);
            // 
            // frmOuvidoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 337);
            this.Controls.Add(this.btnApagarReclama);
            this.Controls.Add(this.btnApagarElogio);
            this.Controls.Add(this.btnReclama);
            this.Controls.Add(this.btnElogio);
            this.Controls.Add(this.txtReclama);
            this.Controls.Add(this.txtElogio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip);
            this.Name = "frmOuvidoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOuvidoria";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApagarReclama;
        private System.Windows.Forms.Button btnApagarElogio;
        private System.Windows.Forms.Button btnReclama;
        private System.Windows.Forms.Button btnElogio;
        private System.Windows.Forms.TextBox txtReclama;
        private System.Windows.Forms.TextBox txtElogio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton btnVoltar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}