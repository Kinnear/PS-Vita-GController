using System;
using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;
using Sce.PlayStation.Core.Input;
using System.Collections.Generic;

namespace Networking
{
	public class InputManager
	{
		public GamePadData gamePadData;
		VitaInputData data = new VitaInputData();
		
		public InputManager ()
		{
			
		}
		
		public void Update()
		{
			// Query gamepad for current state
			gamePadData = GamePad.GetData (0);
			
			if((gamePadData.Buttons & GamePadButtons.Cross) != 0)
			{
				data.cross = true;
			}
			else
			{
				data.cross = false;
			}
			
			if((gamePadData.Buttons & GamePadButtons.Circle) != 0)
			{
				data.circle = true;
			}
			else
			{
				data.circle = false;
			}
			
			if((gamePadData.Buttons & GamePadButtons.Square) != 0)
			{
				data.square = true;
			}
			else
			{
				data.square = false;
			}
			
			if((gamePadData.Buttons & GamePadButtons.Square) != 0)
			{
				data.square = true;
			}
			else
			{
				data.square = false;
			}
			
			if((gamePadData.Buttons & GamePadButtons.Triangle) != 0)
			{
				data.triangle = true;
			}
			else
			{
				data.triangle = false;
			}
			
			if((gamePadData.Buttons & GamePadButtons.L) != 0)
			{
				data.leftShoulder = true;
			}
			else
			{
				data.leftShoulder = false;
			}
			
			if((gamePadData.Buttons & GamePadButtons.R) != 0)
			{
				data.rightShoulder = true;
			}
			else
			{
				data.rightShoulder = false;
			}
			
			if((gamePadData.Buttons & GamePadButtons.Start) != 0)
			{
				data.start = true;
			}
			else
			{
				data.start = false;
			}
			
			if((gamePadData.Buttons & GamePadButtons.Select) != 0)
			{
				data.select = true;
			}
			else
			{
				data.select = false;
			}
			
			// DPad Buttons
			if((gamePadData.Buttons & GamePadButtons.Up) != 0)
			{
				data.dPadUp = true;
			}
			else
			{
				data.dPadUp = false;
			}
			
			if((gamePadData.Buttons & GamePadButtons.Right) != 0)
			{
				data.dPadRight = true;
			}
			else
			{
				data.dPadRight = false;
			}
			
			if((gamePadData.Buttons & GamePadButtons.Down) != 0)
			{
				data.dPadDown = true;
			}
			else
			{
				data.dPadDown = false;
			}
			
			if((gamePadData.Buttons & GamePadButtons.Left) != 0)
			{
				data.dPadLeft = true;
			}
			else
			{
				data.dPadLeft = false;
			}
			
			//Analogue Joystick
			data.analogLeftX = gamePadData.AnalogLeftX;
			data.analogLeftY = gamePadData.AnalogLeftY;
			data.analogRightX = gamePadData.AnalogRightX;
			data.analogRightY = gamePadData.AnalogRightY;
		}
		
		public string InputJSONString()
		{
			Dictionary<string,object> jsonParse = new Dictionary<string, object>();
			// General Buttons
		    jsonParse["cross"] = data.cross;
		    jsonParse["circle"] = data.circle;
		    jsonParse["triangle"] = data.triangle;
		    jsonParse["square"] = data.square;
			jsonParse["leftShoulder"] = data.leftShoulder;
			jsonParse["rightShoulder"] = data.rightShoulder;
			jsonParse["start"] = data.start;
			jsonParse["select"] = data.select;
			
			// DPad
			jsonParse["dPadLeft"] = data.dPadLeft;
			jsonParse["dPadRight"] = data.dPadRight;
			jsonParse["dPadUp"] = data.dPadUp;
			jsonParse["dPadDown"] = data.dPadDown;
			
			//Analogue
			jsonParse["analogLeftX"] = data.analogLeftX;
			jsonParse["analogLeftY"] = data.analogLeftY;
			jsonParse["analogRightX"] = data.analogRightX;
			jsonParse["analogRightY"] = data.analogRightY;
			
			return SimpleJson.SimpleJson.SerializeObject(jsonParse);
		}
	}
}

