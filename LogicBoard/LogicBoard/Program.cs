using LogicBoard.Data;
using LogicBoard.Model;
using LogicBoard.Model.ConsolePrint;
using LogicBoard.Model.ScreenLogic;
using System;

namespace LogicBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyboardInputs = new KeyboardInputs();
            var app = new Application(119, 27);

            keyAction userInput = keyAction.invalid;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Key inputs - arrows to move, g for gates, i for inputs, o for outputs, w for wires, spacebar or enter for placing,\ndelete to delete");
                ConsolePrint.PrintBoard(app.board);
                ConsolePrint.PrintCursor(app);
                userInput = keyboardInputs.PressKey();
                app.DoUserInput(userInput);
            }

            //foreach (var item in test.LogicGates)
            //{
            //    ConsolePrint.DrawGate(item);
            //    Console.WriteLine();
            //}
            //ConsolePrint.DrawGate(test.LogicGates[1]);
            //ConsolePrint.DrawGate(test.LogicGates[5], 8, 1);
            //ConsolePrint.DrawGate(test.Input[0], 0, 5);
            //ConsolePrint.DrawGate(test.Output[0], 118, 29);
        }
    }
}
