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
    public partial class TextMessageComponent : UserControl
    {

        public TextMessageComponent()
        {
            InitializeComponent();
        }
        public TextMessageComponent(ChatMessage chatMessage)
        {
            InitializeComponent();
            this.chatMessage = chatMessage;
        }
        public ChatMessage chatMessage;

        private void TextMessageComponent_Load(object sender, EventArgs e)
        {
            initText();
        }
        public void initText()
        {


            lblMessage.Text = chatMessage.Text;

        }
    }
}
