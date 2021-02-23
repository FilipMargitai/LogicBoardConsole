using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBoard.Model.ConsolePrint
{
    class ConsolePrint
    {
        public static void DrawGate(LogicGate logicGate)
        {
            for (int i = 0; i < logicGate.Image.GetLength(0); i++)  //  print logic gate with inputs and outputs
            {
                for (int j = 0; j < logicGate.Image.GetLength(1); j++)
                {
                    foreach (var input in logicGate.Inputs) //  inputs - green
                    {
                        if (i == input.xPosition && j == input.yPosition)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                    }
                    foreach (var input in logicGate.Outputs)    //  outputs - yellow
                    {
                        if (i == input.xPosition && j == input.yPosition)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                    }
                    Console.Write(logicGate.Image[i, j]);   //  character
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();    //  new line
            }
        }
    }
}
