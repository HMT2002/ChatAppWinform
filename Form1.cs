using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ChatApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

        }

        private void btnFile_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMessage();
        }
        public void LoadMessage()
        {
            for (int i = 0; i < 5; i++)
            {
                ChatMessage chatMessage=new ChatMessage("", DateTime.Now, "", "", EnumTypeOfMessage.VIDEO);
                ChatComponent chatComponent = new ChatComponent(chatMessage);
                chatComponent.Location = new Point(10, 10 + 130 * i);

                pnMainChat.Controls.Add(chatComponent);

            }
        }
    }
}
