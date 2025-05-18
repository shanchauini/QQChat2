using System;
using System.Windows.Forms;

namespace QQChat
{
    public partial class AdminMainPage : Form
    {
        public AdminMainPage()
        {
            InitializeComponent();
        }

        private void miReviewRegistration_Click(object sender, EventArgs e)
        {
            var reviewPage = new ReviewRegistrationPage();
            reviewPage.Show();
        }

        private void miBanAccount_Click(object sender, EventArgs e)
        {
            var banPage = new BanAccountPage();
            banPage.Show();
        }

        private void miManageMessages_Click(object sender, EventArgs e)
        {
            var manageMessagePage = new ManageMessagePage();
            manageMessagePage.Show();
        }

        private void miLogout_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Close();
        }

        // AdminMainPage 需要设置 IsMdiContainer = true
       
        private void AdminMainPage_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void AdminMainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AdminMainPage_Load_1(object sender, EventArgs e)
        {

        }
    }
} 