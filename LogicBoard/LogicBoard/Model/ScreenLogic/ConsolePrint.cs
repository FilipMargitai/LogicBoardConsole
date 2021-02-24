using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBoard.Model.ConsolePrint
{
    class ConsolePrint
    {
        public static void PrintBoard(Board board)
        {
            for (int i = 0; i < board.x_Size; i++)
            {
                for (int j = 0; j < board.y_Size; j++)
                {
                    if(board.InputsOrOutputs[i,j] == InputOrOutput.Input) Console.ForegroundColor = ConsoleColor.Green;
                    else if(board.InputsOrOutputs[i,j] == InputOrOutput.Output) Console.ForegroundColor = ConsoleColor.DarkYellow;
                    else Console.ForegroundColor = ConsoleColor.White;

                    Console.Write(board.Screen[i, j].ToString());
                }
                Console.WriteLine();
            }
        }
    }
}
