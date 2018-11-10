using StockManagementApplication.BLL;
using StockManagementApplication.Models;
using System;
using System.Windows.Forms;

namespace StockManagementApplication.UserInterfaces
{
    public partial class UserCreationForm : Form
    {
        readonly UserManager _userManager = new UserManager();
        public UserCreationForm()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (userNameTextBox.Text == "" || passwordTextBox.Text == "")
                {
                    string validationMessage = "Please fillup Required fields";
                    MessageBox.Show(validationMessage);
                    return;
                }
                var userInfo = new UserInfo();
                userInfo.Name = userNameTextBox.Text;
                userInfo.Password = passwordTextBox.Text;
                userInfo.ConfirmPassword = confirmPasswordTextBox.Text;
                userInfo.CreateBy = LoggerInfo.UserName;
                userInfo.CrateDate = DateTime.Now;
                if (userInfo.Password != userInfo.ConfirmPassword)
                {
                    var validationMessage = "Password not match";
                    MessageBox.Show(validationMessage);
                    return;
                }
                var isUserNameExist = _userManager.IsUserNameExist(userInfo);
                if (isUserNameExist)
                {
                    var validationMessage = "Username Already Exist";
                    MessageBox.Show(validationMessage);
                    return;
                }

                var isSave = _userManager.Save(userInfo);
                if (isSave)
                {
                    RefreshField();
                    string successMessage = "User Create Successfully";
                    MessageBox.Show(successMessage);
                    return;
                }
                string failMessage = "User Create Successfully";
                MessageBox.Show(failMessage);

            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public void RefreshField()
        {
            userNameTextBox.Text = passwordTextBox.Text = confirmPasswordTextBox.Text = "";
        }
    }
}
