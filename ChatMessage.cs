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
    public class ChatMessage
    {
        private string text;
        private DateTime date;
        private string sender;
        private string receiver;
        private EnumTypeOfMessage typeOfMessage;
        private ChatRoom room;
        public string Text { get => text; set => text = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Sender { get => sender; set => sender = value; }
        public string Receiver { get => receiver; set => receiver = value; }
        public EnumTypeOfMessage TypeOfMessage { get => typeOfMessage; set => typeOfMessage = value; }
        public ChatRoom Room { get => room; set => room = value; }

        public ChatMessage()
        {

        }

        public ChatMessage(string text, DateTime date, string sender, string receiver, EnumTypeOfMessage typeOfMessage, ChatRoom room)
        {
            Text = text;
            Date = date;
            Sender = sender;
            Receiver = receiver;
            TypeOfMessage = typeOfMessage;
            Room = room;
        }
        public static List<ChatMessage> GetAll()
        {
            List<ChatMessage> messages=new List<ChatMessage> ();
            string fileName = "../../messages.json";
            string jsonString = File.ReadAllText(fileName);
            var options = new JsonSerializerOptions();
            options.Converters.Add(new JsonStringEnumConverter());
            messages = JsonSerializer.Deserialize<List<ChatMessage>>(jsonString, options);
            return messages;
        }
        public static void WriteAll(List<ChatMessage> list)
        {
            string jsonString = JsonSerializer.Serialize(list);
            File.WriteAllText("../../messages.json", jsonString);

        }
    }
}
