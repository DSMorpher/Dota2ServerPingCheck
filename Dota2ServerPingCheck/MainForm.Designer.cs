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
            this.RefreshAllPingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.H = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutDota2ServerPingCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContactMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(3, 3);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(504, 325);
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
            this.tbConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbConsole.Location = new System.Drawing.Point(3, 334);
            this.tbConsole.Name = "tbConsole";
            this.tbConsole.ReadOnly = true;
            this.tbConsole.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tbConsole.Size = new System.Drawing.Size(504, 136);
            this.tbConsole.TabIndex = 3;
            this.tbConsole.Text = "";
            this.tbConsole.TextChanged += new System.EventHandler(this.TbConsole_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshAllPingsToolStripMenuItem,
            this.SaveConfigurationToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // RefreshAllPingsToolStripMenuItem
            // 
            this.RefreshAllPingsToolStripMenuItem.Name = "RefreshAllPingsToolStripMenuItem";
            this.RefreshAllPingsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.RefreshAllPingsToolStripMenuItem.Text = "Refresh All Pings";
            this.RefreshAllPingsToolStripMenuItem.Click += new System.EventHandler(this.RefreshAllPingsToolStripMenuItem_Click);
            // 
            // SaveConfigurationToolStripMenuItem
            // 
            this.SaveConfigurationToolStripMenuItem.Enabled = false;
            this.SaveConfigurationToolStripMenuItem.Name = "SaveConfigurationToolStripMenuItem";
            this.SaveConfigurationToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.SaveConfigurationToolStripMenuItem.Text = "Save Configuration";
            this.SaveConfigurationToolStripMenuItem.Click += new System.EventHandler(this.SaveConfigurationToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.H,
            this.AboutDota2ServerPingCheckToolStripMenuItem,
            this.ContactMeToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // H
            // 
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(171, 22);
            this.H.Text = "How to use";
            this.H.Click += new System.EventHandler(this.HowToUseToolStripMenuItem_Click);
            // 
            // AboutDota2ServerPingCheckToolStripMenuItem
            // 
            this.AboutDota2ServerPingCheckToolStripMenuItem.Name = "AboutDota2ServerPingCheckToolStripMenuItem";
            this.AboutDota2ServerPingCheckToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.AboutDota2ServerPingCheckToolStripMenuItem.Text = "About Application";
            this.AboutDota2ServerPingCheckToolStripMenuItem.Click += new System.EventHandler(this.AboutDota2ServerPingCheckToolStripMenuItem_Click);
            // 
            // ContactMeToolStripMenuItem
            // 
            this.ContactMeToolStripMenuItem.Name = "ContactMeToolStripMenuItem";
            this.ContactMeToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.ContactMeToolStripMenuItem.Text = "Contact Me";
            this.ContactMeToolStripMenuItem.Click += new System.EventHandler(this.ContactMeToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tbConsole, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGrid, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(510, 473);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 512);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Dota 2 Server Ping Check";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem RefreshAllPingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem H;
        private System.Windows.Forms.ToolStripMenuItem AboutDota2ServerPingCheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContactMeToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

