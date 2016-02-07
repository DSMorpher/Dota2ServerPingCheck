namespace Dota2ServerPingCheck
{
    partial class MainForm
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.DGVServerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVServerIp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVPing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbConsole = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshAllPingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutDota2ServerPingCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGVServerName,
            this.DGVServerIp,
            this.DGVPing});
            this.dataGrid.Location = new System.Drawing.Point(12, 27);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(467, 298);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGrid_MouseClick);
            // 
            // DGVServerName
            // 
            this.DGVServerName.HeaderText = "Server Name";
            this.DGVServerName.Name = "DGVServerName";
            this.DGVServerName.ReadOnly = true;
            this.DGVServerName.Visible = false;
            this.DGVServerName.Width = 175;
            // 
            // DGVServerIp
            // 
            this.DGVServerIp.HeaderText = "Server IP";
            this.DGVServerIp.Name = "DGVServerIp";
            this.DGVServerIp.ReadOnly = true;
            this.DGVServerIp.Visible = false;
            // 
            // DGVPing
            // 
            this.DGVPing.HeaderText = "Ping";
            this.DGVPing.Name = "DGVPing";
            this.DGVPing.ReadOnly = true;
            this.DGVPing.Visible = false;
            this.DGVPing.Width = 75;
            // 
            // tbConsole
            // 
            this.tbConsole.BackColor = System.Drawing.SystemColors.Desktop;
            this.tbConsole.Location = new System.Drawing.Point(12, 331);
            this.tbConsole.Name = "tbConsole";
            this.tbConsole.ReadOnly = true;
            this.tbConsole.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tbConsole.Size = new System.Drawing.Size(467, 127);
            this.tbConsole.TabIndex = 3;
            this.tbConsole.Text = "";
            this.tbConsole.TextChanged += new System.EventHandler(this.tbConsole_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(491, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshAllPingsToolStripMenuItem,
            this.saveConfigurationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // refreshAllPingsToolStripMenuItem
            // 
            this.refreshAllPingsToolStripMenuItem.Name = "refreshAllPingsToolStripMenuItem";
            this.refreshAllPingsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.refreshAllPingsToolStripMenuItem.Text = "Refresh All Pings";
            this.refreshAllPingsToolStripMenuItem.Click += new System.EventHandler(this.refreshAllPingsToolStripMenuItem_Click);
            // 
            // saveConfigurationToolStripMenuItem
            // 
            this.saveConfigurationToolStripMenuItem.Enabled = false;
            this.saveConfigurationToolStripMenuItem.Name = "saveConfigurationToolStripMenuItem";
            this.saveConfigurationToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.saveConfigurationToolStripMenuItem.Text = "Save Configuration";
            this.saveConfigurationToolStripMenuItem.Click += new System.EventHandler(this.saveConfigurationToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToUseToolStripMenuItem,
            this.aboutDota2ServerPingCheckToolStripMenuItem,
            this.contactMeToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.howToUseToolStripMenuItem.Text = "How to use";
            this.howToUseToolStripMenuItem.Click += new System.EventHandler(this.howToUseToolStripMenuItem_Click);
            // 
            // aboutDota2ServerPingCheckToolStripMenuItem
            // 
            this.aboutDota2ServerPingCheckToolStripMenuItem.Name = "aboutDota2ServerPingCheckToolStripMenuItem";
            this.aboutDota2ServerPingCheckToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.aboutDota2ServerPingCheckToolStripMenuItem.Text = "About Application";
            this.aboutDota2ServerPingCheckToolStripMenuItem.Click += new System.EventHandler(this.aboutDota2ServerPingCheckToolStripMenuItem_Click);
            // 
            // contactMeToolStripMenuItem
            // 
            this.contactMeToolStripMenuItem.Name = "contactMeToolStripMenuItem";
            this.contactMeToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.contactMeToolStripMenuItem.Text = "Contact Me";
            this.contactMeToolStripMenuItem.Click += new System.EventHandler(this.contactMeToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 470);
            this.Controls.Add(this.tbConsole);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Dota 2 Server Ping Check";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.RichTextBox tbConsole;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVServerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVServerIp;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVPing;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshAllPingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutDota2ServerPingCheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactMeToolStripMenuItem;
    }
}

