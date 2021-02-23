using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBoard.Model.ConsolePrint
{
    class ConsolePrint
    {
        public static void DrawGate(Component component)
        {
            for (int i = 0; i < component.Image.GetLength(0); i++)  //  print logic gate with inputs and outputs
            {
                for (int j = 0; j < component.Image.GetLength(1); j++)
                {
                    if(component.Inputs.Length > 0)
                    {
                        foreach (var input in component.Inputs) //  inputs - green
                        {
                            if (i == input.xPosition && j == input.yPosition)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                            }
                        }
                    }
                    if (component.Outputs.Length > 0)
                    {
                        foreach (var input in component.Outputs)    //  outputs - yellow
                        {
                            if (i == input.xPosition && j == input.yPosition)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                            }
                        }
                    }
                    Console.Write(component.Image[i, j]);   //  character
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();    //  new line
            }
        }
        public static void DrawGate(Component component, int xPosition, int yPosition)
        {
            for (int i = 0; i < component.Image.GetLength(0); i++)  //  print logic gate with inputs and outputs
            {
                for (int j = 0; j < component.Image.GetLength(1); j++)
                {
                    foreach (var input in component.Inputs) //  inputs - green
                    {
                        if (i == input.xPosition && j == input.yPosition)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                    }
                    foreach (var input in component.Outputs)    //  outputs - yellow
                    {
                        if (i == input.xPosition && j == input.yPosition)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        }
                    }
                    Console.SetCursorPosition(xPosition + j, yPosition + i);
                    Console.Write(component.Image[i, j]);   //  character
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();    //  new line
            }
        }
    }
}
