using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
    public partial class FullScreenVideo : Form
    {
        public FullScreenVideo()
        {
            InitializeComponent();
        }

        public FullScreenVideo(float currentPosition, Media med,LibVLC lib)
        {
            InitializeComponent();
            //CheckForIllegalCrossThreadCalls = false;

            media = med;
            currentPos = currentPosition;

            _libVLC = lib;
            _mp = new MediaPlayer(_libVLC);
            videoFull.MediaPlayer = _mp;
            _mp.Volume = 70;
            _mp.EnableMouseInput = false;
            _mp.EnableKeyInput = false;
            _mp.Play(this.media);
            _mp.Position = currentPosition;

        }

        public LibVLC _libVLC;
        public MediaPlayer _mp;
        public Media media;
        public float currentPos;
        public bool isClosed = false;
        public void ClosingFullScreen()
        {
            isClosed = true;
            currentPos = _mp.Position;
            media.Dispose();
            _mp.Dispose();
            _libVLC.Dispose();
            videoFull.Dispose();
        }

        private void FullScreenVideo_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClosingFullScreen();
        }

        private void videoFull_Click(object sender, EventArgs e)
        {
            player_pause();
        }

        private void picPlay_Click(object sender, EventArgs e)
        {
            player_pause();
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
    }
}
