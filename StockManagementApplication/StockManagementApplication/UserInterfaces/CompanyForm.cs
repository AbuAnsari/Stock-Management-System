using StockManagementApplication.BLL;
using StockManagementApplication.Models;
using System;
using System.Windows.Forms;

namespace StockManagementApplication.UserInterfaces
{
    public partial class CompanyForm : Form
    {
        readonly CompanyManager _companyManager = new CompanyManager();
        public CompanyForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameTextBox.Text == "")
                {
                    string validationMessage = "Please give Name";
                    MessageBox.Show(validationMessage);
                    return;
                }

                var company = new Company();
                company.Name = nameTextBox.Text;
                company.CreateBy = "Admin";
                company.CreateDate = DateTime.Now;

                var isSave = _companyManager.Save(company);
                if (isSave)
                {
                    var successMessage = "Company info Save Successfully";
                    nameTextBox.Text = "";
                    MessageBox.Show(successMessage);
                    return;
                }
                var failMessage = "Company info Save fail";
                MessageBox.Show(failMessage);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }


    }
}
