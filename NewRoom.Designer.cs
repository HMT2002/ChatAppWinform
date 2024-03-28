namespace ChatApp
{
    partial class NewRoom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbbxOtherUsers = new System.Windows.Forms.ComboBox();
            this.lblCurrenUser = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblNoti = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbbxOtherUsers
            // 
            this.cbbxOtherUsers.FormattingEnabled = true;
            this.cbbxOtherUsers.Location = new System.Drawing.Point(16, 52);
            this.cbbxOtherUsers.Name = "cbbxOtherUsers";
            this.cbbxOtherUsers.Size = new System.Drawing.Size(352, 21);
            this.cbbxOtherUsers.TabIndex = 0;
            // 
            // lblCurrenUser
            // 
            this.lblCurrenUser.AutoSize = true;
            this.lblCurrenUser.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrenUser.Location = new System.Drawing.Point(12, 9);
            this.lblCurrenUser.Name = "lblCurrenUser";
            this.lblCurrenUser.Size = new System.Drawing.Size(53, 21);
            this.lblCurrenUser.TabIndex = 1;
            this.lblCurrenUser.Text = "label1";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(158, 103);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblNoti
            // 
            this.lblNoti.AutoSize = true;
            this.lblNoti.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoti.Location = new System.Drawing.Point(164, 9);
            this.lblNoti.Name = "lblNoti";
            this.lblNoti.Size = new System.Drawing.Size(53, 21);
            this.lblNoti.TabIndex = 3;
            this.lblNoti.Text = "label1";
            // 
            // NewRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 138);
            this.Controls.Add(this.lblNoti);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblCurrenUser);
            this.Controls.Add(this.cbbxOtherUsers);
            this.Name = "NewRoom";
            this.Text = "NewRoom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewRoom_FormClosing);
            this.Load += new System.EventHandler(this.NewRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbxOtherUsers;
        private System.Windows.Forms.Label lblCurrenUser;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblNoti;
    }
}