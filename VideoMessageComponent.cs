using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private void OnDispose(object sender, EventArgs e)
        {
            if (_mp != null)
            {
                _mp.Stop();
                _mp.Dispose();
                _mp = null;
            }
            if (videoMessage != null)
            {
                videoMessage.Dispose();
                videoMessage = null;

            }
            if (media != null)
            {
                media.Dispose();
                media = null;
            }

            if (_libVLC != null)
            {
                _libVLC.Dispose();
                _libVLC = null;
            }
        }
        private void VideoMessageComponent_Load(object sender, EventArgs e)
        {
            this.Disposed += OnDispose;            

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
        public Media media;
        public void initPlayer()
        {
            first_init = false;
            _libVLC = new LibVLC("--input-repeat=100--reset-plugins-cache");
            media = new Media(_libVLC, this.chatMessage.Text, FromType.FromPath);

            _mp = new MediaPlayer(_libVLC);

            videoMessage.MediaPlayer = _mp;
            _mp.Play(media);

            _mp.Volume = defaultVolume;
            //CheckForIllegalCrossThreadCalls = false;
            _mp.EnableMouseInput = false;
            _mp.EnableKeyInput = false;
            if (File.Exists(this.chatMessage.Text.Replace(".mp4", ".ass")))
            {
                _mp.AddSlave(MediaSlaveType.Subtitle, "file:///" + this.chatMessage.Text.Replace(".mp4", ".ass"), true);

            }
            else if (File.Exists(this.chatMessage.Text.Replace(".mp4", ".srt")))
            {

                _mp.AddSlave(MediaSlaveType.Subtitle, "file:///" + this.chatMessage.Text.Replace(".mp4", ".srt"), true);


            }

        }
        public void player_play()
        {

            try
            {
                picPlay.Visible = !picPlay.Visible;

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
                picPlay.Visible = !picPlay.Visible;

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

            if (first_init)
            {
                picPlay.Visible = !picPlay.Visible;

                initPlayer();
                return;
            }
            player_pause();
        }
        private void picPlay_Click(object sender, EventArgs e)
        {

            if (first_init)
            {
                picPlay.Visible = !picPlay.Visible;

                initPlayer();
                return;
            }
            player_pause();
        }
        #endregion

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            if (_mp == null)
            {
                return;
            }
            float currentPosition = _mp.Position;
            
            Media med = _mp.Media;
            FullScreenVideo form = new FullScreenVideo(currentPosition, med,_libVLC);
            player_pause();

            form.ShowDialog();
            if (form.isClosed)
            {
                _mp.Position = form.currentPos;
                player_play();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnDispose(null, null);
        }
    }
}
