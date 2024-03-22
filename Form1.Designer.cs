namespace ChatApp
{
    partial class Form1
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
            this.txtChat = new System.Windows.Forms.TextBox();
            this.pnMainChat = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblCal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtChat
            // 
            this.txtChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChat.Location = new System.Drawing.Point(244, 412);
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(427, 26);
            this.txtChat.TabIndex = 0;
            // 
            // pnMainChat
            // 
            this.pnMainChat.AutoScroll = true;
            this.pnMainChat.Location = new System.Drawing.Point(124, 13);
            this.pnMainChat.Name = "pnMainChat";
            this.pnMainChat.Size = new System.Drawing.Size(664, 390);
            this.pnMainChat.TabIndex = 1;
            this.pnMainChat.Scroll += new System.Windows.Forms.ScrollEventHandler(this.pnMainChat_Scroll);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(677, 412);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(111, 26);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(124, 409);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(114, 26);
            this.btnFile.TabIndex = 3;
            this.btnFile.Text = "File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(12, 9);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(35, 13);
            this.lblLocation.TabIndex = 4;
            this.lblLocation.Text = "label1";
            this.lblLocation.Visible = false;
            // 
            // lblCal
            // 
            this.lblCal.AutoSize = true;
            this.lblCal.Location = new System.Drawing.Point(14, 38);
            this.lblCal.Name = "lblCal";
            this.lblCal.Size = new System.Drawing.Size(35, 13);
            this.lblCal.TabIndex = 5;
            this.lblCal.Text = "label1";
            this.lblCal.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCal);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.pnMainChat);
            this.Controls.Add(this.txtChat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.Panel pnMainChat;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblCal;
    }
}

