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
            this.pnMainChat = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblCal = new System.Windows.Forms.Label();
            this.pnIcon = new System.Windows.Forms.Panel();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picOpenIcon = new System.Windows.Forms.PictureBox();
            this.txtChat = new System.Windows.Forms.RichTextBox();
            this.lstvwRoom = new System.Windows.Forms.ListView();
            this.rchtxtDebug = new System.Windows.Forms.RichTextBox();
            this.lstvwOtherUser = new System.Windows.Forms.ListView();
            this.btnCreateRoom = new System.Windows.Forms.Button();
            this.lblCurrentRoom = new System.Windows.Forms.Label();
            this.lblChatMate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOpenIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMainChat
            // 
            this.pnMainChat.AutoScroll = true;
            this.pnMainChat.Location = new System.Drawing.Point(168, 27);
            this.pnMainChat.Name = "pnMainChat";
            this.pnMainChat.Size = new System.Drawing.Size(868, 465);
            this.pnMainChat.TabIndex = 1;
            this.pnMainChat.Scroll += new System.Windows.Forms.ScrollEventHandler(this.pnMainChat_Scroll);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(925, 3);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(111, 26);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(168, 3);
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
            this.lblLocation.Location = new System.Drawing.Point(83, 16);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(35, 13);
            this.lblLocation.TabIndex = 4;
            this.lblLocation.Text = "label1";
            this.lblLocation.Visible = false;
            // 
            // lblCal
            // 
            this.lblCal.AutoSize = true;
            this.lblCal.Location = new System.Drawing.Point(23, 16);
            this.lblCal.Name = "lblCal";
            this.lblCal.Size = new System.Drawing.Size(35, 13);
            this.lblCal.TabIndex = 5;
            this.lblCal.Text = "label1";
            this.lblCal.Visible = false;
            // 
            // pnIcon
            // 
            this.pnIcon.Controls.Add(this.pictureBox10);
            this.pnIcon.Controls.Add(this.pictureBox11);
            this.pnIcon.Controls.Add(this.pictureBox12);
            this.pnIcon.Controls.Add(this.pictureBox7);
            this.pnIcon.Controls.Add(this.pictureBox8);
            this.pnIcon.Controls.Add(this.pictureBox9);
            this.pnIcon.Controls.Add(this.pictureBox4);
            this.pnIcon.Controls.Add(this.pictureBox5);
            this.pnIcon.Controls.Add(this.pictureBox6);
            this.pnIcon.Controls.Add(this.pictureBox3);
            this.pnIcon.Controls.Add(this.pictureBox2);
            this.pnIcon.Controls.Add(this.pictureBox1);
            this.pnIcon.Location = new System.Drawing.Point(816, 366);
            this.pnIcon.Name = "pnIcon";
            this.pnIcon.Size = new System.Drawing.Size(103, 129);
            this.pnIcon.TabIndex = 6;
            this.pnIcon.Visible = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = global::ChatApp.Properties.Resources.FeelsOkayMan;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox10.Location = new System.Drawing.Point(14, 98);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(21, 24);
            this.pictureBox10.TabIndex = 18;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImage = global::ChatApp.Properties.Resources.FeelsOkayMan;
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox11.Location = new System.Drawing.Point(68, 98);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(21, 24);
            this.pictureBox11.TabIndex = 17;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackgroundImage = global::ChatApp.Properties.Resources.FeelsOkayMan;
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox12.Location = new System.Drawing.Point(41, 98);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(21, 24);
            this.pictureBox12.TabIndex = 16;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::ChatApp.Properties.Resources.FeelsOkayMan;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.Location = new System.Drawing.Point(14, 69);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(21, 24);
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = global::ChatApp.Properties.Resources.FeelsOkayMan;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox8.Location = new System.Drawing.Point(68, 69);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(21, 24);
            this.pictureBox8.TabIndex = 14;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = global::ChatApp.Properties.Resources.FeelsOkayMan;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox9.Location = new System.Drawing.Point(41, 69);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(21, 24);
            this.pictureBox9.TabIndex = 13;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::ChatApp.Properties.Resources.FeelsOkayMan;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(14, 39);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(21, 24);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::ChatApp.Properties.Resources.FeelsOkayMan;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(68, 39);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(21, 24);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::ChatApp.Properties.Resources.FeelsOkayMan;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(41, 39);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(21, 24);
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::ChatApp.Properties.Resources.FeelsOkayMan;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(14, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 24);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ChatApp.Properties.Resources.FeelsOkayMan;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(68, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 24);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ChatApp.Properties.Resources.FeelsOkayMan;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(41, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 24);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // picOpenIcon
            // 
            this.picOpenIcon.BackgroundImage = global::ChatApp.Properties.Resources.FeelsOkayMan;
            this.picOpenIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picOpenIcon.Location = new System.Drawing.Point(881, 8);
            this.picOpenIcon.Name = "picOpenIcon";
            this.picOpenIcon.Size = new System.Drawing.Size(24, 18);
            this.picOpenIcon.TabIndex = 7;
            this.picOpenIcon.TabStop = false;
            this.picOpenIcon.Click += new System.EventHandler(this.picOpenIcon_Click_1);
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(296, 3);
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(623, 26);
            this.txtChat.TabIndex = 8;
            this.txtChat.Text = "";
            // 
            // lstvwRoom
            // 
            this.lstvwRoom.FullRowSelect = true;
            this.lstvwRoom.HideSelection = false;
            this.lstvwRoom.Location = new System.Drawing.Point(7, 27);
            this.lstvwRoom.Name = "lstvwRoom";
            this.lstvwRoom.Size = new System.Drawing.Size(155, 134);
            this.lstvwRoom.TabIndex = 9;
            this.lstvwRoom.UseCompatibleStateImageBehavior = false;
            this.lstvwRoom.View = System.Windows.Forms.View.List;
            this.lstvwRoom.SelectedIndexChanged += new System.EventHandler(this.lstvwRoom_SelectedIndexChanged);
            // 
            // rchtxtDebug
            // 
            this.rchtxtDebug.Location = new System.Drawing.Point(7, 375);
            this.rchtxtDebug.Name = "rchtxtDebug";
            this.rchtxtDebug.Size = new System.Drawing.Size(155, 108);
            this.rchtxtDebug.TabIndex = 10;
            this.rchtxtDebug.Text = "";
            this.rchtxtDebug.Visible = false;
            // 
            // lstvwOtherUser
            // 
            this.lstvwOtherUser.FullRowSelect = true;
            this.lstvwOtherUser.HideSelection = false;
            this.lstvwOtherUser.Location = new System.Drawing.Point(7, 167);
            this.lstvwOtherUser.Name = "lstvwOtherUser";
            this.lstvwOtherUser.Size = new System.Drawing.Size(155, 141);
            this.lstvwOtherUser.TabIndex = 11;
            this.lstvwOtherUser.UseCompatibleStateImageBehavior = false;
            this.lstvwOtherUser.View = System.Windows.Forms.View.List;
            // 
            // btnCreateRoom
            // 
            this.btnCreateRoom.Location = new System.Drawing.Point(7, 314);
            this.btnCreateRoom.Name = "btnCreateRoom";
            this.btnCreateRoom.Size = new System.Drawing.Size(111, 23);
            this.btnCreateRoom.TabIndex = 12;
            this.btnCreateRoom.Text = "Tạo phòng chat";
            this.btnCreateRoom.UseVisualStyleBackColor = true;
            this.btnCreateRoom.Click += new System.EventHandler(this.btnCreateRoom_Click);
            // 
            // lblCurrentRoom
            // 
            this.lblCurrentRoom.AutoSize = true;
            this.lblCurrentRoom.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentRoom.Location = new System.Drawing.Point(12, 340);
            this.lblCurrentRoom.Name = "lblCurrentRoom";
            this.lblCurrentRoom.Size = new System.Drawing.Size(83, 15);
            this.lblCurrentRoom.TabIndex = 13;
            this.lblCurrentRoom.Text = "Current room: ";
            // 
            // lblChatMate
            // 
            this.lblChatMate.AutoSize = true;
            this.lblChatMate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChatMate.Location = new System.Drawing.Point(12, 355);
            this.lblChatMate.Name = "lblChatMate";
            this.lblChatMate.Size = new System.Drawing.Size(63, 15);
            this.lblChatMate.TabIndex = 14;
            this.lblChatMate.Text = "Chatmate: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.btnFile);
            this.panel1.Controls.Add(this.lblLocation);
            this.panel1.Controls.Add(this.lblCal);
            this.panel1.Controls.Add(this.picOpenIcon);
            this.panel1.Controls.Add(this.txtChat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 501);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 41);
            this.panel1.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1048, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightToolStripMenuItem,
            this.toolStripSeparator1,
            this.darkToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.lightToolStripMenuItem.Text = "Light";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.lightToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(98, 6);
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 542);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblChatMate);
            this.Controls.Add(this.lblCurrentRoom);
            this.Controls.Add(this.btnCreateRoom);
            this.Controls.Add(this.lstvwOtherUser);
            this.Controls.Add(this.rchtxtDebug);
            this.Controls.Add(this.lstvwRoom);
            this.Controls.Add(this.pnIcon);
            this.Controls.Add(this.pnMainChat);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOpenIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnMainChat;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblCal;
        private System.Windows.Forms.Panel pnIcon;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picOpenIcon;
        private System.Windows.Forms.RichTextBox txtChat;
        private System.Windows.Forms.ListView lstvwRoom;
        private System.Windows.Forms.RichTextBox rchtxtDebug;
        private System.Windows.Forms.ListView lstvwOtherUser;
        private System.Windows.Forms.Button btnCreateRoom;
        private System.Windows.Forms.Label lblCurrentRoom;
        private System.Windows.Forms.Label lblChatMate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}

