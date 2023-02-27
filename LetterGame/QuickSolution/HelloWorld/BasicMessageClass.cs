using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class BasicMessageClass
    {
        public BasicMessageClass(string userInput)
        {
            message = userInput; 
        }

        public BasicMessageClass()
        {
      
        }

        private string message = "(default message)";
        public void ShowMessage() { Console.WriteLine(this.message); }

        public string fileName;
        

        public void writeToFile()
        {
            Console.WriteLine("Enter in a file name with .txt included: ");
    
            fileName = Console.ReadLine();

            //Pass the filepath and filename to the StreamWriter Constructor
            StreamWriter stringWriter = new StreamWriter(fileName);

            //Write a line of text
            stringWriter.WriteLine(message);

       
            //Close the file
            stringWriter.Close();



        }

        public void readFromFile()
        {
            StreamReader stringReader = new StreamReader(fileName);
            //Read the first line of text
            string text = stringReader.ReadLine();

            Console.WriteLine(text);
        }

        public string Message
        {
            get { return message; } 
            set { message = value; } 
        }

    }
}
