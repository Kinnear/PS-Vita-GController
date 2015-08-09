using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using WindowsInput;

// for seraliazation
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Reflection;
using System.Security.Permissions;
using System.IO;
using System.Web;

namespace ServerSide
{
    class ServerSocket
    {
        private TcpListener tcpListener;
        private Thread listenThread;

        private void ListenForClients()
        {
            this.tcpListener.Start();

            while (true)
            {
                //blocks until a client has connected to the server
                TcpClient client = this.tcpListener.AcceptTcpClient();
                
                //create a thread to handle communication
                //with connected client
                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));
                clientThread.Start(client);

                AppendToResultsTextbox("A new client has connected!\n");
            }
        }

        private void AppendToResultsTextbox(string message)
        {
            if (ServerSide.Form1.staticResultsTextbox.InvokeRequired)
            {
                ServerSide.Form1.staticResultsTextbox.Invoke(new Action<string>(AppendToResultsTextbox), message);
                return;
            }

            ServerSide.Form1.staticResultsTextbox.Text += message; 
        }

        private void DisplayToLabel(string message, System.Windows.Forms.Label label)
        {
            if (label.InvokeRequired)
            {
                label.Invoke(new Action<string, System.Windows.Forms.Label>(DisplayToLabel), message, label);
                return;
            }

            label.Text = message;
        }

        private void HandleClientComm(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();

            // server sending stuff to a new client
            //ASCIIEncoding encoderSend = new ASCIIEncoding();
            //byte[] buffer = encoderSend.GetBytes("Hello Client!");

            //clientStream.Write(buffer, 0, buffer.Length);
            //clientStream.Flush();

            //memory to store our header
            byte[] readMsgLen = new byte[4];
            int actualDataLength = 0;

            // memory to store our ACTUAL DATA
            byte[] actualData = new Byte[1024];

            InputCreator inputCreator = new InputCreator();

            while (true)
            {
                //1. read the first 4 bytes
                //2. extract the string length out of 4 bytes
                //3. collect the bytes from the stream until the the index reaches the amount of bytes that is indicated in the previous step
                //4. Convert the bytes into ascii and print out the bytes
 
                try
                {
                    if(clientStream.DataAvailable)
                    {
                        // read the header
                        SafeRead(4, ref readMsgLen, ref clientStream);

                        // Convert the header's bytes into an integer that we can read
                        actualDataLength = BitConverter.ToInt32(readMsgLen, 0);
                        //Console.WriteLine("ActualDataLength: {0}", actualDataLength);

                        //clear and resize our array to prepare to store our actual data in bytes
                        Array.Clear(actualData, 0, actualData.Length);
                        Array.Resize(ref actualData, actualDataLength);

                        //start reading the proper amount of string that's there
                        SafeRead(actualDataLength, ref actualData, ref clientStream);
                    }
                }
                catch
                {
                    //a socket error has occured
                    break;
                }

                //message has successfully been received
                ASCIIEncoding encoder = new ASCIIEncoding();
                //inputCreator = new InputCreator();
                inputCreator.HandleVitaInput(encoder.GetString(actualData, 0, actualData.Length));
                //Console.WriteLine(encoder.GetString(actualData, 0, actualData.Length));
                //Console.WriteLine("");

                //DisplayToLabel("Mouse X: " + Convert.ToString(data.analogRightX), ServerSide.Form1.staticMouseX);
                //DisplayToLabel("Mouse Y: " + Convert.ToString(data.analogRightY), ServerSide.Form1.staticMouseY);
                //DisplayToLabel("Cursor Position X: " + Convert.ToString(MouseSimulator.GetCursorPosition().X), ServerSide.Form1.staticCursorX);
                //DisplayToLabel("Cursor Position Y: " + Convert.ToString(MouseSimulator.GetCursorPosition().Y), ServerSide.Form1.staticCursorY);

            }

            AppendToResultsTextbox("A client has disconnected!\n");

            tcpClient.Close();
        }

        // ensure that we read the specified amount of bytes from the client
       private void SafeRead(int specifiedLengthOfMessage, ref byte[] readMsgData, ref NetworkStream stream)
       {
            int dataRead = 0;
            do
            {       
                //gets the number of bytes we have read and make sure it's within the limit of bytes we wish to read
                dataRead += stream.Read(readMsgData, dataRead, specifiedLengthOfMessage - dataRead);

            } while (dataRead < specifiedLengthOfMessage);
        }

         public ServerSocket()
         {
             this.tcpListener = new TcpListener(IPAddress.Any, 3000);
             this.listenThread = new Thread(new ThreadStart(ListenForClients));
             this.listenThread.Start();
         }

         public ServerSocket(int portNumber)
         {
             this.tcpListener = new TcpListener(IPAddress.Any, portNumber);
             this.listenThread = new Thread(new ThreadStart(ListenForClients));
             this.listenThread.Start();
         }
    }
}