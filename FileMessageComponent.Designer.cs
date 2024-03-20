namespace ChatApp
{
    partial class FileMessageComponent
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
            this.lblFileName = new System.Windows.Forms.Label();
            this.picFile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFile)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFileName
            // 
            this.lblFileName.Location = new System.Drawing.Point(125, 60);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(100, 23);
            this.lblFileName.TabIndex = 3;
            this.lblFileName.Text = "File name";
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picFile
            // 
            this.picFile.BackgroundImage = global::ChatApp.Properties.Resources.I4cXsB;
            this.picFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picFile.Location = new System.Drawing.Point(125, 7);
            this.picFile.Name = "picFile";
            this.picFile.Size = new System.Drawing.Size(100, 50);
            this.picFile.TabIndex = 2;
            this.picFile.TabStop = false;
            // 
            // FileMessageComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.picFile);
            this.Name = "FileMessageComponent";
            this.Size = new System.Drawing.Size(350, 90);
            ((System.ComponentModel.ISupportInitialize)(this.picFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.PictureBox picFile;
    }
}
