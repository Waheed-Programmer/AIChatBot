using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIMLbot;

namespace ChatBotWithAIML
{
    public partial class frmChat : Form
    {
        public frmChat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bot AI = new Bot();
            AI.loadSettings();
            AI.loadAIMLFromFiles();
            AI.isAcceptingUserInput = false;
            User myusers = new User("UserName Here: ",AI);
            AI.isAcceptingUserInput = true;
            Request r = new Request(textBox1.Text, myusers, AI);
            Result res = AI.Chat(r);
            textBox2.Text = "BOT RESPONSE: " + res.Output;




        }
    }
}
