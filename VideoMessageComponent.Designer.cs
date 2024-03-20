namespace ChatApp
{
    partial class VideoMessageComponent
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
            this.videoMessage = new LibVLCSharp.WinForms.VideoView();
            this.picPlay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.videoMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // videoMessage
            // 
            this.videoMessage.BackColor = System.Drawing.Color.Black;
            this.videoMessage.Location = new System.Drawing.Point(3, 1);
            this.videoMessage.MediaPlayer = null;
            this.videoMessage.Name = "videoMessage";
            this.videoMessage.Size = new System.Drawing.Size(344, 85);
            this.videoMessage.TabIndex = 1;
            this.videoMessage.Text = "videoView1";
            this.videoMessage.Click += new System.EventHandler(this.videoMessage_Click);
            // 
            // picPlay
            // 
            this.picPlay.BackColor = System.Drawing.Color.Transparent;
            this.picPlay.BackgroundImage = global::ChatApp.Properties.Resources._8T65a4KGc;
            this.picPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picPlay.Location = new System.Drawing.Point(144, 16);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(62, 59);
            this.picPlay.TabIndex = 5;
            this.picPlay.TabStop = false;
            this.picPlay.Click += new System.EventHandler(this.picPlay_Click);
            // 
            // VideoMessageComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picPlay);
            this.Controls.Add(this.videoMessage);
            this.Name = "VideoMessageComponent";
            this.Size = new System.Drawing.Size(350, 90);
            this.Load += new System.EventHandler(this.VideoMessageComponent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videoMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LibVLCSharp.WinForms.VideoView videoMessage;
        private System.Windows.Forms.PictureBox picPlay;
    }
}
