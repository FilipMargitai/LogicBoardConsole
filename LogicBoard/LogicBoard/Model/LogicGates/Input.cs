using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBoard.Model.LogicGates
{
    class InputOutput
    {
        public InputOutput(int xPosition, int yPosition)
        {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
        }

        public int xPosition { get; }
        public int yPosition { get; }
    }
}
