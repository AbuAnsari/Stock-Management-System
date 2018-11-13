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
                    messageLabel.Text = validationMessage;
                    return;
                }

                var company = new Company();
                company.Name = nameTextBox.Text;
                company.CreateBy = LoggerInfo.UserName;
                company.CreateDate = DateTime.Now;
                var isExist = _companyManager.IsNameExist(company);
                if (isExist)
                {
                    string validationMessage = "Name already Exist...Please give another name";
                    messageLabel.Text = validationMessage;
                    return;
                }

                var isSave = _companyManager.Save(company);
                if (isSave)
                {
                    GetAllCompany();
                    nameTextBox.Text = "";
                    return;
                }
                var failMessage = "Company info Save fail";
                messageLabel.Text = failMessage;
            }
            catch (Exception exception)
            {
                messageLabel.Text = exception.Message;
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
                messageLabel.Text = e.Message;
            }
        }



    }
}
