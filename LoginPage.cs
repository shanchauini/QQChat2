using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace QQChat
{
    public partial class LoginPage : Form
    {
        

        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("账号和密码不能为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rbAdmin.Checked) // 管理员登录
            {
                if (username == "0000" && password == "1234")
                {
                    MessageBox.Show("管理员登录成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminMainPage adminMainPage = new AdminMainPage();
                    adminMainPage.Show();
                    this.Hide(); 
                }
                else
                {
                    MessageBox.Show("管理员账号或密码错误!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // 普通用户登录
            {
                string sql = "SELECT UserId, IsApproved, IsBanned FROM Users WHERE UserId = @UserId AND PSW = @PSW";
                var p1 = new MySqlParameter("@UserId", username); // 账号输入框内容为UserId
                var p2 = new MySqlParameter("@PSW", password);
                var dt = DataAccess.ExecuteQuery(sql, p1, p2);
                if (dt.Rows.Count > 0)
                {
                    int userId = Convert.ToInt32(dt.Rows[0]["UserId"]);
                    bool isApproved = Convert.ToBoolean(dt.Rows[0]["IsApproved"]);
                    bool isBanned = Convert.ToBoolean(dt.Rows[0]["IsBanned"]);
                    if (!isApproved)
                    {
                        MessageBox.Show("账号尚待管理员审核，请耐心等待。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (isBanned)
                    {
                        MessageBox.Show("该账号已被禁用，请联系管理员。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("用户登录成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UserMainPage userMainPage = new UserMainPage(userId); // 传递用户ID
                        userMainPage.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("用户名或密码错误!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void llblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterPage registerPage = new RegisterPage();
            registerPage.Show();
            // 登录窗口也可以关闭或隐藏
            // this.Hide(); 
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void LoginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
} 