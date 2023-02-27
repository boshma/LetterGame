using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class UserInterface
    {
        public int getUserChoice()
        {
            Console.WriteLine("C# Demos \n 1 = Show the pass by reference and pass by value scenario" +
                "\n 2 = Show Hello World on the screen " +
                "\n 3 = Write Hello World in a file " +
                "\n 4 = Adding two numbers in a linked list " +
                "\n 0 = Quit");
            string userAns = Console.ReadLine();

            int userAnsInt = Int32.Parse(userAns);

            return userAnsInt;
        }
    }
}
