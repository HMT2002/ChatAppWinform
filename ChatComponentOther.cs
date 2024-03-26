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
    public partial class ChatComponentOther : UserControl
    {
        public ChatComponentOther()
        {
            InitializeComponent();
        }
        public ChatMessage chatMessage;
        public ChatComponentOther(ChatMessage chatMessage)
        {
            InitializeComponent();
            this.chatMessage = chatMessage;

            initOnType(chatMessage.TypeOfMessage);
            initGeneral();
        }
        public void initGeneral()
        {
            lblDate.Text = this.chatMessage.Date.ToString("MM/dd/yyyy hh:mm tt");
        }
        public void initOnType(EnumTypeOfMessage typeOfMessage)
        {
            switch (typeOfMessage)
            {
                case EnumTypeOfMessage.TEXT:
                    initText();
                    break;
                case EnumTypeOfMessage.IMAGE:
                    initImage();
                    break;
                case EnumTypeOfMessage.VIDEO:
                    initVideo();
                    break;
                case EnumTypeOfMessage.FILE:
                    initFile();
                    break;
                default: break;
            }
        }

        private void ChatComponentOther_Load(object sender, EventArgs e)
        {
            this.Disposed += delegate
            {
                foreach (Control control in pnMain.Controls)
                {

                        control.Dispose();
                    
                }

            };
        }
        public void initFile()
        {
            FileMessageComponent comp = new FileMessageComponent(chatMessage);
            comp.Location = new Point(0, 0);
            pnMain.Controls.Add(comp);
        }
        public void initVideo()
        {
            VideoMessageComponent comp = new VideoMessageComponent(chatMessage);
            comp.Location = new Point(0, 0);
            pnMain.Controls.Add(comp);

        }
        public void initText()
        {
            TextMessageComponent comp = new TextMessageComponent(chatMessage);
            comp.Location = new Point(0, 0);
            pnMain.Controls.Add(comp);
        }
        public void initImage()
        {
            ImageMessageComponent comp=new ImageMessageComponent(chatMessage);
            comp.Location=new Point(0,0);
            pnMain.Controls.Add(comp);
        }
    }
}
