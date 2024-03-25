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
    public class ChatUser
    {
        public ChatUser(string id, string name, string email, string password)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
        }
        public ChatUser() { }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


        public static List<ChatUser> GetAll()
        {
            var list = new List<ChatUser>();
            string fileName = "../../users.json";
            string jsonString = File.ReadAllText(fileName);
            var options = new JsonSerializerOptions();
            options.Converters.Add(new JsonStringEnumConverter());
            list = JsonSerializer.Deserialize<List<ChatUser>>(jsonString, options);
            return list;
        }
    }
}
