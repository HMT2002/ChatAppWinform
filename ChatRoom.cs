using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

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
        

        public List<ChatUser> users { get; set; }
        public string roomName { get; set; }
        public string roomId { get; set; }

        public static List<ChatRoom> GetAll()
        {
            var list = new List<ChatRoom>();
            string fileName = "../../rooms.json";
            string jsonString = File.ReadAllText(fileName);
            var options = new JsonSerializerOptions();
            options.Converters.Add(new JsonStringEnumConverter());
            list = JsonSerializer.Deserialize<List<ChatRoom>>(jsonString, options);
            return list;
        }
    }
}
