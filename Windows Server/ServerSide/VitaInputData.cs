using System;

namespace Networking
{
    [Serializable]
    public class VitaInputData
    {
        //General Buttons
        public bool cross = false;
        public bool circle = false;
        public bool triangle = false;
        public bool square = false;
        public bool leftShoulder = false;
        public bool rightShoulder = false;
        public bool start = false;
        public bool select = false;

        // DPAD
        public bool dPadLeft = false;
        public bool dPadRight = false;
        public bool dPadUp = false;
        public bool dPadDown = false;

        // Analogue
        public float analogLeftX = 0.0f;
        public float analogLeftY = 0.0f;
        public float analogRightX = 0.0f;
        public float analogRightY = 0.0f;
    }
}