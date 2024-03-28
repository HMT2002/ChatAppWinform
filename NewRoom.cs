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
    public partial class NewRoom : Form
    {
        public NewRoom()
        {
            InitializeComponent();
        }
        ChatUser currentUser { get; set; }

        public NewRoom(ChatUser user)
        {
            InitializeComponent();
            currentUser = user;
            otherUsers = ChatUser.GetAll().Where(chatuser => chatuser.Id.CompareTo(currentUser.Id) != 0).ToList();

        }
        public bool isClosed = false;

        List<ChatRoom> roomList = new List<ChatRoom>();
        List<ChatUser> otherUsers = new List<ChatUser>();
        public ChatRoom newlyChatRoom;
        public ChatUser selectedUser;
        private void NewRoom_Load(object sender, EventArgs e)
        {
            try
            {
                lblCurrenUser.Text = currentUser.Name;
                roomList = ChatRoom.GetAll();
                cbbxOtherUsers.DataSource = otherUsers;
                cbbxOtherUsers.DisplayMember = "Name";
                if(otherUsers.Count > 0)
                {
                    selectedUser = otherUsers[0];
                    lblNoti.Text = selectedUser.Name;

                }
            }
            catch
            {


            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (otherUsers[cbbxOtherUsers.SelectedIndex] != null)
                {
                    string selectedName = cbbxOtherUsers.SelectedText;
                    lblNoti.Text = selectedName;
                    CreateNewRoomFunc();
                }

            }
            catch (Exception ex)
            {
                lblNoti.Text = ex.Message;

            }

        }
        public void CreateNewRoomFunc()
        {
            try
            {
                ChatRoom.GetAll();
                newlyChatRoom = new ChatRoom() { roomId = ChatRoom.GetAll().Count.ToString(), roomName = Converter.Instance.RandomString(5), users = new List<ChatUser>() { currentUser, selectedUser } };
                ChatRoom.AllRooms.Add(newlyChatRoom);
                ChatRoom.WriteAll(ChatRoom.AllRooms);
                this.Close();
            }
            catch (Exception ex)
            {
                lblNoti.Text = ex.Message;
            }

        }

        private void NewRoom_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormIsClosing();
        }
        public void FormIsClosing()
        {
            isClosed = true;

        }
    }
}
