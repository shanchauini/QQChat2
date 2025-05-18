namespace QQChat
{
    partial class MyFriendRequestPage
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblSearchUserForRequest = new System.Windows.Forms.Label();
            this.txtSearchUserIdForRequest = new System.Windows.Forms.TextBox();
            this.btnSearchAndAddUser = new System.Windows.Forms.Button();
            this.lblMySentRequests = new System.Windows.Forms.Label();
            this.dgvMySentRequests = new System.Windows.Forms.DataGridView();
            this.btnRefreshMySentRequests = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMySentRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchUserForRequest
            // 
            this.lblSearchUserForRequest.AutoSize = true;
            this.lblSearchUserForRequest.Location = new System.Drawing.Point(12, 14);
            this.lblSearchUserForRequest.Name = "lblSearchUserForRequest";
            this.lblSearchUserForRequest.Size = new System.Drawing.Size(119, 12);
            this.lblSearchUserForRequest.TabIndex = 0;
            this.lblSearchUserForRequest.Text = "搜索用户ID添加好友:";
            // 
            // txtSearchUserIdForRequest
            // 
            this.txtSearchUserIdForRequest.Location = new System.Drawing.Point(143, 11);
            this.txtSearchUserIdForRequest.Name = "txtSearchUserIdForRequest";
            this.txtSearchUserIdForRequest.Size = new System.Drawing.Size(150, 21);
            this.txtSearchUserIdForRequest.TabIndex = 1;
            // 
            // btnSearchAndAddUser
            // 
            this.btnSearchAndAddUser.Location = new System.Drawing.Point(300, 9);
            this.btnSearchAndAddUser.Name = "btnSearchAndAddUser";
            this.btnSearchAndAddUser.Size = new System.Drawing.Size(100, 21);
            this.btnSearchAndAddUser.TabIndex = 2;
            this.btnSearchAndAddUser.Text = "搜索并申请";
            this.btnSearchAndAddUser.UseVisualStyleBackColor = true;
            this.btnSearchAndAddUser.Click += new System.EventHandler(this.btnSearchAndAddUser_Click);
            // 
            // lblMySentRequests
            // 
            this.lblMySentRequests.AutoSize = true;
            this.lblMySentRequests.Location = new System.Drawing.Point(12, 46);
            this.lblMySentRequests.Name = "lblMySentRequests";
            this.lblMySentRequests.Size = new System.Drawing.Size(107, 12);
            this.lblMySentRequests.TabIndex = 3;
            this.lblMySentRequests.Text = "我发送的好友申请:";
            // 
            // dgvMySentRequests
            // 
            this.dgvMySentRequests.AllowUserToAddRows = false;
            this.dgvMySentRequests.AllowUserToDeleteRows = false;
            this.dgvMySentRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMySentRequests.Location = new System.Drawing.Point(12, 65);
            this.dgvMySentRequests.MultiSelect = false;
            this.dgvMySentRequests.Name = "dgvMySentRequests";
            this.dgvMySentRequests.ReadOnly = true;
            this.dgvMySentRequests.RowHeadersWidth = 82;
            this.dgvMySentRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMySentRequests.Size = new System.Drawing.Size(776, 270);
            this.dgvMySentRequests.TabIndex = 4;
            this.dgvMySentRequests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMySentRequests_CellContentClick);
            // 
            // btnRefreshMySentRequests
            // 
            this.btnRefreshMySentRequests.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshMySentRequests.Location = new System.Drawing.Point(688, 351);
            this.btnRefreshMySentRequests.Name = "btnRefreshMySentRequests";
            this.btnRefreshMySentRequests.Size = new System.Drawing.Size(100, 28);
            this.btnRefreshMySentRequests.TabIndex = 5;
            this.btnRefreshMySentRequests.Text = "刷新列表";
            this.btnRefreshMySentRequests.UseVisualStyleBackColor = true;
            this.btnRefreshMySentRequests.Click += new System.EventHandler(this.btnRefreshMySentRequests_Click);
            // 
            // MyFriendRequestPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.btnRefreshMySentRequests);
            this.Controls.Add(this.dgvMySentRequests);
            this.Controls.Add(this.lblMySentRequests);
            this.Controls.Add(this.btnSearchAndAddUser);
            this.Controls.Add(this.txtSearchUserIdForRequest);
            this.Controls.Add(this.lblSearchUserForRequest);
            this.Name = "MyFriendRequestPage";
            this.Text = "我的好友申请管理";
            this.Load += new System.EventHandler(this.MyFriendRequestPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMySentRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchUserForRequest;
        private System.Windows.Forms.TextBox txtSearchUserIdForRequest;
        private System.Windows.Forms.Button btnSearchAndAddUser;
        private System.Windows.Forms.Label lblMySentRequests;
        private System.Windows.Forms.DataGridView dgvMySentRequests;
        private System.Windows.Forms.Button btnRefreshMySentRequests;
    }
} 