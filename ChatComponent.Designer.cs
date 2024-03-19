namespace ChatApp
{
    partial class ChatComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picMessage = new System.Windows.Forms.PictureBox();
            this.videoMessage = new LibVLCSharp.WinForms.VideoView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picMessage);
            this.panel1.Controls.Add(this.videoMessage);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 117);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // picMessage
            // 
            this.picMessage.BackColor = System.Drawing.Color.Lime;
            this.picMessage.Location = new System.Drawing.Point(25, 19);
            this.picMessage.Name = "picMessage";
            this.picMessage.Size = new System.Drawing.Size(197, 88);
            this.picMessage.TabIndex = 1;
            this.picMessage.TabStop = false;
            this.picMessage.Click += new System.EventHandler(this.picMessage_Click);
            // 
            // videoMessage
            // 
            this.videoMessage.BackColor = System.Drawing.Color.Black;
            this.videoMessage.Location = new System.Drawing.Point(228, 19);
            this.videoMessage.MediaPlayer = null;
            this.videoMessage.Name = "videoMessage";
            this.videoMessage.Size = new System.Drawing.Size(225, 88);
            this.videoMessage.TabIndex = 0;
            this.videoMessage.Text = "videoView1";
            this.videoMessage.Click += new System.EventHandler(this.videoMessage_Click);
            // 
            // ChatComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ChatComponent";
            this.Size = new System.Drawing.Size(475, 120);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoMessage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private LibVLCSharp.WinForms.VideoView videoMessage;
        private System.Windows.Forms.PictureBox picMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
