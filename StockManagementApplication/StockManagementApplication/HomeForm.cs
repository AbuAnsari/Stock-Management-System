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

        private CategoryForm _categoryForm;
        private void categorySetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_categoryForm == null)
            {
                _categoryForm = new CategoryForm();
                _categoryForm.Show();
            }
            else
            {
                _categoryForm.Activate();
            }
        }

        private CompanyForm _companyForm;
        private void companySetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_companyForm == null)
            {
                _companyForm = new CompanyForm();
                _companyForm.Show();
            }
            else
            {
                _companyForm.Activate();
            }
        }

        private ItemForm _itemForm;
        private void itemSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_itemForm == null)
            {
                _itemForm = new ItemForm();
                _itemForm.Show();
            }
            else
            {
                _itemForm.Activate();
            }
        }

        private StockInForm _stockInForm;
        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_stockInForm == null)
            {
                _stockInForm = new StockInForm();
                _stockInForm.Show();
            }
            else
            {
                _stockInForm.Activate();
            }
        }

        private StockOutForm _stockOutForm;
        private void stockOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_stockOutForm == null)
            {
                _stockOutForm = new StockOutForm();
                _stockOutForm.Show();
            }
            else
            {
                _stockOutForm.Activate();
            }
        }

        ItemReportForm _itemReport;
        private void itemSummaryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_itemReport == null)
            {
                _itemReport = new ItemReportForm();
                _itemReport.Show();
            }
            else
            {
                _itemReport.Activate();
            }
        }

        private SellsReportForm _sellsReport;
        private void sellsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_sellsReport == null)
            {
                _sellsReport = new SellsReportForm();
                _sellsReport.Show();
            }
            else
            {
                _sellsReport.Activate();
            }
        }
    }
}
