using System;
using System.Collections.Generic;
using System.Net;

using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;


namespace HighScoreApp
{
   	public partial class MainWindow : Scene
    {
		public static EditableText staticIpAddressTextBox;
		public static Label staticIsConnected;
		public static Button staticConnectToServerButton;
		public static Label staticConnectedResults;
		
		//public static Networking.Sockets socket;
		
		public static void SetUIConnected()
		{
			staticConnectedResults.Text = "Valid Address.";
			staticIsConnected.Text = "Yes";
			staticIsConnected.TextColor = new UIColor(0.0f, 1.0f, 0.0f, 1.0f);
			staticConnectToServerButton.Enabled = false;
		}
		
		public static void SetUIDisconnected()
		{
			staticConnectedResults.Text = "Valid Address.";
			staticIsConnected.Text = "No";
			staticIsConnected.TextColor = new UIColor(1.0f, 0.0f, 0.0f, 1.0f);
			staticConnectToServerButton.Enabled = true;
		}
		
		// Constructor
        public MainWindow()
		{
            InitializeWidget();
			
			staticIpAddressTextBox = textboxIPAddress;
			staticIsConnected = isConnected;
			staticConnectToServerButton = connectToServerButton;
			staticConnectedResults = connectedResults;

			// pressing the connected to server button
			connectToServerButton.ButtonAction += delegate(object sender, TouchEventArgs e) 
			{
				string addrString = staticIpAddressTextBox.Text;
				IPAddress address;
				
				// Test if it's a legit IPAddress
				if (IPAddress.TryParse(addrString, out address)) 
				{
					//Valid IP, with address containing the IP
					//Instantiate our socket
					if(Networking.AppMain.StartSocket(staticIpAddressTextBox.Text, 3000))
					{
						SetUIConnected();
					}
					else
					{
						connectedResults.Text = "Server did not respond!";
				    }
				}
				else
				{
				    //Invalid IP
					connectedResults.Text = "Invalid IPAddress!";
				}
	  		};
 		}
		
    }
}