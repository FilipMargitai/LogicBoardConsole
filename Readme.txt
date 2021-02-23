Console program that allows user to create, run, edit, save and load logic boards.  
  
Whole application is created in C# .NET Core console, as a free time project.  
The idea came from this older post https://codegolf.stackexchange.com/questions/22850/ascii-art-logic-gate-diagram  
  
It is and editor as well as a simulator, it should also be able to run circuits that u can  
"draw" in notepad, if you use the right characters and form.  
  
Circuit example (should be able to edit and run):  
  
A|>────|>o───>│&&  
              │&&>────┐  
B|>────|>o───>│&&     └>│OR  
                        │OR>────>█  
B|>──────────>│&&     ┌>│OR  
              │&&>────┘  
C|>──────────>│&&  
  
  
This is the list of all logic gates, the program supports:  
  
NOT  
────────|>o───────  
  
AND  
───────>│&&  
	│&&>────  
───────>│&&  
  
OR  
───────>│OR  
	│OR>────  
───────>│OR  
  
XOR  
───────>│XO  
	│XO>────  
───────>│XO  
  
NAND  
──────o>│&&  
	│&&>o───  
──────o>│&&  
  
NOR  
──────o>│OR  
	│OR>o───  
──────o>│OR  
  
XNOR  
──────o>│XO  
	│XO>o───  
──────o>│XO  
  
  
This is the list of all inputs, the program supports:  
  
Switch  
Off  
A|>  
On  
A->  
  
  
This is the list of all outputs, the program supports:  
  
LED(changes colour depending on status - on, off)  
>█  
  
  
Some other characters that are used for drawing circuits:  
  
─│┌┐└ ┘█░▒▓┼  
