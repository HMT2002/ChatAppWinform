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

        }
        public void initImage()
        {

        }
        public void initVideo()
        {


        }

        #region player
        public bool first_init = true;
        public const int defaultVolume = 70;
        public LibVLC _libVLC;
        public MediaPlayer _mp;
        public void initPlayer()
        {
            first_init = false;
            _libVLC = new LibVLC("--input-repeat=100");
            _mp = new MediaPlayer(_libVLC);
            videoMessage.MediaPlayer = _mp;
            _mp.Volume = defaultVolume;
            CheckForIllegalCrossThreadCalls = false;
            _mp.EnableMouseInput = false;
            _mp.EnableKeyInput= false;
            _mp.Play(new Media(_libVLC, "../../fumo.mp4", FromType.FromPath));


        }
        public void player_play()
        {


            try
            {

                _mp.Play();


            }
            catch (Exception ex)
            {

            }
        }
        public void player_pause()
        {
            try
            {
                _mp.Pause();
            }
            catch (Exception ex)
            {

            }
        }
        public void player_stop()
        {
            try
            {
                _mp.Stop();
            }
            catch (Exception ex)
            {

            }
        }
        public void player_load()
        {
            try
            {
                _mp.Play(new Media(_libVLC, "../../tewi.mp4", FromType.FromLocation));
            }
            catch (Exception ex)
            {

            }
        }
        int count = 0;
        private void videoMessage_Click(object sender, EventArgs e)
        {
            if (first_init)
            {
                initPlayer();
                return;
            }
            player_pause();
        }
        #endregion

        public void initFile()
        {

        }

        #region picture message
        ShowPic show = new ShowPic();
        private void picMessage_MouseHover(object sender, EventArgs e)
        {


        }

        private void picMessage_MouseLeave(object sender, EventArgs e)
        {


        }
        private void picMessage_Click(object sender, EventArgs e)
        {
            Image temp = Image.FromFile(@"C:\Users\blues\Pictures\dom.jpg");
            show = new ShowPic(temp, Cursor.Position);
            show.Location = new Point(Cursor.Position.X - 165, Cursor.Position.Y - 210);
            show.WindowState = FormWindowState.Normal;
            show.StartPosition = FormStartPosition.Manual;
            show.Show();
        }





        #endregion

        private void pnPlay_Click(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

        }


    }
}
