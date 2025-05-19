namespace QQChat
{
    partial class BanAccountPage
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
            this.lblSearchUser = new System.Windows.Forms.Label();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnBanUser = new System.Windows.Forms.Button();
            this.btnUnbanUser = new System.Windows.Forms.Button();
            this.btnRefreshUserList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchUser
            // 
            this.lblSearchUser.AutoSize = true;
            this.lblSearchUser.Location = new System.Drawing.Point(24, 28);
            this.lblSearchUser.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSearchUser.Name = "lblSearchUser";
            this.lblSearchUser.Size = new System.Drawing.Size(202, 24);
            this.lblSearchUser.TabIndex = 0;
            this.lblSearchUser.Text = "搜索用户(ID/名):";
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Location = new System.Drawing.Point(202, 22);
            this.txtSearchUser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(396, 35);
            this.txtSearchUser.TabIndex = 1;
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSearchUser.Location = new System.Drawing.Point(614, 18);
            this.btnSearchUser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(150, 42);
            this.btnSearchUser.TabIndex = 2;
            this.btnSearchUser.Text = "搜索";
            this.btnSearchUser.UseVisualStyleBackColor = false;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(24, 84);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 82;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(1618, 616);
            this.dgvUsers.TabIndex = 3;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            // 
            // btnBanUser
            // 
            this.btnBanUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBanUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBanUser.Location = new System.Drawing.Point(24, 732);
            this.btnBanUser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBanUser.Name = "btnBanUser";
            this.btnBanUser.Size = new System.Drawing.Size(200, 56);
            this.btnBanUser.TabIndex = 4;
            this.btnBanUser.Text = "禁止选中用户";
            this.btnBanUser.UseVisualStyleBackColor = false;
            this.btnBanUser.Click += new System.EventHandler(this.btnBanUser_Click);
            // 
            // btnUnbanUser
            // 
            this.btnUnbanUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUnbanUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUnbanUser.Location = new System.Drawing.Point(262, 732);
            this.btnUnbanUser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnUnbanUser.Name = "btnUnbanUser";
            this.btnUnbanUser.Size = new System.Drawing.Size(200, 56);
            this.btnUnbanUser.TabIndex = 5;
            this.btnUnbanUser.Text = "解禁选中用户";
            this.btnUnbanUser.UseVisualStyleBackColor = false;
            this.btnUnbanUser.Click += new System.EventHandler(this.btnUnbanUser_Click);
            // 
            // btnRefreshUserList
            // 
            this.btnRefreshUserList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshUserList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefreshUserList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefreshUserList.Location = new System.Drawing.Point(508, 732);
            this.btnRefreshUserList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRefreshUserList.Name = "btnRefreshUserList";
            this.btnRefreshUserList.Size = new System.Drawing.Size(200, 56);
            this.btnRefreshUserList.TabIndex = 6;
            this.btnRefreshUserList.Text = "刷新列表";
            this.btnRefreshUserList.UseVisualStyleBackColor = false;
            this.btnRefreshUserList.Click += new System.EventHandler(this.btnRefreshUserList_Click);
            // 
            // BanAccountPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1722, 842);
            this.Controls.Add(this.btnRefreshUserList);
            this.Controls.Add(this.btnUnbanUser);
            this.Controls.Add(this.btnBanUser);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnSearchUser);
            this.Controls.Add(this.txtSearchUser);
            this.Controls.Add(this.lblSearchUser);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "BanAccountPage";
            this.Text = "禁止/解禁用户账号";
            this.Load += new System.EventHandler(this.BanAccountPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchUser;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnBanUser;
        private System.Windows.Forms.Button btnUnbanUser;
        private System.Windows.Forms.Button btnRefreshUserList;
    }
} 