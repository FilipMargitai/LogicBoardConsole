using LogicBoard.Data;
using LogicBoard.Model.ConsolePrint;
using System;

namespace LogicBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Components();

            foreach (var item in test.LogicGates)
            {
                ConsolePrint.DrawGate(item);
                Console.WriteLine();
            }
            //ConsolePrint.DrawGate(test.LogicGates[1]);
            //ConsolePrint.DrawGate(test.LogicGates[5], 8, 1);
            //ConsolePrint.DrawGate(test.Input[0], 0, 5);
            //ConsolePrint.DrawGate(test.Output[0], 0, 10);
        }
    }
}
