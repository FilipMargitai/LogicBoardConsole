using LogicBoard.Model;
using LogicBoard.Model.LogicGates;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBoard.Data
{
    class Components
    {
        public List<Component> LogicGates = new List<Component>()
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
                new char[3,7]{ { 'o', '>', '|', '&', '&', ' ', ' '},
                               { ' ', ' ', '|', '&', '&', '>', 'o'},
                               { 'o', '>', '|', '&', '&', ' ', ' '},
                },
                new InputOutput[2]{ new InputOutput(0, 0), new InputOutput(2, 0)},
                new InputOutput[1]{ new InputOutput(1, 6) }),
            new Component(
                ComponentType.NOR,
                new char[3,7]{ { 'o', '>', '|', 'O', 'R', ' ', ' '},
                               { ' ', ' ', '|', 'O', 'R', '>', 'o'},
                               { 'o', '>', '|', 'O', 'R', ' ', ' '},
                },
                new InputOutput[2]{ new InputOutput(0, 0), new InputOutput(2, 0)},
                new InputOutput[1]{ new InputOutput(1, 6) }),
            new Component(
                ComponentType.XNOR,
                new char[3,7]{ { 'o', '>', '|', 'X', 'O', ' ', ' '},
                               { ' ', ' ', '|', 'X', 'O', '>', 'o'},
                               { 'o', '>', '|', 'X', 'O', ' ', ' '},
                },
                new InputOutput[2]{ new InputOutput(0, 0), new InputOutput(2, 0)},
                new InputOutput[1]{ new InputOutput(1, 6) })
        };
        public List<Component> Input = new List<Component>()
        {
            new Component(
                ComponentType.Switch,
                new char[1,3]{ { 'A', '|', '>' } },
                new InputOutput[0],
                new InputOutput[1]{ new InputOutput(0, 2) })
        };
        public List<Component> Output = new List<Component>()
        {
            new Component(
                ComponentType.LED,
                new char[1,2]{ { '>', '░' } },
                new InputOutput[1]{ new InputOutput(0, 0) },
                new InputOutput[0])
        };
    }
}
