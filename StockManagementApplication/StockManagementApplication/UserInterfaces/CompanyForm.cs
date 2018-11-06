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
        private void CompanyForm_Load(object sender, EventArgs e)
        {
            GetAllCompany();
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
                var isExist = _companyManager.IsNameExist(company);
                if (isExist)
                {
                    GetAllCompany();
                    string validationMessage = "Name already Exist...Please give another name";
                    MessageBox.Show(validationMessage);
                    return;
                }

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

        public void GetAllCompany()
        {
            try
            {
                var companies = _companyManager.GetAll();
                CompanyDataGridView.DataSource = companies;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }



    }
}
