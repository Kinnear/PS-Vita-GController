using System;
using System.Collections.Generic;

using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.Core.Graphics;
using Sce.PlayStation.Core.Input;
using Sce.PlayStation.HighLevel.UI;
using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;

using Sce.PlayStation.Core.Imaging;

using System.Threading;

namespace Networking
{
	public class AppMain
	{		
		static HighScoreApp.MainWindow window;
		private static GraphicsContext graphics;
		
		//Client Socket
		public static Sockets socket;
		public static InputManager inputManager = new InputManager();
		
		public static bool connectedToServer = false;
		
		public static bool StartSocket(string ipAddress, int portNumber)
		{
			connectedToServer = socket.TryConnect(ipAddress, portNumber);
			return connectedToServer;
		}
		
		public static void DisconnectedFromServer()
		{
			HighScoreApp.MainWindow.SetUIDisconnected();
			connectedToServer = false;
		}
		
		public static void Main (string[] args)
		{
			//Initialize ();
			
		    GraphicsContext graphics = new GraphicsContext();
		    UISystem.Initialize(graphics);
			
		    window = new HighScoreApp.MainWindow();
		    UISystem.SetScene(window);
			socket = new Sockets();
			
			while (true) {
				SystemEvents.CheckEvents();

			    List<TouchData> touchData = Touch.GetData(0);
			    UISystem.Update (touchData);
				
				Update ();
			
			    graphics.SetViewport(0, 0, graphics.Screen.Width, graphics.Screen.Height);
			    graphics.SetClearColor(new Vector4(0,0,0,1));
			    graphics.SetClearDepth(1.0f);
			    graphics.Clear();
			    
			    UISystem.Render ();
			    graphics.SwapBuffers();
			}
		}

		public static void Initialize ()
		{
			// Set up the graphics system
			graphics = new GraphicsContext ();
		}

		public static void Update ()
		{
			if(connectedToServer)
			{
				//detect for input here
				inputManager.Update();
				socket.SendStringToServer(inputManager.InputJSONString());
			}
		}

		public static void Render ()
		{
			// Clear the screen
			graphics.SetClearColor (0.0f, 0.0f, 0.0f, 0.0f);
			graphics.Clear ();

			// Present the screen
			graphics.SwapBuffers ();
		}
	}
}
