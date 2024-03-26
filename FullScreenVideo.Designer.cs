namespace ChatApp
{
    partial class FullScreenVideo
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
            this.videoFull = new LibVLCSharp.WinForms.VideoView();
            this.picPlay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.videoFull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // videoFull
            // 
            this.videoFull.BackColor = System.Drawing.Color.Black;
            this.videoFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoFull.Location = new System.Drawing.Point(0, 0);
            this.videoFull.MediaPlayer = null;
            this.videoFull.Name = "videoFull";
            this.videoFull.Size = new System.Drawing.Size(1384, 821);
            this.videoFull.TabIndex = 0;
            this.videoFull.Text = "videoView1";
            this.videoFull.Click += new System.EventHandler(this.videoFull_Click);
            // 
            // picPlay
            // 
            this.picPlay.BackColor = System.Drawing.Color.Transparent;
            this.picPlay.BackgroundImage = global::ChatApp.Properties.Resources._8T65a4KGc;
            this.picPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picPlay.Location = new System.Drawing.Point(700, 430);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(62, 59);
            this.picPlay.TabIndex = 6;
            this.picPlay.TabStop = false;
            this.picPlay.Visible = false;
            this.picPlay.Click += new System.EventHandler(this.picPlay_Click);
            // 
            // FullScreenVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 821);
            this.Controls.Add(this.picPlay);
            this.Controls.Add(this.videoFull);
            this.Name = "FullScreenVideo";
            this.Text = "FullScreenVideo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FullScreenVideo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.videoFull)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LibVLCSharp.WinForms.VideoView videoFull;
        private System.Windows.Forms.PictureBox picPlay;
    }
}