namespace QQChat
{
    partial class FriendListPage
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
            this.dgvFriendList = new System.Windows.Forms.DataGridView();
            this.btnDeleteFriend = new System.Windows.Forms.Button();
            this.btnChatWithFriend = new System.Windows.Forms.Button();
            this.btnRefreshFriendList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFriendList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFriendList
            // 
            this.dgvFriendList.AllowUserToAddRows = false;
            this.dgvFriendList.AllowUserToDeleteRows = false;
            this.dgvFriendList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFriendList.Location = new System.Drawing.Point(24, 22);
            this.dgvFriendList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvFriendList.MultiSelect = false;
            this.dgvFriendList.Name = "dgvFriendList";
            this.dgvFriendList.ReadOnly = true;
            this.dgvFriendList.RowHeadersWidth = 82;
            this.dgvFriendList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFriendList.Size = new System.Drawing.Size(1552, 646);
            this.dgvFriendList.TabIndex = 0;
            this.dgvFriendList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFriendList_CellContentClick);
            // 
            // btnDeleteFriend
            // 
            this.btnDeleteFriend.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteFriend.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteFriend.Location = new System.Drawing.Point(24, 702);
            this.btnDeleteFriend.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDeleteFriend.Name = "btnDeleteFriend";
            this.btnDeleteFriend.Size = new System.Drawing.Size(200, 56);
            this.btnDeleteFriend.TabIndex = 1;
            this.btnDeleteFriend.Text = "删除好友";
            this.btnDeleteFriend.UseVisualStyleBackColor = false;
            this.btnDeleteFriend.Click += new System.EventHandler(this.btnDeleteFriend_Click);
            // 
            // btnChatWithFriend
            // 
            this.btnChatWithFriend.BackColor = System.Drawing.Color.YellowGreen;
            this.btnChatWithFriend.Location = new System.Drawing.Point(264, 702);
            this.btnChatWithFriend.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnChatWithFriend.Name = "btnChatWithFriend";
            this.btnChatWithFriend.Size = new System.Drawing.Size(200, 56);
            this.btnChatWithFriend.TabIndex = 2;
            this.btnChatWithFriend.Text = "发起聊天";
            this.btnChatWithFriend.UseVisualStyleBackColor = false;
            this.btnChatWithFriend.Click += new System.EventHandler(this.btnChatWithFriend_Click);
            // 
            // btnRefreshFriendList
            // 
            this.btnRefreshFriendList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshFriendList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefreshFriendList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefreshFriendList.Location = new System.Drawing.Point(516, 702);
            this.btnRefreshFriendList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRefreshFriendList.Name = "btnRefreshFriendList";
            this.btnRefreshFriendList.Size = new System.Drawing.Size(200, 56);
            this.btnRefreshFriendList.TabIndex = 3;
            this.btnRefreshFriendList.Text = "刷新列表";
            this.btnRefreshFriendList.UseVisualStyleBackColor = false;
            this.btnRefreshFriendList.Click += new System.EventHandler(this.btnRefreshFriendList_Click);
            // 
            // FriendListPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 830);
            this.Controls.Add(this.btnRefreshFriendList);
            this.Controls.Add(this.btnChatWithFriend);
            this.Controls.Add(this.btnDeleteFriend);
            this.Controls.Add(this.dgvFriendList);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FriendListPage";
            this.Text = "好友列表";
            this.Load += new System.EventHandler(this.FriendListPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFriendList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFriendList;
        private System.Windows.Forms.Button btnDeleteFriend;
        private System.Windows.Forms.Button btnChatWithFriend;
        private System.Windows.Forms.Button btnRefreshFriendList;
    }
} 