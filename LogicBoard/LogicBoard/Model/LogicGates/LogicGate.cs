using LogicBoard.Model.LogicGates;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBoard.Model
{
    enum LogicGateType
    {
        NOT,
        AND,
        OR,
        XOR,
        NAND,
        NOR,
        XNOR
    }
    class LogicGate
    {
        public LogicGate(LogicGateType logicGateType, char[,] image, InputOutput[] inputs, InputOutput[] outputs)
        {
            LogicGateType = logicGateType;
            Image = image;
            Inputs = inputs;
            Outputs = outputs;
            Height = Image.GetLength(0); //rows
            Width = Image.GetLength(1); //columns
        }
        public LogicGateType LogicGateType { get; }
        public char[,] Image { get; }
        public InputOutput[] Inputs { get; }
        public InputOutput[] Outputs { get; }
        public int Height { get; }
        public int Width { get; }
    }
}
