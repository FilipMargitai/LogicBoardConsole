using LogicBoard.Model;
using LogicBoard.Model.LogicGates;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBoard.Data
{
    class Components
    {
        public List<Component> LogicGates { get; }
        public List<Component> Inputs { get; }
        public List<Component> Outputs { get; }
        public List<Component> Wires { get; }
        public Components()
        {
            LogicGates = new List<Component>()
            {
            new Component(
                ComponentType.NOT,
                new char[1,3]{ { '|', '>', 'o' } },
                new InputOutput[1]{ new InputOutput(0, 0) },
                new InputOutput[1]{ new InputOutput(0, 2) }),

            new Component(
                ComponentType.AND,
                new char[3,5]{ { '>', '|', '&', '&', ' ' },
                               { ' ', '|', '&', '&', '>' },
                               { '>', '|', '&', '&', ' ' },
                },
                new InputOutput[2]{ new InputOutput(0, 0), new InputOutput(2, 0)},
                new InputOutput[1]{ new InputOutput(1, 4) }),
            new Component(
                ComponentType.OR,
                new char[3,5]{ { '>', '|', 'O', 'R', ' ' },
                               { ' ', '|', 'O', 'R', '>' },
                               { '>', '|', 'O', 'R', ' ' },
                },
                new InputOutput[2]{ new InputOutput(0, 0), new InputOutput(2, 0)},
                new InputOutput[1]{ new InputOutput(1, 4) }),
            new Component(
                ComponentType.XOR,
                new char[3,5]{ { '>', '|', 'X', 'O', ' ' },
                               { ' ', '|', 'X', 'O', '>' },
                               { '>', '|', 'X', 'O', ' ' },
                },
                new InputOutput[2]{ new InputOutput(0, 0), new InputOutput(2, 0)},
                new InputOutput[1]{ new InputOutput(1, 4) }),
            new Component(
                ComponentType.NAND,
                new char[3,6]{ { '>', '|', '&', '&', ' ', ' '},
                               { ' ', '|', '&', '&', '>', 'o'},
                               { '>', '|', '&', '&', ' ', ' '},
                },
                new InputOutput[2]{ new InputOutput(0, 0), new InputOutput(2, 0)},
                new InputOutput[1]{ new InputOutput(1, 5) }),
            new Component(
                ComponentType.NOR,
                new char[3,6]{ { '>', '|', 'O', 'R', ' ', ' '},
                               { ' ', '|', 'O', 'R', '>', 'o'},
                               { '>', '|', 'O', 'R', ' ', ' '},
                },
                new InputOutput[2]{ new InputOutput(0, 0), new InputOutput(2, 0)},
                new InputOutput[1]{ new InputOutput(1, 5) }),
            new Component(
                ComponentType.XNOR,
                new char[3,6]{ { '>', '|', 'X', 'O', ' ', ' '},
                               { ' ', '|', 'X', 'O', '>', 'o'},
                               { '>', '|', 'X', 'O', ' ', ' '},
                },
                new InputOutput[2]{ new InputOutput(0, 0), new InputOutput(2, 0)},
                new InputOutput[1]{ new InputOutput(1, 5) })
            };
            Inputs = new List<Component>()
            {
            new Component(
                ComponentType.Switch,
                new char[1,3]{ { 'A', '|', '>' } },
                new InputOutput[0],
                new InputOutput[1]{ new InputOutput(0, 2) })
            };
            Outputs = new List<Component>()
            {
            new Component(
                ComponentType.LED,
                new char[1,2]{ { '>', '░' } },
                new InputOutput[1]{ new InputOutput(0, 0) },
                new InputOutput[0])
            };
            Wires = new List<Component>()
            {
            new Component(
                ComponentType.Wire,
                new char[1,1]{ { '─' } },
                new InputOutput[0],
                new InputOutput[0]),
            new Component(
                ComponentType.Wire,
                new char[1,1]{ { '│' } },
                new InputOutput[0],
                new InputOutput[0]),
            new Component(
                ComponentType.Wire,
                new char[1,1]{ { '┌' } },
                new InputOutput[0],
                new InputOutput[0]),
            new Component(
                ComponentType.Wire,
                new char[1,1]{ { '┐' } },
                new InputOutput[0],
                new InputOutput[0]),
            new Component(
                ComponentType.Wire,
                new char[1,1]{ { '└' } },
                new InputOutput[0],
                new InputOutput[0]),
            new Component(
                ComponentType.Wire,
                new char[1,1]{ { '┘' } },
                new InputOutput[0],
                new InputOutput[0])
            };
        }
    }
}