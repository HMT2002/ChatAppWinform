using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp
{
    public class ChatMessage
    {
        private string text;
        private DateTime date;
        private string sender;
        private string receiver;
        private EnumTypeOfMessage typeOfMessage;
        public string Text { get => text; set => text = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Sender { get => sender; set => sender = value; }
        public string Receiver { get => receiver; set => receiver = value; }
        public EnumTypeOfMessage TypeOfMessage { get => typeOfMessage; set => typeOfMessage = value; }

        public ChatMessage()
        {

        }

        public ChatMessage(string text, DateTime date, string sender, string receiver, EnumTypeOfMessage typeOfMessage)
        {
            Text = text;
            Date = date;
            Sender = sender;
            Receiver = receiver;
            TypeOfMessage = typeOfMessage;
        }
    }
}
