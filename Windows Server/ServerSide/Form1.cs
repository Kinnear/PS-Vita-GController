using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ServerSide
{
    public partial class Form1 : Form
    {
        public static RichTextBox staticResultsTextbox;
        public static Label staticMouseX;
        public static Label staticMouseY;
        public static Label staticCursorX;
        public static Label staticCursorY;


        ServerSocket server;

        public Form1()
        {
            InitializeComponent();

            staticResultsTextbox = resultsTextbox;
            staticMouseX = mouseXlbl;
            staticMouseY = mouseYlbl;
            staticCursorX = cursorPositionX;
            staticCursorY = cursorPositionY;

            // start our server
            server = new ServerSocket();
        }

        private void serverIPAddress_Click(object sender, EventArgs e)
        {


        }

        // Upon loading our form
        private void Form1_Load(object sender, EventArgs e)
        {
           ////resolve our dns in our IP address
            serverIPAddress.Text = Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
        }

        private void keyBindWindowBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void triangleBtn_Click(object sender, EventArgs e)
        {
            KeyBind keyBindForm = new KeyBind();
            keyBindForm.Show();
        }
    }
}
