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

            ConsolePrint.DrawGate(test.LogicGates[0]);
        }
    }
}
