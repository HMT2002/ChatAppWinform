using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        List<ChatMessage> messages = new List<ChatMessage> {
            new ChatMessage("../../fumo.mp4", DateTime.Now, "", "", EnumTypeOfMessage.VIDEO),
            new ChatMessage(@"C:\Users\blues\Downloads\3-Thuộc tính chất lượng.pptx", DateTime.Now, "", "", EnumTypeOfMessage.FILE),
            new ChatMessage("../../fumo.mp4", DateTime.Now, "", "", EnumTypeOfMessage.VIDEO),
            new ChatMessage(@"C:\Users\blues\Pictures\dom.jpg", DateTime.Now, "", "", EnumTypeOfMessage.IMAGE),
            new ChatMessage("../../fumo.mp4", DateTime.Now, "", "", EnumTypeOfMessage.VIDEO),
            new ChatMessage("chào buổi sáng", DateTime.Now, "", "", EnumTypeOfMessage.TEXT),
            new ChatMessage("../../fumo.mp4", DateTime.Now, "", "", EnumTypeOfMessage.VIDEO),
            new ChatMessage(@"C:\Users\blues\Downloads\3-Thuộc tính chất lượng.pptx", DateTime.Now, "", "", EnumTypeOfMessage.FILE),
            new ChatMessage("../../fumo.mp4", DateTime.Now, "", "", EnumTypeOfMessage.VIDEO),
        };
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtChat.Text.Trim().CompareTo(string.Empty) == 0)
            {
                return;
            }
            AddToMessageList(new ChatMessage()
            {
                Text = txtChat.Text,
                Date = DateTime.Now,
                Receiver = "",
                Sender = "",
                TypeOfMessage = EnumTypeOfMessage.TEXT
            }); ;
            txtChat.Text = "";

        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            ;
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Multiselect = false;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string ext = Path.GetExtension(dialog.FileName);
                    if (ext == ".mp4" || ext == ".mp3" || ext == ".mkv" || ext == ".webm")
                    {
                        AddToMessageList(new ChatMessage()
                        {
                            Text = dialog.FileName,
                            Date = DateTime.Now,
                            Receiver = "",
                            Sender = "",
                            TypeOfMessage = EnumTypeOfMessage.VIDEO
                        }); ;
                    }
                    else if (ext == ".png" || ext == ".jpg" || ext == ".jpeg" || ext == ".gif" || ext == ".webp")
                    {
                        AddToMessageList(new ChatMessage()
                        {
                            Text = dialog.FileName,
                            Date = DateTime.Now,
                            Receiver = "",
                            Sender = "",
                            TypeOfMessage = EnumTypeOfMessage.IMAGE
                        }); ;
                    }
                    else
                    {
                        AddToMessageList(new ChatMessage()
                        {
                            Text = dialog.FileName,
                            Date = DateTime.Now,
                            Receiver = "",
                            Sender = "",
                            TypeOfMessage = EnumTypeOfMessage.FILE
                        }); ;
                    }
                }





            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMessage();
        }
        public void LoadMessage()
        {

            for (int i = 0; i < messages.Count; i++)
            {
                bool mine = true;
                if (i % 7 == 0)
                {
                    mine = false;
                }

                AddMessageComponent(mine, messages[i], i);

            }
        }
        public void AddToMessageList(ChatMessage message)
        {
            this.messages.Add(message);
            int position = this.messages.Count;
            AddMessageComponent(true, message, this.messages.Count - 1);
            lblLocation.Text = "X: " + pnMainChat.DisplayRectangle.Location.X.ToString() + "; Y: " + pnMainChat.DisplayRectangle.Location.Y.ToString() + "Height: " + pnMainChat.Height + ", glob = " + glob.ToString() + ", new po = " + (10 + 150 * position).ToString();
            lblCal.Text = " new po = " + (10 + 150 * position).ToString() + " + " + pnMainChat.DisplayRectangle.Location.Y.ToString() + " = " + (10 + 150 * position + pnMainChat.DisplayRectangle.Location.Y).ToString();

        }
        int glob = 0;
        public void AddMessageComponent(bool mine = true, ChatMessage chatMessage = null, int index = 0)
        {


            if (mine)
            {
                ChatComponent chatComponent = new ChatComponent(chatMessage);
                chatComponent.Location = new Point(200, (10 + 150 * index) + pnMainChat.DisplayRectangle.Location.Y);
                pnMainChat.Controls.Add(chatComponent);
                pnMainChat.ScrollControlIntoView(chatComponent);

            }
            else
            {
                ChatComponentOther chatComponent = new ChatComponentOther(chatMessage);
                chatComponent.Location = new Point(10, (10 + 150 * index) + pnMainChat.DisplayRectangle.Location.Y);
                pnMainChat.Controls.Add(chatComponent);
                pnMainChat.ScrollControlIntoView(chatComponent);
            }
            glob = 10 + 150 * index;
        }

        private void pnMainChat_Scroll(object sender, ScrollEventArgs e)
        {
            lblLocation.Text = "X: " + pnMainChat.DisplayRectangle.Location.X.ToString() + "; Y: " + pnMainChat.DisplayRectangle.Location.Y.ToString() + "Height: " + pnMainChat.Height + ", glob = " + glob.ToString();
        }

    }
}
