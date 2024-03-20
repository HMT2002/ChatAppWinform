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
            for (int i = 0; i < 9; i++)
            {
                ChatMessage chatMessage=new ChatMessage("", DateTime.Now, "", "", EnumTypeOfMessage.VIDEO);
                if (i % 2 == 0)
                {
                    chatMessage= new ChatMessage("", DateTime.Now, "", "", EnumTypeOfMessage.IMAGE);
                }


                if (i % 7== 0)
                {
                    ChatComponent chatComponent = new ChatComponent(chatMessage);
                    chatComponent.Location = new Point(200, 10 + 150 * i);
                pnMainChat.Controls.Add(chatComponent);

                }
                else
                {
                ChatComponentOther chatComponent = new ChatComponentOther(chatMessage);
                chatComponent.Location = new Point(10, 10 + 150 * i);
                pnMainChat.Controls.Add(chatComponent);
                }


            }
        }
    }
}
