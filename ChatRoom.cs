using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp
{
    public class ChatRoom
    {
        public ChatRoom(List<ChatUser> users, string roomName, string roomId)
        {
            this.users = users;
            this.roomName = roomName;
            this.roomId = roomId;
        }
        public ChatRoom()
        {
            this.users = new List<ChatUser>();
        }

        List<ChatUser> users { get; set; }
        public string roomName { get; set; }
        public string roomId { get; set; }

    }
}
