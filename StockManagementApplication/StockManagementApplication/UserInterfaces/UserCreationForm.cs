using StockManagementApplication.BLL;
using StockManagementApplication.Models;
using System;
using System.Drawing;
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
                    messageLabel.Text = validationMessage;
                    return;
                }
                var isUserNameExist = _userManager.IsUserNameExist(userNameTextBox.Text);
                if (isUserNameExist)
                {
                    var validationMessage = "Username Already Exist";
                    messageLabel.Text = validationMessage;
                    return;
                }
                if (passwordTextBox.Text != confirmPasswordTextBox.Text)
                {
                    var validationMessage = "Password not match";
                    messageLabel.Text = validationMessage;
                    return;
                }
                var userInfo = new UserInfo();
                userInfo.Name = userNameTextBox.Text;
                userInfo.Password = passwordTextBox.Text;
                userInfo.ConfirmPassword = confirmPasswordTextBox.Text;
                userInfo.CreateBy = LoggerInfo.UserName;
                userInfo.CrateDate = DateTime.Now;
                var isSave = _userManager.Save(userInfo);
                if (isSave)
                {
                    RefreshField();
                    string successMessage = "User Create Successfully";
                    messageLabel.Text = successMessage;
                    messageLabel.ForeColor = Color.Green;
                    return;
                }
                string failMessage = "User Create Successfully";
                messageLabel.Text = failMessage;

            }
            catch (Exception exception)
            {
                messageLabel.Text = exception.Message;
            }
        }
        public void RefreshField()
        {
            userNameTextBox.Text = passwordTextBox.Text = confirmPasswordTextBox.Text = "";
        }
    }
}
