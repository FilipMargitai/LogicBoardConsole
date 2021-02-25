using LogicBoard.Model.LogicGates;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBoard.Model
{
    enum ComponentType
    {
        NOT,
        AND,
        OR,
        XOR,
        NAND,
        NOR,
        XNOR,
        LED,
        Switch,
        Wire
    }
    class Component
    {
        public Component(ComponentType componentType, char[,] image, InputOutput[] inputs, InputOutput[] outputs)
        {
            ComponentType = componentType;
            Image = image;
            Inputs = inputs;
            Outputs = outputs;
            Height = Image.GetLength(0); //rows
            Width = Image.GetLength(1); //columns
        }
        public ComponentType ComponentType { get; }
        public char[,] Image { get; }
        public InputOutput[] Inputs { get; }
        public InputOutput[] Outputs { get; }
        public int Height { get; }
        public int Width { get; }
        public override string ToString()
        {
            return ComponentType.ToString();
        }
    }
}
