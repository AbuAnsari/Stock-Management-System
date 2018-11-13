namespace StockManagementApplication
{
    partial class HomeForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categorySetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companySetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSummaryReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(523, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categorySetupToolStripMenuItem,
            this.companySetupToolStripMenuItem,
            this.itemSetupToolStripMenuItem,
            this.manageUserToolStripMenuItem});
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.settingsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // categorySetupToolStripMenuItem
            // 
            this.categorySetupToolStripMenuItem.Name = "categorySetupToolStripMenuItem";
            this.categorySetupToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.categorySetupToolStripMenuItem.Text = "Category Setup";
            this.categorySetupToolStripMenuItem.Click += new System.EventHandler(this.categorySetupToolStripMenuItem_Click);
            // 
            // companySetupToolStripMenuItem
            // 
            this.companySetupToolStripMenuItem.Name = "companySetupToolStripMenuItem";
            this.companySetupToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.companySetupToolStripMenuItem.Text = "Company Setup";
            this.companySetupToolStripMenuItem.Click += new System.EventHandler(this.companySetupToolStripMenuItem_Click);
            // 
            // itemSetupToolStripMenuItem
            // 
            this.itemSetupToolStripMenuItem.Name = "itemSetupToolStripMenuItem";
            this.itemSetupToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.itemSetupToolStripMenuItem.Text = "Item Setup";
            this.itemSetupToolStripMenuItem.Click += new System.EventHandler(this.itemSetupToolStripMenuItem_Click);
            // 
            // manageUserToolStripMenuItem
            // 
            this.manageUserToolStripMenuItem.Name = "manageUserToolStripMenuItem";
            this.manageUserToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.manageUserToolStripMenuItem.Text = "Manage User";
            this.manageUserToolStripMenuItem.Click += new System.EventHandler(this.manageUserToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockToolStripMenuItem,
            this.stockOutToolStripMenuItem});
            this.inventoryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.stockToolStripMenuItem.Text = "StockIn";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // stockOutToolStripMenuItem
            // 
            this.stockOutToolStripMenuItem.Name = "stockOutToolStripMenuItem";
            this.stockOutToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.stockOutToolStripMenuItem.Text = "Stock Out";
            this.stockOutToolStripMenuItem.Click += new System.EventHandler(this.stockOutToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemSummaryReportToolStripMenuItem,
            this.sellsReportToolStripMenuItem});
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 29);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // itemSummaryReportToolStripMenuItem
            // 
            this.itemSummaryReportToolStripMenuItem.Name = "itemSummaryReportToolStripMenuItem";
            this.itemSummaryReportToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.itemSummaryReportToolStripMenuItem.Text = "Item Summary Report";
            this.itemSummaryReportToolStripMenuItem.Click += new System.EventHandler(this.itemSummaryReportToolStripMenuItem_Click);
            // 
            // sellsReportToolStripMenuItem
            // 
            this.sellsReportToolStripMenuItem.Name = "sellsReportToolStripMenuItem";
            this.sellsReportToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.sellsReportToolStripMenuItem.Text = "Sells Report";
            this.sellsReportToolStripMenuItem.Click += new System.EventHandler(this.sellsReportToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.DarkViolet;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 314);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(523, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(135, 17);
            this.toolStripStatusLabel1.Text = "Develop By : Root Coder";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(26, 281);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(523, 336);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categorySetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companySetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemSummaryReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellsReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUserToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

