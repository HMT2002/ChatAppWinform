using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
    public partial class ImageMessageComponent : UserControl
    {
        public ImageMessageComponent()
        {
            InitializeComponent();
            initImage();
        }
        public ChatMessage chatMessage;
        public ImageMessageComponent(ChatMessage chatMessage)
        {
            InitializeComponent();
            this.chatMessage = chatMessage;
            initImage();
        }
        #region picture message
        ShowPic show = new ShowPic();
        private void picMessage_Click(object sender, EventArgs e)
        {
            Image temp = Image.FromFile(this.chatMessage.Text);
            show = new ShowPic(temp, Cursor.Position);
            show.Location = new Point(Cursor.Position.X - 165, Cursor.Position.Y - 210);
            show.WindowState = FormWindowState.Normal;
            show.StartPosition = FormStartPosition.Manual;
            show.Show();
        }

        public void initImage()
        {
            picMessage.BringToFront();
            picMessage.Image = Image.FromFile(this.chatMessage.Text);
        }



        #endregion

        private void ImageMessageComponent_Load(object sender, EventArgs e)
        {

        }
        private void OnDispose(object sender, EventArgs e)
        {
            MessageBox.Show("Image dispose");
        }

    }
}
