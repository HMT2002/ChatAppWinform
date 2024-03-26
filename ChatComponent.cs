using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
    public partial class ChatComponent : UserControl
    {
        public ChatComponent()
        {
            InitializeComponent();
        }
        public ChatMessage chatMessage;
        public ChatComponent(ChatMessage chatMessage)
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


        public void initText()
        {

            TextMessageComponent comp = new TextMessageComponent(chatMessage);
            comp.Location = new Point(15, 0);
            pnMain.Controls.Add(comp);
        }
        public void initImage()
        {
            ImageMessageComponent comp = new ImageMessageComponent(chatMessage);
            comp.Location = new Point(15, 0);
            pnMain.Controls.Add(comp);
            lblDate.Text = "image";
        }
        public void initVideo()
        {
            VideoMessageComponent comp = new VideoMessageComponent(chatMessage);
            comp.Location = new Point(15, 0);
            pnMain.Controls.Add(comp);
        }

        public void initFile()
        {
            FileMessageComponent comp = new FileMessageComponent(chatMessage);
            comp.Location = new Point(15, 0);
            pnMain.Controls.Add(comp);
        }

        #region picture message



        #endregion

        private void ChatComponent_Load(object sender, EventArgs e)
        {
            this.Disposed += delegate
            {
                foreach(Control control in pnMain.Controls)
                {


                        control.Dispose();
                    
                }

            };
        }
    }
}
