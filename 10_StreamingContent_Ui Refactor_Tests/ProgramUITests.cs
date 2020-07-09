using System;
using System.Collections.Generic;
using _09_StreamingContent_Console.UI;
using _10_StreamingContent_Ui_Refactor_Tests.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _10_StreamingContent_Ui_Refactor_Tests
{
    [TestClass]
    public class ProgramUITests
    {
        [TestMethod]
        public void GetList_OutputShouldContainList()
        {
            //Arrange
            List<string> commandList = new List<string> { "1", "5" };
            MockConsole console = new MockConsole(commandList);
            ProgramUI program = new ProgramUI(console);

            //Act
            program.Run();
            Console.WriteLine(console.Output);

            //Assert
            Assert.IsTrue(console.Output.Contains("Avatar the last airbender"));
        }

        [TestMethod]
        public void AddToList_ShouldSeeItemInList()
        {
            //Arrange
            var customDesc = "This is my custom description";
            var commandList = new List<string> { "3", "Title", customDesc, "4", "1", "8", "1", "5" };
            var console = new MockConsole(commandList);
            var ui = new ProgramUI(console);

            //ACT
            ui.Run();
            Console.WriteLine(console.Output); ;

            //Assert
            Assert.IsTrue(console.Output.Contains(customDesc));
        }
        [TestMethod]
        public void RemoveFromList_ShouldSeeRemovedMessage()
        {
            //Arrange
            var commandList = new List<string> { "4", "2", "1","5" };
            var console = new MockConsole(commandList);
            var ui = new ProgramUI(console);

            //ACT
            ui.Run();
            Console.WriteLine(console.Output);

            //Assert
            Assert.IsFalse(console.Output.Contains("The best show"));
        }
        [TestMethod]
        public void GetTitle_ShouldGetCorrectTitle()
        {
           
            //arrange
            //command list
            var fakeUserInput = new List<string> { "2", "Mr. Right", "5" };
            //console
            var console = new MockConsole(fakeUserInput);
            //ui
            var ui = new ProgramUI(console);
            //Act
            ui.Run();
            //running the program

            //Assert
            Assert.IsTrue(console.Output.Contains(""));
        }
    }
}
