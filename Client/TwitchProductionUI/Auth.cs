using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitchProductionUI.helpers;
using xNet;

namespace TwitchProductionUI
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Some test string
            // Requester.Auth("123", "123");
            // Requester.Log("321", "kkkasdasda");
            // Requester.Log("321", aes.Encrypt("successful auth", "123"));
        }
    }
}
