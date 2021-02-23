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
                new InputOutput[1]{ new InputOutput(0, 2) }),

            new LogicGate(
                LogicGateType.AND,
                new char[3,5]{ { '>', '|', '&', '&', ' ' },
                               { ' ', '|', '&', '&', '>' },
                               { '>', '|', '&', '&', ' ' },
                },
                new InputOutput[2]{ new InputOutput(0, 0), new InputOutput(2, 0)},
                new InputOutput[1]{ new InputOutput(1, 4) }),
            new LogicGate(
                LogicGateType.OR,
                new char[3,5]{ { '>', '|', 'O', 'R', ' ' },
                               { ' ', '|', 'O', 'R', '>' },
                               { '>', '|', 'O', 'R', ' ' },
                },
                new InputOutput[2]{ new InputOutput(0, 0), new InputOutput(2, 0)},
                new InputOutput[1]{ new InputOutput(1, 4) }),
            new LogicGate(
                LogicGateType.XOR,
                new char[3,5]{ { '>', '|', 'X', 'O', ' ' },
                               { ' ', '|', 'X', 'O', '>' },
                               { '>', '|', 'X', 'O', ' ' },
                },
                new InputOutput[2]{ new InputOutput(0, 0), new InputOutput(2, 0)},
                new InputOutput[1]{ new InputOutput(1, 4) }),
            new LogicGate(
                LogicGateType.NAND,
                new char[3,7]{ { 'o', '>', '|', '&', '&', ' ', ' '},
                               { ' ', ' ', '|', '&', '&', '>', 'o'},
                               { 'o', '>', '|', '&', '&', ' ', ' '},
                },
                new InputOutput[2]{ new InputOutput(0, 0), new InputOutput(2, 0)},
                new InputOutput[1]{ new InputOutput(1, 6) }),
            new LogicGate(
                LogicGateType.NOR,
                new char[3,7]{ { 'o', '>', '|', 'O', 'R', ' ', ' '},
                               { ' ', ' ', '|', 'O', 'R', '>', 'o'},
                               { 'o', '>', '|', 'O', 'R', ' ', ' '},
                },
                new InputOutput[2]{ new InputOutput(0, 0), new InputOutput(2, 0)},
                new InputOutput[1]{ new InputOutput(1, 6) }),
            new LogicGate(
                LogicGateType.XNOR,
                new char[3,7]{ { 'o', '>', '|', 'X', 'O', ' ', ' '},
                               { ' ', ' ', '|', 'X', 'O', '>', 'o'},
                               { 'o', '>', '|', 'X', 'O', ' ', ' '},
                },
                new InputOutput[2]{ new InputOutput(0, 0), new InputOutput(2, 0)},
                new InputOutput[1]{ new InputOutput(1, 6) })
        };
    }
}
