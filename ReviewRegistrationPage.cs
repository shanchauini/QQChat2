using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace QQChat
{
    public partial class ReviewRegistrationPage : Form
    {
        

        public ReviewRegistrationPage()
        {
            InitializeComponent();
        }

        private void ReviewRegistrationPage_Load(object sender, EventArgs e)
        {
            LoadPendingRegistrations();
        }

        private void LoadPendingRegistrations()
        {
            //注册列表信息绑定到Datagrid
            string sql = "SELECT UserId, UserName, Email, Gender FROM Users WHERE IsApproved = 0 AND IsBanned = 0";
            DataTable dt = DataAccess.ExecuteQuery(sql);
            dgvPendingRegistrations.DataSource = dt;
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dgvPendingRegistrations.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dgvPendingRegistrations.SelectedRows[0].Cells["UserId"].Value);
                string sql = "UPDATE Users SET IsApproved = 1 WHERE UserId = @UserId";
                var param = new MySqlParameter("@UserId", userId);
                DataAccess.ExecuteNonQuery(sql, param);
                LoadPendingRegistrations();
            }
            else
            {
                MessageBox.Show("请先选择一个用户进行通过。", "提示");
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (dgvPendingRegistrations.SelectedRows.Count > 0)
            {
                //注册申请驳回，删除该账号
                int userId = Convert.ToInt32(dgvPendingRegistrations.SelectedRows[0].Cells["UserId"].Value);
                string sql = "DELETE FROM Users WHERE UserId = @UserId AND IsApproved = 0";
                var param = new MySqlParameter("@UserId", userId);
                DataAccess.ExecuteNonQuery(sql, param);
                LoadPendingRegistrations();
            }
            else
            {
                MessageBox.Show("请先选择一个用户进行驳回。", "提示");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPendingRegistrations();
        }

        private void dgvPendingRegistrations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
} 