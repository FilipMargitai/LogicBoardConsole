using LogicBoard.Data;
using LogicBoard.Model;
using LogicBoard.Model.ConsolePrint;
using System;

namespace LogicBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Components();
            var testBoard = new Board(118, 30);

            testBoard.AddComponent(test.LogicGates[2], 0, 0);
            testBoard.AddComponent(test.LogicGates[4], 1, 5);
            ConsolePrint.PrintBoard(testBoard);
            Console.ReadKey();

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
