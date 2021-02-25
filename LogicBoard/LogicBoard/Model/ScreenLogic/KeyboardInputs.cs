using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBoard.Model.ScreenLogic
{
    enum keyAction
    {
        up,
        down,
        left,
        right,
        gates,
        inputs,
        outputs,
        wires,
        delete,
        action,
        switchMode,
        inputA,
        inputB,
        inputC,
        inputD,
        invalid
    }
    class KeyboardInputs
    {
        private ConsoleKey key { get; set; }
        public keyAction PressKey()
        {
            key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    return keyAction.up;
                case ConsoleKey.DownArrow:
                    return keyAction.down;
                case ConsoleKey.LeftArrow:
                    return keyAction.left;
                case ConsoleKey.RightArrow:
                    return keyAction.right;
                case ConsoleKey.G:
                    return keyAction.gates;
                case ConsoleKey.I:
                    return keyAction.inputs;
                case ConsoleKey.O:
                    return keyAction.outputs;
                case ConsoleKey.Delete:
                    return keyAction.delete;     
                case ConsoleKey.Spacebar:
                    return keyAction.action;
                case ConsoleKey.Enter:
                    return keyAction.action;
                case ConsoleKey.W:
                    return keyAction.wires;          
                case ConsoleKey.R:
                    return keyAction.switchMode;     
                case ConsoleKey.A:
                    return keyAction.inputA;
                case ConsoleKey.B:
                    return keyAction.inputB;
                case ConsoleKey.C:
                    return keyAction.inputC;          
                case ConsoleKey.D:
                    return keyAction.inputD;
                default:
                    return keyAction.invalid;
            }
        }
    }
}
