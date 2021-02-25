using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBoard.Model
{
    enum InputOrOutput
    {
        Empty,
        Input,
        Output
    }
    class Board
    {
        public Board(int y_size, int x_size)
        {
            x_Size = x_size;
            y_Size = y_size;
            Screen = new char[x_size, y_size];
            InputsOrOutputs = new InputOrOutput[x_size, y_size];
            for(int i = 0; i < x_Size; i++)
            {
                for(int j = 0; j < y_Size; j++)
                {
                    Screen[i,j] = ' ';
                    InputsOrOutputs[i,j] = InputOrOutput.Empty;
                }
            }
        }
        public int x_Size { get; }
        public int y_Size { get; }
        public char[,] Screen { get; set; }
        public InputOrOutput[,] InputsOrOutputs { get; set; }
        public void AddComponent(Component component, int xPosition, int yPosition)
        {
            for (int i = 0; i < component.Image.GetLength(0); i++)
            {
                for (int j = 0; j < component.Image.GetLength(1); j++)
                {
                    Screen[i + xPosition, j + yPosition] = component.Image[i, j];
                }
            }
            foreach(var IO in component.Inputs)
            {
                InputsOrOutputs[IO.xPosition + xPosition, IO.yPosition + yPosition] = InputOrOutput.Input;
            }        
            foreach(var IO in component.Outputs)
            {
                InputsOrOutputs[IO.xPosition + xPosition, IO.yPosition + yPosition] = InputOrOutput.Output;
            }
        }
        //public void DeleteComponent()
    }
}
