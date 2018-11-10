namespace StockManagementApplication.UserInterfaces
{
    partial class ItemReportForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ItemReportDataGridView = new System.Windows.Forms.DataGridView();
            this.serialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemReportViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.messageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemReportDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemReportViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Company";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Category";
            // 
            // companyComboBox
            // 
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(179, 74);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(181, 21);
            this.companyComboBox.TabIndex = 2;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(179, 36);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(181, 21);
            this.categoryComboBox.TabIndex = 1;
            this.categoryComboBox.SelectionChangeCommitted += new System.EventHandler(this.categoryComboBox_SelectionChangeCommitted);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(179, 112);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ItemReportDataGridView
            // 
            this.ItemReportDataGridView.AutoGenerateColumns = false;
            this.ItemReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemReportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn,
            this.itemDataGridViewTextBoxColumn,
            this.availableQuantityDataGridViewTextBoxColumn,
            this.reorderLevelDataGridViewTextBoxColumn});
            this.ItemReportDataGridView.DataSource = this.itemReportViewModelBindingSource;
            this.ItemReportDataGridView.Location = new System.Drawing.Point(23, 175);
            this.ItemReportDataGridView.Name = "ItemReportDataGridView";
            this.ItemReportDataGridView.Size = new System.Drawing.Size(632, 246);
            this.ItemReportDataGridView.TabIndex = 25;
            // 
            // serialDataGridViewTextBoxColumn
            // 
            this.serialDataGridViewTextBoxColumn.DataPropertyName = "Serial";
            this.serialDataGridViewTextBoxColumn.HeaderText = "Serial";
            this.serialDataGridViewTextBoxColumn.Name = "serialDataGridViewTextBoxColumn";
            this.serialDataGridViewTextBoxColumn.Width = 70;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "Company";
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            // 
            // availableQuantityDataGridViewTextBoxColumn
            // 
            this.availableQuantityDataGridViewTextBoxColumn.DataPropertyName = "AvailableQuantity";
            this.availableQuantityDataGridViewTextBoxColumn.HeaderText = "Available Quantity";
            this.availableQuantityDataGridViewTextBoxColumn.Name = "availableQuantityDataGridViewTextBoxColumn";
            this.availableQuantityDataGridViewTextBoxColumn.Width = 120;
            // 
            // reorderLevelDataGridViewTextBoxColumn
            // 
            this.reorderLevelDataGridViewTextBoxColumn.DataPropertyName = "ReorderLevel";
            this.reorderLevelDataGridViewTextBoxColumn.HeaderText = "Reorder Level";
            this.reorderLevelDataGridViewTextBoxColumn.Name = "reorderLevelDataGridViewTextBoxColumn";
            // 
            // itemReportViewModelBindingSource
            // 
            this.itemReportViewModelBindingSource.DataSource = typeof(StockManagementApplication.ViewModels.ItemReportViewModel);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.ForeColor = System.Drawing.Color.Red;
            this.messageLabel.Location = new System.Drawing.Point(141, 147);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 13);
            this.messageLabel.TabIndex = 26;
            // 
            // ItemReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 433);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.ItemReportDataGridView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.companyComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Name = "ItemReportForm";
            this.Text = "Search and View Item Summary";
            ((System.ComponentModel.ISupportInitialize)(this.ItemReportDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemReportViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView ItemReportDataGridView;
        private System.Windows.Forms.BindingSource itemReportViewModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label messageLabel;
    }
}