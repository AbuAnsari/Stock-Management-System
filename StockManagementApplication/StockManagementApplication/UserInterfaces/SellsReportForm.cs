using StockManagementApplication.BLL;
using System;
using System.Windows.Forms;

namespace StockManagementApplication.UserInterfaces
{
    public partial class SellsReportForm : Form
    {
        readonly StockOutManager _stockOutManager = new StockOutManager();
        public SellsReportForm()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (fromDatDateTimePicker.Text == "" || toDateDateTimePicker.Text == "")
            {
                string validationMessage = "Please Select Required Fields";
                MessageBox.Show(validationMessage);
                return;
            }

           
            var fromDate = Convert.ToDateTime(fromDatDateTimePicker.Text);
            var toDate = Convert.ToDateTime(toDateDateTimePicker.Text);
            if (toDate.Day<= fromDate.Day)
            {
                string validationMessage = "To Date Must be Equal or Greater than from date";
                MessageBox.Show(validationMessage);
                return;
            }
            var sellItems = _stockOutManager.GetAllSellItem(fromDate, toDate);
            sellItemsDataGridView.DataSource = sellItems;
        }
    }
}
