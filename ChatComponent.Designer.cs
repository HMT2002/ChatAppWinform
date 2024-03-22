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
            this.lblDate = new System.Windows.Forms.Label();
            this.pnMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(249, 113);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(140, 15);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // pnMain
            // 
            this.pnMain.Location = new System.Drawing.Point(10, 10);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(378, 100);
            this.pnMain.TabIndex = 4;
            // 
            // ChatComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.lblDate);
            this.Name = "ChatComponent";
            this.Size = new System.Drawing.Size(400, 135);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel pnMain;
    }
}
