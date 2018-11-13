namespace StockManagementApplication.UserInterfaces
{
    partial class SellsReportForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fromDatDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SearchButton = new System.Windows.Forms.Button();
            this.sellItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.serialNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellItemViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.messageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sellItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellItemViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "To Date";
            // 
            // fromDatDateTimePicker
            // 
            this.fromDatDateTimePicker.Location = new System.Drawing.Point(165, 37);
            this.fromDatDateTimePicker.Name = "fromDatDateTimePicker";
            this.fromDatDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fromDatDateTimePicker.TabIndex = 1;
            // 
            // toDateDateTimePicker
            // 
            this.toDateDateTimePicker.Location = new System.Drawing.Point(165, 75);
            this.toDateDateTimePicker.Name = "toDateDateTimePicker";
            this.toDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.toDateDateTimePicker.TabIndex = 2;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(165, 110);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // sellItemsDataGridView
            // 
            this.sellItemsDataGridView.AutoGenerateColumns = false;
            this.sellItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.sellItemsDataGridView.DataSource = this.sellItemViewModelBindingSource;
            this.sellItemsDataGridView.Location = new System.Drawing.Point(72, 182);
            this.sellItemsDataGridView.Name = "sellItemsDataGridView";
            this.sellItemsDataGridView.Size = new System.Drawing.Size(424, 186);
            this.sellItemsDataGridView.TabIndex = 4;
            // 
            // serialNoDataGridViewTextBoxColumn
            // 
            this.serialNoDataGridViewTextBoxColumn.DataPropertyName = "SerialNo";
            this.serialNoDataGridViewTextBoxColumn.HeaderText = "Serial No";
            this.serialNoDataGridViewTextBoxColumn.Name = "serialNoDataGridViewTextBoxColumn";
            this.serialNoDataGridViewTextBoxColumn.Width = 80;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // sellItemViewModelBindingSource
            // 
            this.sellItemViewModelBindingSource.DataSource = typeof(StockManagementApplication.ViewModels.SellItemViewModel);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.ForeColor = System.Drawing.Color.Red;
            this.messageLabel.Location = new System.Drawing.Point(162, 150);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 13);
            this.messageLabel.TabIndex = 7;
            // 
            // SellsReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 380);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.sellItemsDataGridView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.toDateDateTimePicker);
            this.Controls.Add(this.fromDatDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(580, 419);
            this.MinimumSize = new System.Drawing.Size(580, 419);
            this.Name = "SellsReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sells Report";
            ((System.ComponentModel.ISupportInitialize)(this.sellItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellItemViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fromDatDateTimePicker;
        private System.Windows.Forms.DateTimePicker toDateDateTimePicker;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView sellItemsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sellItemViewModelBindingSource;
        private System.Windows.Forms.Label messageLabel;
    }
}