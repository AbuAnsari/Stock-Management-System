using StockManagementApplication.UserInterfaces;
using System;
using System.Windows.Forms;

namespace StockManagementApplication
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void categorySetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.ShowDialog();
        }
        private void companySetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyForm companyForm = new CompanyForm();
            companyForm.ShowDialog();
        }
        private void itemSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemForm itemForm = new ItemForm();
            itemForm.ShowDialog();
        }
        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockInForm stockInForm = new StockInForm();
            stockInForm.ShowDialog();
        }
        private void stockOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockOutForm stockOutForm = new StockOutForm();
            stockOutForm.ShowDialog();
        }
        private void itemSummaryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemReportForm itemReport = new ItemReportForm();
            itemReport.ShowDialog();
        }
        private void sellsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellsReportForm sellsReport = new SellsReportForm();
            sellsReport.ShowDialog();
        }
        private void manageUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserCreationForm userCreationForm = new UserCreationForm();
            userCreationForm.ShowDialog();
        }
    }
}
