using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
    public partial class VideoMessageComponent : UserControl
    {
        public VideoMessageComponent()
        {
            InitializeComponent();
        }
        public ChatMessage chatMessage;
        public VideoMessageComponent(ChatMessage chatMessage)
        {
            InitializeComponent();
            this.chatMessage = chatMessage;
        }
        private void VideoMessageComponent_Load(object sender, EventArgs e)
        {
            initVideo();
        }
        public void initVideo()
        {

            picPlay.BackColor = Color.FromArgb(255, 0, 0, 0);
            picPlay.ForeColor = Color.FromArgb(255, 0, 0, 0);
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
            _mp.EnableKeyInput = false;

            _mp.Play(new Media(_libVLC, this.chatMessage.Text, FromType.FromPath));


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
        int count = 0;
        private void videoMessage_Click(object sender, EventArgs e)
        {
            picPlay.Visible = !picPlay.Visible;

            if (first_init)
            {
                initPlayer();
                return;
            }
            player_pause();
        }
        private void pcbxPlay_Click_1(object sender, EventArgs e)
        {
            picPlay.Visible = !picPlay.Visible;

            if (first_init)
            {
                initPlayer();
                return;
            }
            player_pause();
        }
        private void picPlay_Click(object sender, EventArgs e)
        {
            picPlay.Visible = !picPlay.Visible;

            if (first_init)
            {
                initPlayer();
                return;
            }
            player_pause();
        }
        #endregion
    }
}
