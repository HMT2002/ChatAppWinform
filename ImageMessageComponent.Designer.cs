namespace ChatApp
{
    partial class ImageMessageComponent
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
            this.picMessage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // picMessage
            // 
            this.picMessage.BackColor = System.Drawing.Color.Transparent;
            this.picMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMessage.Location = new System.Drawing.Point(3, 1);
            this.picMessage.Name = "picMessage";
            this.picMessage.Size = new System.Drawing.Size(344, 88);
            this.picMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMessage.TabIndex = 2;
            this.picMessage.TabStop = false;
            this.picMessage.Click += new System.EventHandler(this.picMessage_Click);
            // 
            // ImageMessageComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picMessage);
            this.Name = "ImageMessageComponent";
            this.Size = new System.Drawing.Size(350, 90);
            ((System.ComponentModel.ISupportInitialize)(this.picMessage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMessage;
    }
}
