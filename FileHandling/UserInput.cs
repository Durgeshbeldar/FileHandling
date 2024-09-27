using FileHandling.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace FileHandling
{
    internal class UserInput
    {
        // UserInput.cs This is the second entry file for this assignment.

        public static void Main(string[] args)
        {
            // Prompt For user
            Console.WriteLine("******* Welcome to Console App To Save Your UserNames *******" +
                "\n\nEnter a username : ");

            // Getting input from user and storing into the string variable
            string userInputString = Console.ReadLine();

            // This the file path on which we are working to store data
            string filePath = @"S:\Office Work\Monocept Training\Assignments\FileHandling\Files\username.txt";
            File.AppendAllText(filePath, userInputString + Environment.NewLine);

            Console.WriteLine("\nDocument is Written Successfully\n");

            // Calling the function using class name 
            TxtFile user = new TxtFile();

            // to display the content of username.txt file 
            string content = user.ReadTextFile(filePath);
            Console.WriteLine("\n*** UserData Fetched ***\n" + content);


        }
    }
}
