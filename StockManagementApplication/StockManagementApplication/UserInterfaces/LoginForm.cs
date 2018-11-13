using StockManagementApplication.BLL;
using StockManagementApplication.Models;
using System;
using System.Windows.Forms;

namespace StockManagementApplication.UserInterfaces
{
    public partial class LoginForm : Form
    {
        readonly UserManager _userManager = new UserManager();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (userNameTextBox.Text == "" || passwordTextBox.Text == "")
                {
                    string validationMessage = "Please fillup Required fields";
                    messageLabel.Text = validationMessage;
                    return;
                }
                var userName = userNameTextBox.Text;
                var password = passwordTextBox.Text;
                var isLogin = _userManager.Login(userName, password);
                if (!isLogin)
                {
                    string message = "Log in fail...Please give valid info";
                    messageLabel.Text = message;
                    return;
                }

                this.Hide();
                LoggerInfo.UserName = userName;
                RefreshField();
                HomeForm homeForm = new HomeForm();
                homeForm.Closed += (s, args) => this.Close();
                homeForm.Show();

            }
            catch (Exception exception)
            {
                messageLabel.Text = exception.Message;
            }
        }
        public void RefreshField()
        {
            userNameTextBox.Text = passwordTextBox.Text = messageLabel.Text = "";
        }
    }
}
