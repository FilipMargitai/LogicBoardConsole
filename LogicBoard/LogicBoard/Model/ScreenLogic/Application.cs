using LogicBoard.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBoard.Model.ScreenLogic
{
    enum ComponentClass
    {
        logicGate,
        input,
        output,
        wire
    }
    class Application
    {
        public Board board { get; set; }
        public int xPosition { get; set; }
        public int yPosition { get; set; }
        public Components Components { get; }
        private ComponentClass componentClass { get; set; }
        private int componentIndex { get; set; }
        public bool isDelete { get; set; }
        private KeyboardInputs keyboardInputs { get; set; }
        public Component currentComponent { get; set; }

        public Application(int _xBoardSize, int _yBoardSize)
        {
            Components = new Components();
            keyboardInputs = new KeyboardInputs();
            board = new Board(_xBoardSize, _yBoardSize); // 119 29
            currentComponent = Components.LogicGates[0];
        }
        public void DoUserInput(keyAction keyAction)
        {
            switch (keyAction)
            {
                case keyAction.up:
                    if (xPosition > 0)
                    {
                        xPosition -= 1;
                    }
                    break;
                case keyAction.down:
                    if (xPosition < board.Screen.GetLength(0) - 3) //  tallest component + 1
                    {
                        xPosition += 1;
                    }
                    break;
                case keyAction.left:
                    if (yPosition > 0)
                    {
                        yPosition -= 1;
                    }
                    break;
                case keyAction.right:
                    if (yPosition < board.Screen.GetLength(1) - 6) //  widest component + 1
                    {
                        yPosition += 1;
                    }
                    break;
                case keyAction.gates:
                    isDelete = false;
                    if(componentClass == ComponentClass.logicGate)
                    {
                        if(Components.LogicGates.Count - 1 == componentIndex)
                        {
                            componentIndex = 0;
                        }
                        else
                        {
                            componentIndex++;

                        }
                        currentComponent = Components.LogicGates[componentIndex];
                    }
                    else
                    {
                        componentClass = ComponentClass.logicGate;
                        componentIndex = 0;
                        currentComponent = Components.LogicGates[componentIndex];
                    }
                    break;
                case keyAction.inputs:
                    isDelete = false;
                    if (componentClass == ComponentClass.input)
                    {
                        if (Components.Inputs.Count - 1 == componentIndex)
                        {
                            componentIndex = 0;
                        }
                        else
                        {
                            componentIndex++;
                        }
                        currentComponent = Components.Inputs[componentIndex];
                    }
                    else
                    {
                        componentClass = ComponentClass.input;
                        componentIndex = 0;
                        currentComponent = Components.Inputs[componentIndex];
                    }
                    break;
                case keyAction.outputs:
                    isDelete = false;
                    if (componentClass == ComponentClass.output)
                    {
                        if (Components.Outputs.Count - 1 == componentIndex)
                        {
                            componentIndex = 0;
                        }
                        else
                        {
                            componentIndex++;
                        }
                        currentComponent = Components.Outputs[componentIndex];
                    }
                    else
                    {
                        componentClass = ComponentClass.output;
                        componentIndex = 0;
                        currentComponent = Components.Outputs[componentIndex];
                    }
                    break;
                case keyAction.wires:
                    isDelete = false;
                    if (componentClass == ComponentClass.wire)
                    {
                        if (Components.Wires.Count - 1 == componentIndex)
                        {
                            componentIndex = 0;
                        }
                        else
                        {
                            componentIndex++;
                        }
                        currentComponent = Components.Wires[componentIndex];
                    }
                    else
                    {
                        componentClass = ComponentClass.wire;
                        componentIndex = 0;
                        currentComponent = Components.Wires[componentIndex];
                    }
                    break;
                case keyAction.delete:
                    isDelete = true;
                    break;
                case keyAction.action:
                    board.AddComponent(currentComponent, xPosition, yPosition);
                    break;
                case keyAction.invalid:
                    break;
            }
        }
    }
}
