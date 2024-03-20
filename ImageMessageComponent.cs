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
            Image temp = Image.FromFile(@"C:\Users\blues\Pictures\dom.jpg");
            show = new ShowPic(temp, Cursor.Position);
            show.Location = new Point(Cursor.Position.X - 165, Cursor.Position.Y - 210);
            show.WindowState = FormWindowState.Normal;
            show.StartPosition = FormStartPosition.Manual;
            show.Show();
        }

        public void initImage()
        {
            picMessage.BringToFront();
            picMessage.Image = Image.FromFile(@"C:\Users\blues\Pictures\dom.jpg");
        }



        #endregion
    }
}
