using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace ChatApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(ChatUser user)
        {
            InitializeComponent();
            this.currentUser = user;
            CheckForIllegalCrossThreadCalls = false;

        }
        ChatRoom room = new ChatRoom();
        List<ChatMessage> messages = new List<ChatMessage>();
        ChatUser currentUser = new ChatUser() { Name = "0", Id = "0", Email = "0" };
        ChatUser otherUser = new ChatUser();
        List<ChatUser> otherUsers = new List<ChatUser>();

        ChatRoom currentRoom = new ChatRoom();
        List<ChatRoom> roomList = new List<ChatRoom>();

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtChat.Text.Trim().CompareTo(string.Empty) == 0)
            {
                return;
            }
            ChatMessage message = new ChatMessage()
            {
                Text = txtChat.Text,
                Date = DateTime.Now,
                Receiver = this.otherUser.Id,
                Sender = this.currentUser.Id,
                TypeOfMessage = EnumTypeOfMessage.TEXT,
                Room = currentRoom
            };
            AddToMessageList(message);

            txtChat.Text = "";

            WriteToJSONFile(messages);
        }
        private void btnFile_Click(object sender, EventArgs e)
        {
            ;
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Multiselect = false;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ChatMessage message = new ChatMessage()
                    {
                        Text = dialog.FileName,
                        Date = DateTime.Now,
                        Receiver = this.otherUser.Id,
                        Sender = this.currentUser.Id,
                        Room = currentRoom
                    };
                    string ext = Path.GetExtension(dialog.FileName);
                    if (ext == ".mp4" || ext == ".mp3" || ext == ".mkv" || ext == ".webm")
                    {
                        message.TypeOfMessage = EnumTypeOfMessage.VIDEO;
                    }
                    else if (ext == ".png" || ext == ".jpg" || ext == ".jpeg" || ext == ".gif" || ext == ".webp")
                    {
                        message.TypeOfMessage = EnumTypeOfMessage.IMAGE;
                    }
                    else
                    {
                        message.TypeOfMessage = EnumTypeOfMessage.FILE;
                    }
                    AddToMessageList(message); ;
                    WriteToJSONFile(messages);

                }





            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            SwitchMode(AppMode.CurMODE);
            LoadListRoom();
            LoadMessage();
            LoadOtherUser();
        }
        public void LoadOtherUser()
        {
            otherUsers = ChatUser.GetAll().Where(user => user.Id != currentUser.Id).ToList();
            if (otherUsers.Count == 0)
            {
                return;
            }
            lstvwOtherUser.Items.Clear();
            foreach (ChatUser user in otherUsers)
            {
                lstvwOtherUser.Items.Add(user.Name);
            }

        }
        public void LoadListRoom()
        {
            roomList = ChatRoom.GetAll().Where(room => room.users.Any(user => user.Id.CompareTo(this.currentUser.Id) == 0)).ToList();
            if (roomList.Count == 0)
            {
                return;
            }
            lstvwRoom.Items.Clear();
            foreach (ChatRoom room in roomList)
            {
                lstvwRoom.Items.Add(room.roomName);
            }

            currentRoom = roomList[0];
            otherUser = currentRoom.users.Where(user => user.Id.CompareTo(this.currentUser.Id) != 0).FirstOrDefault();
        }
        public void ClearMessages()
        {
            foreach (Control control in pnMainChat.Controls)
            {
                if (control is ChatComponent)
                {
                    ChatComponent chatComponent = (ChatComponent)control;
                    if (chatComponent.chatMessage.TypeOfMessage == EnumTypeOfMessage.VIDEO)
                    {
                        foreach (Control pnControl in chatComponent.pnMain.Controls)
                        {
                            pnControl.Dispose();
                        }
                    }
                }
                else
                {
                    continue;
                }
            }
            pnMainChat.Controls.Clear();
            messages.Clear();
        }
        public void LoadMessage()
        {

            ClearMessages();
            ReadJSONFileToChatMessage();
            messages = messages.Where(message => message.Room.roomId.CompareTo(currentRoom.roomId) == 0).OrderBy(message => message.Date).ToList();

            for (int i = 0; i < messages.Count; i++)
            {
                bool mine = false;
                if (messages[i].Sender.CompareTo(this.currentUser.Id) == 0)
                {
                    mine = true;
                }

                AddMessageComponent(mine, messages[i], i);

            }

        }
        public void ReadJSONFileToChatMessage()
        {
            ReadRoomJSONFile();
            ReadUserJSONFile();
            ReadMessageJSONFile();
        }
        public void ReadMessageJSONFile()
        {
            messages = ChatMessage.GetAll();
            int test = 0;
        }
        public void ReadUserJSONFile()
        {

        }
        public void ReadRoomJSONFile()
        {

        }

        public void WriteToJSONFile(object obj)
        {

            ChatMessage.WriteAll(ChatMessage.AllMessages);
        }

        public void AddToMessageList(ChatMessage message)
        {
            this.messages.Add(message);
            ChatMessage.AllMessages.Add(message);

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
                chatComponent.Location = new Point(450, (10 + 150 * index) + pnMainChat.DisplayRectangle.Location.Y);
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

        private void picOpenIcon_Click_1(object sender, EventArgs e)
        {
            OpenIcon();
        }
        public void OpenIcon()
        {
            pnIcon.Visible = !pnIcon.Visible;

            if (pnIcon.Visible)
            {
                pnIcon.BringToFront();

            }
            else
            {
                pnIcon.SendToBack();
            }
            txtChat.SelectionColor = Color.Red;
        }

        private void lstvwRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvwRoom.SelectedItems.Count > 0)
            {
                int index = lstvwRoom.Items.IndexOf(lstvwRoom.SelectedItems[0]);
                ChatRoom room = roomList[index];
                if (room != null)
                {
                    currentRoom = room;
                    otherUser = currentRoom.users.Where(user => user.Id.CompareTo(this.currentUser.Id) != 0).FirstOrDefault();
                    lblChatMate.Text = "Chatmate: " + otherUser.Name;
                    lblCurrentRoom.Text = "Current room: " + currentRoom.roomName;
                    LoadMessage();
                }
            }
        }

        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
            CreateNewRoom();
        }
        public void CreateNewRoom()
        {

            NewRoom form = new NewRoom(currentUser);

            form.ShowDialog();
            if (form.isClosed)
            {
                ChatRoom newCreateRoom = form.newlyChatRoom;
                if (newCreateRoom != null)
                {
                    LoadListRoom();
                }
            }
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AppMode.CurMODE.state.CheckMode("Dark"))
            {
                AppMode.CurMODE.state = new LightMode();
            }
            else {
                return;
            }
            SwitchMode(AppMode.CurMODE);

        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {



            if (AppMode.CurMODE.state.CheckMode("Light"))
            {
                AppMode.CurMODE.state = new DarkMode();
            }
            else
            {
                return;
            }
            SwitchMode(AppMode.CurMODE);
        }
        public void SwitchMode(AppMode mode)
        {
            mode.state.SwitchMode();

            this.BackColor = mode.state.primary;
            pnMainChat.BackColor = mode.state.secondary;
            txtChat.BackColor =mode.state.third;
            lstvwOtherUser.BackColor = mode.state.fourth;
            lstvwRoom.BackColor = mode.state.fourth;

            btnCreateRoom.BackColor = mode.state.fourth;
            btnFile.BackColor = mode.state.fourth;
            btnSend.BackColor = mode.state.fourth;

            lstvwOtherUser.ForeColor=mode.state.fifth;
            txtChat.ForeColor=mode.state.fifth;
            lstvwRoom.ForeColor=mode.state.fifth;
            lblCurrentRoom.ForeColor=mode.state.fifth;
            lblChatMate.ForeColor=mode.state.fifth;
            btnCreateRoom.ForeColor=mode.state.fifth;
            btnFile.ForeColor = mode.state.fifth;
            btnSend.ForeColor = mode.state.fifth;

        }
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
