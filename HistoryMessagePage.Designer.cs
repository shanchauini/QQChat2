namespace QQChat
{
    partial class HistoryMessagePage
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
            this.lblSearchTime = new System.Windows.Forms.Label();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.lblSearchSender = new System.Windows.Forms.Label();
            this.txtSearchSenderId = new System.Windows.Forms.TextBox();
            this.lblSearchReceiver = new System.Windows.Forms.Label();
            this.txtSearchReceiverId = new System.Windows.Forms.TextBox();
            this.btnSearchHistory = new System.Windows.Forms.Button();
            this.dgvHistoryMessages = new System.Windows.Forms.DataGridView();
            this.btnDeleteHistoryMessage = new System.Windows.Forms.Button();
            this.btnRefreshHistoryList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryMessages)).BeginInit();
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
            this.txtSearchContent.Size = new System.Drawing.Size(196, 35);
            this.txtSearchContent.TabIndex = 1;
            // 
            // lblSearchTime
            // 
            this.lblSearchTime.AutoSize = true;
            this.lblSearchTime.Location = new System.Drawing.Point(380, 28);
            this.lblSearchTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSearchTime.Name = "lblSearchTime";
            this.lblSearchTime.Size = new System.Drawing.Size(118, 24);
            this.lblSearchTime.TabIndex = 2;
            this.lblSearchTime.Text = "发送时间:";
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartTime.Location = new System.Drawing.Point(510, 22);
            this.dtpStartTime.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(176, 35);
            this.dtpStartTime.TabIndex = 3;
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndTime.Location = new System.Drawing.Point(710, 22);
            this.dtpEndTime.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(176, 35);
            this.dtpEndTime.TabIndex = 4;
            // 
            // lblSearchSender
            // 
            this.lblSearchSender.AutoSize = true;
            this.lblSearchSender.Location = new System.Drawing.Point(920, 28);
            this.lblSearchSender.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSearchSender.Name = "lblSearchSender";
            this.lblSearchSender.Size = new System.Drawing.Size(118, 24);
            this.lblSearchSender.TabIndex = 5;
            this.lblSearchSender.Text = "发送者ID:";
            // 
            // txtSearchSenderId
            // 
            this.txtSearchSenderId.Location = new System.Drawing.Point(1050, 22);
            this.txtSearchSenderId.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSearchSenderId.Name = "txtSearchSenderId";
            this.txtSearchSenderId.Size = new System.Drawing.Size(116, 35);
            this.txtSearchSenderId.TabIndex = 6;
            // 
            // lblSearchReceiver
            // 
            this.lblSearchReceiver.AutoSize = true;
            this.lblSearchReceiver.Location = new System.Drawing.Point(1200, 28);
            this.lblSearchReceiver.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSearchReceiver.Name = "lblSearchReceiver";
            this.lblSearchReceiver.Size = new System.Drawing.Size(118, 24);
            this.lblSearchReceiver.TabIndex = 7;
            this.lblSearchReceiver.Text = "接收者ID:";
            // 
            // txtSearchReceiverId
            // 
            this.txtSearchReceiverId.Location = new System.Drawing.Point(1330, 22);
            this.txtSearchReceiverId.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSearchReceiverId.Name = "txtSearchReceiverId";
            this.txtSearchReceiverId.Size = new System.Drawing.Size(116, 35);
            this.txtSearchReceiverId.TabIndex = 8;
            // 
            // btnSearchHistory
            // 
            this.btnSearchHistory.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSearchHistory.Location = new System.Drawing.Point(1480, 18);
            this.btnSearchHistory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSearchHistory.Name = "btnSearchHistory";
            this.btnSearchHistory.Size = new System.Drawing.Size(100, 42);
            this.btnSearchHistory.TabIndex = 9;
            this.btnSearchHistory.Text = "查询";
            this.btnSearchHistory.UseVisualStyleBackColor = false;
            this.btnSearchHistory.Click += new System.EventHandler(this.btnSearchHistory_Click);
            // 
            // dgvHistoryMessages
            // 
            this.dgvHistoryMessages.AllowUserToAddRows = false;
            this.dgvHistoryMessages.AllowUserToDeleteRows = false;
            this.dgvHistoryMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoryMessages.Location = new System.Drawing.Point(24, 84);
            this.dgvHistoryMessages.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvHistoryMessages.MultiSelect = false;
            this.dgvHistoryMessages.Name = "dgvHistoryMessages";
            this.dgvHistoryMessages.ReadOnly = true;
            this.dgvHistoryMessages.RowHeadersWidth = 82;
            this.dgvHistoryMessages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistoryMessages.Size = new System.Drawing.Size(1552, 586);
            this.dgvHistoryMessages.TabIndex = 10;
            this.dgvHistoryMessages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistoryMessages_CellContentClick);
            // 
            // btnDeleteHistoryMessage
            // 
            this.btnDeleteHistoryMessage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteHistoryMessage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteHistoryMessage.Location = new System.Drawing.Point(24, 702);
            this.btnDeleteHistoryMessage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDeleteHistoryMessage.Name = "btnDeleteHistoryMessage";
            this.btnDeleteHistoryMessage.Size = new System.Drawing.Size(200, 56);
            this.btnDeleteHistoryMessage.TabIndex = 11;
            this.btnDeleteHistoryMessage.Text = "删除选中消息";
            this.btnDeleteHistoryMessage.UseVisualStyleBackColor = false;
            this.btnDeleteHistoryMessage.Visible = false;
            this.btnDeleteHistoryMessage.Click += new System.EventHandler(this.btnDeleteHistoryMessage_Click);
            // 
            // btnRefreshHistoryList
            // 
            this.btnRefreshHistoryList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshHistoryList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefreshHistoryList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefreshHistoryList.Location = new System.Drawing.Point(272, 702);
            this.btnRefreshHistoryList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRefreshHistoryList.Name = "btnRefreshHistoryList";
            this.btnRefreshHistoryList.Size = new System.Drawing.Size(200, 56);
            this.btnRefreshHistoryList.TabIndex = 12;
            this.btnRefreshHistoryList.Text = "刷新列表";
            this.btnRefreshHistoryList.UseVisualStyleBackColor = false;
            this.btnRefreshHistoryList.Click += new System.EventHandler(this.btnRefreshHistoryList_Click);
            // 
            // HistoryMessagePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 830);
            this.Controls.Add(this.btnRefreshHistoryList);
            this.Controls.Add(this.btnDeleteHistoryMessage);
            this.Controls.Add(this.dgvHistoryMessages);
            this.Controls.Add(this.btnSearchHistory);
            this.Controls.Add(this.txtSearchReceiverId);
            this.Controls.Add(this.lblSearchReceiver);
            this.Controls.Add(this.txtSearchSenderId);
            this.Controls.Add(this.lblSearchSender);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.lblSearchTime);
            this.Controls.Add(this.txtSearchContent);
            this.Controls.Add(this.lblSearchContent);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "HistoryMessagePage";
            this.Text = "历史消息";
            this.Load += new System.EventHandler(this.HistoryMessagePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryMessages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchContent;
        private System.Windows.Forms.TextBox txtSearchContent;
        private System.Windows.Forms.Label lblSearchTime;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Label lblSearchSender;
        private System.Windows.Forms.TextBox txtSearchSenderId;
        private System.Windows.Forms.Label lblSearchReceiver;
        private System.Windows.Forms.TextBox txtSearchReceiverId;
        private System.Windows.Forms.Button btnSearchHistory;
        private System.Windows.Forms.DataGridView dgvHistoryMessages;
        private System.Windows.Forms.Button btnDeleteHistoryMessage;
        private System.Windows.Forms.Button btnRefreshHistoryList;
    }
} 