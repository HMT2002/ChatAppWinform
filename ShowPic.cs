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
    public partial class ShowPic : Form
    {
        public ShowPic()
        {
            InitializeComponent();
        }
        public ShowPic(Image image)
        {
            InitializeComponent();
            pcMainShowPic.Image = image;
            pcMainShowPic.BackgroundImageLayout = ImageLayout.Zoom;

        }
        public ShowPic(Image image,Point cursor)
        {
            InitializeComponent();
            pcMainShowPic.Image = image;
            pcMainShowPic.BackgroundImageLayout = ImageLayout.Zoom;
            lblCoor.Text="X: "+cursor.X+"; Y: "+cursor.Y;
        }

        private void pcMainShowPic_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowPic_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
