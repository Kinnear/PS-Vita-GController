using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;

namespace ServerSide
{
    public enum InputType
    {
        KEYBOARD,
        MOUSE
    };

    public enum TypeOfMouseInput
    {
        LEFT_MOUSE_BUTTON,
        RIGHT_MOUSE_BUTTON,
        MOVE_MOUSE_LEFT,
        MOVE_MOUSE_RIGHT,
        MOVE_MOUSE_UP,
        MOVE_MOUSE_BOTTOM,
        MOUSE_WHEEL_DOWN,
        MOUSE_WHEEL_UP
    };

    public class TransferContainer
    {
        InputType inputType = InputType.KEYBOARD;
        VirtualKeyCode keyboardCode = VirtualKeyCode.RETURN;
        TypeOfMouseInput typeofMouseInput = TypeOfMouseInput.LEFT_MOUSE_BUTTON;
        bool buttonPress = false;


        public void AssignKeybind(InputType type, VirtualKeyCode virtualKeyCode)
        {
            inputType = type;
            keyboardCode = virtualKeyCode;
        }

        public void AssignKeybind(InputType type, TypeOfMouseInput mouseInput)
        {
            inputType = type;
            typeofMouseInput = mouseInput;
        }

        public void LaunchBind(bool press)
        {
            if(inputType == InputType.KEYBOARD)
            {
                KeyboardFunctionBind(press);
            }
            else if(inputType == InputType.MOUSE)
            {
                MouseFunctionBind(press);
            }
        }

        void MouseFunctionBind(bool press)
        {
            if (!press)
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
           
        }
        void KeyboardFunctionBind(bool press)
        {
           
        }

        bool IsMouseInputDown(TypeOfMouseInput type)
        {
            if(type == TypeOfMouseInput.LEFT_MOUSE_BUTTON)
            {
                return MouseSimulator.IsLeftMouseClickDown();
            }
            else if (type == TypeOfMouseInput.RIGHT_MOUSE_BUTTON)
            {
                return MouseSimulator.IsRightMouseClickDown();
            }
            else if (type == TypeOfMouseInput.MOVE_MOUSE_LEFT)
            {
                return true;
            }
            else if (type == TypeOfMouseInput.MOVE_MOUSE_RIGHT)
            {
                return true;
            }
            else if (type == TypeOfMouseInput.MOVE_MOUSE_UP)
            {
                return true;
            }
            else if (type == TypeOfMouseInput.MOVE_MOUSE_BOTTOM)
            {
                return true;
            }
            else if (type == TypeOfMouseInput.MOUSE_WHEEL_UP)
            {
                return MouseSimulator.IsScrollMouseUpDown();
            }
            else if (type == TypeOfMouseInput.MOUSE_WHEEL_DOWN)
            {
                return MouseSimulator.IsScrollMouseDownDown();
            }

            return false;
        }
}
    class KeyBindData
    {
        // keybind variable data
        public TransferContainer dpadLeft;
        public TransferContainer dpadRight;
        public TransferContainer dpadTop;
        public TransferContainer dpadBottom;

        public TransferContainer cross;
        public TransferContainer square;
        public TransferContainer triangle;
        public TransferContainer circle;
        public TransferContainer select;
        public TransferContainer start;

        public TransferContainer leftShoulder;
        public TransferContainer rightShoulder;

        public TransferContainer analogLeftXLeft;
        public TransferContainer analogLeftXRight;
        public TransferContainer analogLeftYTop;
        public TransferContainer analogLeftYBottom;
        public TransferContainer analogRightXLeft;
        public TransferContainer analogRightXRight;
        public TransferContainer analogRightYTop;
        public TransferContainer analogRightYBottom;
    }
}
