using _09_StreamingContent_Console.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_StreamingContent_Ui_Refactor_Tests.UI
{
    public class MockConsole : IConsole
    {
        //creating fake user input 2  lines below
        public Queue<string> UserInput;
        public string Output;

        public MockConsole(IEnumerable<string>input)
        {
            UserInput = new Queue<string>(input);
                Output = "";
        }
        public void Clear()
        {
            Output += "called clear method\n";
            //Output = Output = "called clear method\n";
        }
        public ConsoleKeyInfo ReadKey()
        {
            return new ConsoleKeyInfo();
        }
        public string ReadLine()
        {
            return UserInput.Dequeue();
        }
        public void WriteLine(string s )
        {
            Output += s + "\n";
        }
        public void WriteLine(object o)
        {
            Output += o + "\n";
        }
    }
}
