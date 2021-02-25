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
        public Board runBoard { get; set; }
        public int xPosition { get; set; }
        public int yPosition { get; set; }
        public Components Components { get; }
        private ComponentClass componentClass { get; set; }
        private int componentIndex { get; set; }
        private KeyboardInputs keyboardInputs { get; set; }
        public Component currentComponent { get; set; }
        public bool debugMode { get; set; }

        public Application(int _xBoardSize, int _yBoardSize)
        {
            Components = new Components();
            keyboardInputs = new KeyboardInputs();
            board = new Board(_xBoardSize, _yBoardSize); // 119 29
            runBoard = board;
            currentComponent = Components.LogicGates[0];
        }
        public void DoUserInput(keyAction keyAction)
        {
            if (debugMode)
            {
                if (keyAction == keyAction.switchMode) debugMode = false;
                else if (keyAction == keyAction.inputA || keyAction == keyAction.inputB || keyAction == keyAction.inputC || keyAction == keyAction.inputD)
                {
                    RunCircuit(keyAction);
                }
            }
            else
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
                        if (componentClass == ComponentClass.logicGate)
                        {
                            if (Components.LogicGates.Count - 1 == componentIndex)
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
                        board.Screen[xPosition, yPosition] = ' ';
                        board.InputsOrOutputs[xPosition, yPosition] = InputOrOutput.Empty;
                        runBoard = board;
                        break;
                    case keyAction.action:
                        board.AddComponent(currentComponent, xPosition, yPosition);
                        runBoard = board;
                        break;
                    case keyAction.switchMode:
                        debugMode = true;
                        break;
                    case keyAction.invalid:
                        break;
                }
            }
        }
        public void RunCircuit(keyAction inputChange)
        {
            switch (inputChange)
            {
                case keyAction.inputA:
                    FindInputs('A');
                    break;               
                case keyAction.inputB:
                    FindInputs('B');
                    break;             
                case keyAction.inputC:
                    FindInputs('C');
                    break;            
                case keyAction.inputD:
                    FindInputs('D');
                    break;
            }
            for (int i = 0; i < runBoard.Screen.GetLength(0); i++)
            {
                for (int j = 0; j < runBoard.Screen.GetLength(1); j++)
                {
                    if (runBoard.Screen[i, j] == 'A' || runBoard.Screen[i,j] == 'B' || runBoard.Screen[i, j] == 'C' || runBoard.Screen[i, j] == 'D')
                    {
                        if (runBoard.Screen[i, j + 1] == '|') // input is false
                        {

                        }
                        else // input is true
                        {

                        }
                    }
                }
            }
        }
        private void FindInputs(char letter)
        {
            for (int i = 0; i < runBoard.Screen.GetLength(0); i++)
            {
                for (int j = 0; j < runBoard.Screen.GetLength(1); j++)
                {
                    if(runBoard.Screen[i, j] == letter)
                    {
                        if (runBoard.Screen[i, j + 1] == '|') runBoard.Screen[i, j + 1] = '─';
                        else runBoard.Screen[i, j + 1] = '|';
                    }
                }
            }
        }
    }
}
