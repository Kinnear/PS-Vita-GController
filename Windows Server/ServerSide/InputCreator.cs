using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Networking;
using Newtonsoft.Json;
using WindowsInput;
using System.Diagnostics;
using System.Globalization;

namespace ServerSide
{
    class InputCreator
    {
        //public KeyBindData keyBindData = new KeyBindData();

        // total pixels on the screen to move
        private float totalPixelsToMoveX = 0.0f;
        private float totalPixelsToMoveY = 0.0f;

        // Create new stopwatch
        private Stopwatch time = new Stopwatch();

        public float speed = 6.0f;

        public InputCreator()
        {
            // start our stopwatch
            time.Start();
        }

        void InputKeyboardKeyDown(bool keyPress, VirtualKeyCode virtualKeyCode)
        {
            if (!keyPress)
            {
                if (InputSimulator.IsKeyDown(virtualKeyCode))
                {
                    InputSimulator.SimulateKeyUp(virtualKeyCode);
                }
            }
            else
            {
                if (!InputSimulator.IsKeyDown(virtualKeyCode))
                {
                    InputSimulator.SimulateKeyDown(virtualKeyCode);
                }
            }
        }

        public void HandleVitaInput(string message)
        {
            VitaInputData data = new VitaInputData();

            float leftAnalogTriggerSensitivity = 0.5f;
            
                //Convert data to keypresses here
                if (IsJson(message))
                {
                    data = JsonConvert.DeserializeObject<VitaInputData>(message);
                }

                // General buttons
                InputKeyboardKeyDown(data.cross, VirtualKeyCode.SPACE);
                InputKeyboardKeyDown(data.circle, VirtualKeyCode.F3);
                InputKeyboardKeyDown(data.triangle, VirtualKeyCode.LSHIFT);
                InputKeyboardKeyDown(data.square, VirtualKeyCode.VK_E);

                InputKeyboardKeyDown(data.start, VirtualKeyCode.ESCAPE);
                InputKeyboardKeyDown(data.select, VirtualKeyCode.RETURN);

                //DPad Buttons
                if (data.dPadUp == false)
                {
                    
                }

                if (data.dPadRight == false)
                {
                    if(MouseSimulator.IsScrollMouseDownDown())
                    {
                        MouseSimulator.ScrollDownMouseUp();
                    }
                }
                else
                {
                    if(!MouseSimulator.IsScrollMouseDownDown())
                    {
                        MouseSimulator.ScrollDownMouseDown();
                    }
                }

                if (data.dPadDown == false)
                {

                }

                if (data.dPadLeft == false)
                {
                    if (MouseSimulator.IsScrollMouseUpDown())
                    {
                        MouseSimulator.ScrollUpMouseUp();
                    }
                }
                else
                {
                    if (!MouseSimulator.IsScrollMouseUpDown())
                    {
                        MouseSimulator.ScrollUpMouseDown();
                    }
                }

                //Mouse buttons
                if (data.leftShoulder == false)
                {
                    if (MouseSimulator.IsRightMouseClickDown())
                    {
                        MouseSimulator.ReleaseRightMouseButton();
                    }
                }
                else
                {
                    if (!MouseSimulator.IsRightMouseClickDown())
                    {
                        MouseSimulator.ClickRightMouseButton();
                    }
                }

                if (data.rightShoulder == false)
                {
                    if (MouseSimulator.IsLeftMouseClickDown())
                    {
                        MouseSimulator.ReleaseLeftMouseButton();
                    }
                }
                else
                {
                    if (!MouseSimulator.IsLeftMouseClickDown())
                    {
                        MouseSimulator.ClickLeftMouseButton();
                    }
                }

                // Analog Right for mouse
                MoveMouse(data.analogRightX, data.analogRightY);

                // Analog Left for wasd
                if (data.analogLeftY > leftAnalogTriggerSensitivity)
                {
                    InputKeyboardKeyDown(false, VirtualKeyCode.VK_W);
                }
                else
                {
                    InputKeyboardKeyDown(true, VirtualKeyCode.VK_W);
                }

                if (data.analogLeftX < -(leftAnalogTriggerSensitivity))
                {

                    InputKeyboardKeyDown(false, VirtualKeyCode.VK_D);
                }
                else
                {
                    InputKeyboardKeyDown(true, VirtualKeyCode.VK_D);
                }

                if (data.analogLeftY < -(leftAnalogTriggerSensitivity))
                {
                    InputKeyboardKeyDown(false, VirtualKeyCode.VK_S);
                }
                else
                {
                    InputKeyboardKeyDown(true, VirtualKeyCode.VK_S);
                }

                if (data.analogLeftX > leftAnalogTriggerSensitivity)
                {
                    InputKeyboardKeyDown(false, VirtualKeyCode.VK_A);
                }
                else
                {
                    InputKeyboardKeyDown(true, VirtualKeyCode.VK_A);
                }

        }

        private void AnalogStickInputConverter(bool analogDirection, VirtualKeyCode virtualKeyCode)
        {

        }
        
        public bool IsJson(string input)
         {
             input = input.Trim();
             return input.StartsWith("{") && input.EndsWith("}")
                    || input.StartsWith("[") && input.EndsWith("]");
         }

        public void MoveMouse(float x, float y)
        {
             //1. Add (time delta * speed * 1 pixel) from the previous
             //2. If variable has reached more than 1, minus off the pixels
             // and move the pixels accordingly

             totalPixelsToMoveX += (x * ((float)((time.ElapsedMilliseconds / 1000.0f) * speed)));
             totalPixelsToMoveY += (y * ((float)((time.ElapsedMilliseconds / 1000.0f) * speed)));

             //Console.WriteLine("Time Milliseconds: " + time.ElapsedMilliseconds / 1000.0f);

             //Console.WriteLine("X Value: " + totalPixelsToMoveX);
             //Console.WriteLine("Y Value: " + totalPixelsToMoveY);

             if (totalPixelsToMoveX >= 1.0f || totalPixelsToMoveX <= -1.0f || totalPixelsToMoveY >= 1.0f || totalPixelsToMoveY <= -1.0f)
             {
                float wholeNumberValueX = 0.0f;
                float decimalValueX = 0.0f;

                SplitFloatToAndDecimal(totalPixelsToMoveX, out wholeNumberValueX, out decimalValueX);

                float wholeNumberValueY = 0.0f;
                float decimalValueY = 0.0f;

                SplitFloatToAndDecimal(totalPixelsToMoveY, out wholeNumberValueY, out decimalValueY);

                MouseSimulator.MoveMouse(MouseSimulator.GetCursorPosition().X + Convert.ToInt32(wholeNumberValueX), MouseSimulator.GetCursorPosition().Y + Convert.ToInt32(wholeNumberValueY));

                //totalPixelsToMoveX += decimalValueX;
                //totalPixelsToMoveY += decimalValueY;

                totalPixelsToMoveX -= wholeNumberValueX;
                totalPixelsToMoveY -= wholeNumberValueY;
             }

             //MouseSimulator.MoveMouse((int)(MouseSimulator.GetCursorPosition().X + x), (int)(MouseSimulator.GetCursorPosition().Y + y));

             if (time.ElapsedMilliseconds > 10)
             {
                 time.Restart();
             }

            //Console.WriteLine("Analog X: {0}", x);
            //Console.WriteLine("Analog Y: {0}", y);
            //Console.WriteLine("Mouse X: {0}", MouseSimulator.GetCursorPosition().X);
            //Console.WriteLine("Mouse Y: {0}", MouseSimulator.GetCursorPosition().Y);
            //Console.WriteLine("");
        }

        private void SplitFloatToAndDecimal(float originalValue, out float wholeNumberValueX, out float decimalValueX)
        {
            wholeNumberValueX = decimalValueX = 0.0f;

            string[] fullvalue = originalValue.ToString().Split('.');

            if (!float.TryParse(fullvalue[0], out wholeNumberValueX))
            {
                Console.WriteLine("String to float casting error.");
            }

            // check if theres even a decimal place in the first place!
            if (fullvalue.Length > 1)
            {
                if (!float.TryParse("0." + fullvalue[1], out decimalValueX))
                {
                    Console.WriteLine("String to float casting error.");
                }
            }
        }
    }
}
