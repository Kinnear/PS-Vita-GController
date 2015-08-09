using System;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Net;
//using System.Diagnostics;
	
namespace Networking
{
	public class Sockets
	{
		TcpClient client = new TcpClient();
        IPEndPoint serverEndPoint;
		
		public VitaInputData data = new VitaInputData();
		
		public void SendStringToServer(string message)
        {
			try
			{
				NetworkStream clientStream = client.GetStream();
				
				// encode the message into a string
	            ASCIIEncoding encoder = new ASCIIEncoding();
	            byte[] buffer = encoder.GetBytes(message);
				
				// put in the length of the string into the header of the stream first
				byte[] userDataLen = BitConverter.GetBytes((Int32)message.Length);
				
				clientStream.Write(userDataLen, 0, 4);	// Use 4 bytes to represent the length of the string
				clientStream.Flush();
				
				clientStream.Write(buffer, 0, buffer.Length);
          	    clientStream.Flush();
			}
			catch
			{
				Console.WriteLine("Server connection has closed");
				client.Close();
				// indicate to the user that the connection has been closed
				AppMain.DisconnectedFromServer();
				return;
			}
			//Console.WriteLine ("Message To send: {0}", message);
        }
		
		//test if we're able to connect to the server
		public bool TryConnect(string ipAddress, int portNumber)
		{
			try
			{
				client = new TcpClient();
				serverEndPoint = new IPEndPoint(IPAddress.Parse(ipAddress), portNumber);
				// Connect to the server. In other words specify our endpoint!
	            client.Connect(serverEndPoint);
			}
			catch
			{
				return false;
			}
			
			return true;
		}
		
		public Sockets()
		{
		}
	}
}

