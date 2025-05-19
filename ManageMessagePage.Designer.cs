namespace QQChat
{
    partial class ManageMessagePage
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
            this.lblSearchContent = new System.Windows.Forms.Label();
            this.txtSearchContent = new System.Windows.Forms.TextBox();
            this.lblSearchSenderId = new System.Windows.Forms.Label();
            this.txtSearchSenderId = new System.Windows.Forms.TextBox();
            this.btnSearchMessages = new System.Windows.Forms.Button();
            this.dgvMessages = new System.Windows.Forms.DataGridView();
            this.btnDeleteMessage = new System.Windows.Forms.Button();
            this.btnRefreshMessageList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchContent
            // 
            this.lblSearchContent.AutoSize = true;
            this.lblSearchContent.Location = new System.Drawing.Point(24, 28);
            this.lblSearchContent.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSearchContent.Name = "lblSearchContent";
            this.lblSearchContent.Size = new System.Drawing.Size(118, 24);
            this.lblSearchContent.TabIndex = 0;
            this.lblSearchContent.Text = "消息内容:";
            // 
            // txtSearchContent
            // 
            this.txtSearchContent.Location = new System.Drawing.Point(154, 22);
            this.txtSearchContent.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSearchContent.Name = "txtSearchContent";
            this.txtSearchContent.Size = new System.Drawing.Size(296, 35);
            this.txtSearchContent.TabIndex = 1;
            // 
            // lblSearchSenderId
            // 
            this.lblSearchSenderId.AutoSize = true;
            this.lblSearchSenderId.Location = new System.Drawing.Point(480, 28);
            this.lblSearchSenderId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSearchSenderId.Name = "lblSearchSenderId";
            this.lblSearchSenderId.Size = new System.Drawing.Size(118, 24);
            this.lblSearchSenderId.TabIndex = 2;
            this.lblSearchSenderId.Text = "发送者ID:";
            // 
            // txtSearchSenderId
            // 
            this.txtSearchSenderId.Location = new System.Drawing.Point(610, 22);
            this.txtSearchSenderId.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSearchSenderId.Name = "txtSearchSenderId";
            this.txtSearchSenderId.Size = new System.Drawing.Size(196, 35);
            this.txtSearchSenderId.TabIndex = 3;
            // 
            // btnSearchMessages
            // 
            this.btnSearchMessages.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSearchMessages.Location = new System.Drawing.Point(840, 18);
            this.btnSearchMessages.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSearchMessages.Name = "btnSearchMessages";
            this.btnSearchMessages.Size = new System.Drawing.Size(150, 42);
            this.btnSearchMessages.TabIndex = 4;
            this.btnSearchMessages.Text = "搜索消息";
            this.btnSearchMessages.UseVisualStyleBackColor = false;
            this.btnSearchMessages.Click += new System.EventHandler(this.btnSearchMessages_Click);
            // 
            // dgvMessages
            // 
            this.dgvMessages.AllowUserToAddRows = false;
            this.dgvMessages.AllowUserToDeleteRows = false;
            this.dgvMessages.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMessages.Location = new System.Drawing.Point(24, 84);
            this.dgvMessages.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvMessages.MultiSelect = false;
            this.dgvMessages.Name = "dgvMessages";
            this.dgvMessages.ReadOnly = true;
            this.dgvMessages.RowHeadersWidth = 82;
            this.dgvMessages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMessages.Size = new System.Drawing.Size(1813, 606);
            this.dgvMessages.TabIndex = 5;
            this.dgvMessages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMessages_CellContentClick);
            // 
            // btnDeleteMessage
            // 
            this.btnDeleteMessage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteMessage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteMessage.Location = new System.Drawing.Point(24, 702);
            this.btnDeleteMessage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDeleteMessage.Name = "btnDeleteMessage";
            this.btnDeleteMessage.Size = new System.Drawing.Size(200, 56);
            this.btnDeleteMessage.TabIndex = 6;
            this.btnDeleteMessage.Text = "删除选中消息";
            this.btnDeleteMessage.UseVisualStyleBackColor = false;
            this.btnDeleteMessage.Click += new System.EventHandler(this.btnDeleteMessage_Click);
            // 
            // btnRefreshMessageList
            // 
            this.btnRefreshMessageList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshMessageList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefreshMessageList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefreshMessageList.Location = new System.Drawing.Point(351, 702);
            this.btnRefreshMessageList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRefreshMessageList.Name = "btnRefreshMessageList";
            this.btnRefreshMessageList.Size = new System.Drawing.Size(200, 56);
            this.btnRefreshMessageList.TabIndex = 7;
            this.btnRefreshMessageList.Text = "刷新列表";
            this.btnRefreshMessageList.UseVisualStyleBackColor = false;
            this.btnRefreshMessageList.Click += new System.EventHandler(this.btnRefreshMessageList_Click);
            // 
            // ManageMessagePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1864, 847);
            this.Controls.Add(this.btnRefreshMessageList);
            this.Controls.Add(this.btnDeleteMessage);
            this.Controls.Add(this.dgvMessages);
            this.Controls.Add(this.btnSearchMessages);
            this.Controls.Add(this.txtSearchSenderId);
            this.Controls.Add(this.lblSearchSenderId);
            this.Controls.Add(this.txtSearchContent);
            this.Controls.Add(this.lblSearchContent);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ManageMessagePage";
            this.Text = "管理交流信息";
            this.Load += new System.EventHandler(this.ManageMessagePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchContent;
        private System.Windows.Forms.TextBox txtSearchContent;
        private System.Windows.Forms.Label lblSearchSenderId;
        private System.Windows.Forms.TextBox txtSearchSenderId;
        private System.Windows.Forms.Button btnSearchMessages;
        private System.Windows.Forms.DataGridView dgvMessages;
        private System.Windows.Forms.Button btnDeleteMessage;
        private System.Windows.Forms.Button btnRefreshMessageList;
    }
} 