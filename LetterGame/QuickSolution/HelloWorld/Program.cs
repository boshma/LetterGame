using HelloWorld;
using System;
using System.IO;
using System;
class Program
{

    public struct AngleStruct
    {
        private double angleRadians; // angle in radians
        public double AngleDegrees // PROPERTY – angle in degrees
        {
            get { return angleRadians * 180.0 / Math.PI; }
            set { angleRadians = value / 180.0 * Math.PI; }
        }
    }
    static void Main()
    {

      

        





        //UserInterface uiObj = new UserInterface();


        //int userChoice = uiObj.getUserChoice();

        //do
        //{
        //    Console.Clear();
        //    switch (userChoice)
        //    {
        //        case 1:
        //            Console.WriteLine("Demonstrating option 1 : passing by value (structs) \n");
        //            AngleStruct degreeStruct = new AngleStruct();
        //            degreeStruct.AngleDegrees = 50;
        //            //double angleStructValue = degreeStruct.AngleDegrees;
        //            AngleStruct degreeStruct2 = new AngleStruct();
        //            degreeStruct2 = degreeStruct;
        //            Console.WriteLine($"degreeStruct is {degreeStruct.AngleDegrees} " +
        //                $" and new structure 'degreeStruct2 has been set to degreeStruct \n");

        //            Console.WriteLine($"degreeStruct degrees: {degreeStruct.AngleDegrees} and degreeStruct2 degrees: {degreeStruct2.AngleDegrees} ");
        //            Console.WriteLine("We will change degreeStruct degrees to 100 and degreeStruct2 degrees will remain unchanged...lets see ");
        //            degreeStruct.AngleDegrees = 100;

        //            Console.WriteLine($"degreeStruct = {degreeStruct.AngleDegrees} and degreeStruct1 = {degreeStruct2.AngleDegrees} \n\n");

        //            Console.WriteLine("Demonstrating option 1 : passing by reference (classes) \n");

        //            AngleClass degreeClassObj = new AngleClass();
        //            degreeClassObj.AngleDegrees = 50;
        //            AngleClass degreeClassObj2 = degreeClassObj;
        //            Console.WriteLine($"We have created degreeClassObj object and set its degrees to " +
        //                $"{degreeClassObj.AngleDegrees} and degreeClassObj2 and set it equal to " +
        //                $"degreeClassObj, now we will change the degree value of degreeClassObj2 to 75\n");

        //            degreeClassObj2.AngleDegrees = 75.0;

        //            Console.WriteLine($"degreeClassObj2.degrees is now {degreeClassObj2.AngleDegrees} " +
        //                $"and now degreeClassObj.degrees is now {degreeClassObj.AngleDegrees}");

        //            Console.WriteLine("\n\n");


        //            userChoice = uiObj.getUserChoice();


        //            break;

        //        case 2:
        //            Console.WriteLine("Showing Hello World in console \n");
        //            BasicMessageClass basicMessageObj = new BasicMessageClass("Hello World");
        //            basicMessageObj.ShowMessage();
        //            Console.WriteLine("\n\n");

        //            userChoice = uiObj.getUserChoice();

        //            break;
        //        case 3:
        //            BasicMessageClass basicMessageObj1 = new BasicMessageClass("Hello World");
        //            Console.WriteLine("Reading Hello World from file \n");
        //            basicMessageObj1.writeToFile();
        //            basicMessageObj1.readFromFile();
        //            Console.WriteLine("\n\n");
        //            userChoice = uiObj.getUserChoice();
        //            break;
        //        case 4:
        //            Console.WriteLine("Adding together index 1 and index 3 of the following linked list" +
        //        ":  12 -> 14 -> 3 -> 4");


        //            LinkedList llObject = new LinkedList();
        //            llObject.initializeLL();

        //            //adding indices 1 and 3
        //            llObject.add(1, 3);

        //            Console.WriteLine("\n\n");
        //            userChoice = uiObj.getUserChoice();

        //            break;
        //        case 0:
        //            break;
        //        default:
        //            break;
        //    }
        // } while (userChoice != 0) ;

        //Console.WriteLine("You've selected to quit, good bye");


    }

        

 }


