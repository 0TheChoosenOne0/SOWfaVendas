namespace WfaVendas
{
    partial class FrmMenu
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
            this.components = new System.ComponentModel.Container();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeEnfermeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioDeSeuTemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizarNaHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizarNaVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizarEmCascataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.sstStatus = new System.Windows.Forms.StatusStrip();
            this.sslTexto = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrHora = new System.Windows.Forms.Timer(this.components);
            this.mnuMenu.SuspendLayout();
            this.sstStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
            this.janelasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.MdiWindowListItem = this.janelasToolStripMenuItem;
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(800, 24);
            this.mnuMenu.TabIndex = 1;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeClientesToolStripMenuItem,
            this.cadastroDeVendasToolStripMenuItem,
            this.cadastroDeProdutosToolStripMenuItem,
            this.cadastroDeEnfermeiroToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // cadastroDeClientesToolStripMenuItem
            // 
            this.cadastroDeClientesToolStripMenuItem.Name = "cadastroDeClientesToolStripMenuItem";
            this.cadastroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.cadastroDeClientesToolStripMenuItem.Text = "Cadastro de &Clientes";
            this.cadastroDeClientesToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeClientesToolStripMenuItem_Click);
            // 
            // cadastroDeVendasToolStripMenuItem
            // 
            this.cadastroDeVendasToolStripMenuItem.Name = "cadastroDeVendasToolStripMenuItem";
            this.cadastroDeVendasToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.cadastroDeVendasToolStripMenuItem.Text = "Cadastro de &Vendas";
            this.cadastroDeVendasToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeVendasToolStripMenuItem_Click);
            // 
            // cadastroDeProdutosToolStripMenuItem
            // 
            this.cadastroDeProdutosToolStripMenuItem.Name = "cadastroDeProdutosToolStripMenuItem";
            this.cadastroDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.cadastroDeProdutosToolStripMenuItem.Text = "Cadastro de &Produtos";
            // 
            // cadastroDeEnfermeiroToolStripMenuItem
            // 
            this.cadastroDeEnfermeiroToolStripMenuItem.Name = "cadastroDeEnfermeiroToolStripMenuItem";
            this.cadastroDeEnfermeiroToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.cadastroDeEnfermeiroToolStripMenuItem.Text = "Cadastro de &Enfermeiro";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(195, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.sairToolStripMenuItem.Text = "Sai&r";
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatorioDeClientesToolStripMenuItem,
            this.relatorioDeVendasToolStripMenuItem,
            this.relatorioDeProdutosToolStripMenuItem,
            this.relatorioDeSeuTemaToolStripMenuItem});
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatoriosToolStripMenuItem.Text = "&Relatórios";
            // 
            // relatorioDeClientesToolStripMenuItem
            // 
            this.relatorioDeClientesToolStripMenuItem.Name = "relatorioDeClientesToolStripMenuItem";
            this.relatorioDeClientesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.relatorioDeClientesToolStripMenuItem.Text = "Relatório de &Clientes";
            // 
            // relatorioDeVendasToolStripMenuItem
            // 
            this.relatorioDeVendasToolStripMenuItem.Name = "relatorioDeVendasToolStripMenuItem";
            this.relatorioDeVendasToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.relatorioDeVendasToolStripMenuItem.Text = "Relatório de &Vendas";
            // 
            // relatorioDeProdutosToolStripMenuItem
            // 
            this.relatorioDeProdutosToolStripMenuItem.Name = "relatorioDeProdutosToolStripMenuItem";
            this.relatorioDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.relatorioDeProdutosToolStripMenuItem.Text = "Relatório de &Produtos";
            // 
            // relatorioDeSeuTemaToolStripMenuItem
            // 
            this.relatorioDeSeuTemaToolStripMenuItem.Name = "relatorioDeSeuTemaToolStripMenuItem";
            this.relatorioDeSeuTemaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.relatorioDeSeuTemaToolStripMenuItem.Text = "Relatório de Seu tema";
            // 
            // janelasToolStripMenuItem
            // 
            this.janelasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.organizarNaHorizontalToolStripMenuItem,
            this.organizarNaVerticalToolStripMenuItem,
            this.organizarEmCascataToolStripMenuItem});
            this.janelasToolStripMenuItem.Name = "janelasToolStripMenuItem";
            this.janelasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.janelasToolStripMenuItem.Text = "&Janelas";
            // 
            // organizarNaHorizontalToolStripMenuItem
            // 
            this.organizarNaHorizontalToolStripMenuItem.Name = "organizarNaHorizontalToolStripMenuItem";
            this.organizarNaHorizontalToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.organizarNaHorizontalToolStripMenuItem.Text = "Organizar na &Horizontal";
            // 
            // organizarNaVerticalToolStripMenuItem
            // 
            this.organizarNaVerticalToolStripMenuItem.Name = "organizarNaVerticalToolStripMenuItem";
            this.organizarNaVerticalToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.organizarNaVerticalToolStripMenuItem.Text = "Organizar na &Vertical";
            // 
            // organizarEmCascataToolStripMenuItem
            // 
            this.organizarEmCascataToolStripMenuItem.Name = "organizarEmCascataToolStripMenuItem";
            this.organizarEmCascataToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.organizarEmCascataToolStripMenuItem.Text = "Organizar em &Cascata";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Aj&uda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.sobreToolStripMenuItem.Text = "&Sobre...";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // sstStatus
            // 
            this.sstStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslTexto,
            this.sslHora});
            this.sstStatus.Location = new System.Drawing.Point(0, 426);
            this.sstStatus.Name = "sstStatus";
            this.sstStatus.Size = new System.Drawing.Size(800, 24);
            this.sstStatus.TabIndex = 3;
            this.sstStatus.Text = "statusStrip1";
            // 
            // sslTexto
            // 
            this.sslTexto.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.sslTexto.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.sslTexto.Name = "sslTexto";
            this.sslTexto.Size = new System.Drawing.Size(605, 19);
            this.sslTexto.Spring = true;
            // 
            // sslHora
            // 
            this.sslHora.AutoSize = false;
            this.sslHora.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.sslHora.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.sslHora.Name = "sslHora";
            this.sslHora.Size = new System.Drawing.Size(180, 19);
            // 
            // tmrHora
            // 
            this.tmrHora.Enabled = true;
            this.tmrHora.Interval = 1000;
            this.tmrHora.Tick += new System.EventHandler(this.tmrHora_Tick);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sstStatus);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mnuMenu);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "FrmMenu";
            this.Text = "Controle de Vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.sstStatus.ResumeLayout(false);
            this.sstStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip sstStatus;
        private System.Windows.Forms.Timer tmrHora;
        private System.Windows.Forms.ToolStripStatusLabel sslTexto;
        private System.Windows.Forms.ToolStripStatusLabel sslHora;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem janelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeEnfermeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioDeSeuTemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizarNaHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizarNaVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizarEmCascataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
    }
}