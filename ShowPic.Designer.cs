namespace ChatApp
{
    partial class ShowPic
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
            this.pcMainShowPic = new System.Windows.Forms.PictureBox();
            this.lblCoor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcMainShowPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pcMainShowPic
            // 
            this.pcMainShowPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcMainShowPic.Location = new System.Drawing.Point(0, 0);
            this.pcMainShowPic.Name = "pcMainShowPic";
            this.pcMainShowPic.Size = new System.Drawing.Size(310, 400);
            this.pcMainShowPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcMainShowPic.TabIndex = 0;
            this.pcMainShowPic.TabStop = false;
            this.pcMainShowPic.Click += new System.EventHandler(this.pcMainShowPic_Click);
            // 
            // lblCoor
            // 
            this.lblCoor.AutoSize = true;
            this.lblCoor.Location = new System.Drawing.Point(12, 6);
            this.lblCoor.Name = "lblCoor";
            this.lblCoor.Size = new System.Drawing.Size(35, 13);
            this.lblCoor.TabIndex = 1;
            this.lblCoor.Text = "label1";
            this.lblCoor.Visible = false;
            // 
            // ShowPic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 401);
            this.ControlBox = false;
            this.Controls.Add(this.lblCoor);
            this.Controls.Add(this.pcMainShowPic);
            this.Name = "ShowPic";
            this.Text = "(Click again to close)";
            this.Click += new System.EventHandler(this.ShowPic_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pcMainShowPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcMainShowPic;
        private System.Windows.Forms.Label lblCoor;
    }
}