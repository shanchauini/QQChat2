namespace QQChat
{
    partial class ReviewRegistrationPage
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
            this.dgvPendingRegistrations = new System.Windows.Forms.DataGridView();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingRegistrations)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPendingRegistrations
            // 
            this.dgvPendingRegistrations.AllowUserToAddRows = false;
            this.dgvPendingRegistrations.AllowUserToDeleteRows = false;
            this.dgvPendingRegistrations.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPendingRegistrations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendingRegistrations.Location = new System.Drawing.Point(24, 22);
            this.dgvPendingRegistrations.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvPendingRegistrations.MultiSelect = false;
            this.dgvPendingRegistrations.Name = "dgvPendingRegistrations";
            this.dgvPendingRegistrations.ReadOnly = true;
            this.dgvPendingRegistrations.RowHeadersWidth = 82;
            this.dgvPendingRegistrations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPendingRegistrations.Size = new System.Drawing.Size(1409, 661);
            this.dgvPendingRegistrations.TabIndex = 0;
            this.dgvPendingRegistrations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPendingRegistrations_CellContentClick);
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnApprove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnApprove.Location = new System.Drawing.Point(24, 702);
            this.btnApprove.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(206, 66);
            this.btnApprove.TabIndex = 1;
            this.btnApprove.Text = "通过";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReject.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReject.Location = new System.Drawing.Point(264, 702);
            this.btnReject.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(209, 66);
            this.btnReject.TabIndex = 2;
            this.btnReject.Text = "驳回";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.Location = new System.Drawing.Point(1225, 702);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(212, 66);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ReviewRegistrationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 828);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.dgvPendingRegistrations);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ReviewRegistrationPage";
            this.Text = "审核注册申请";
            this.Load += new System.EventHandler(this.ReviewRegistrationPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingRegistrations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPendingRegistrations;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnRefresh;
    }
} 