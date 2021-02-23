using LogicBoard.Model;
using LogicBoard.Model.LogicGates;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBoard.Data
{
    class Components
    {
        public List<LogicGate> LogicGates = new List<LogicGate>()
        {
            new LogicGate(
                LogicGateType.NOT,
                new char[1,3]{ { '|', '>', 'o' } },
                new InputOutput[1]{ new InputOutput(0, 0) },
                new InputOutput[1]{ new InputOutput(0, 2) })
        };
    }
}
