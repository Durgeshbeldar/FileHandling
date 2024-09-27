using FileHandling.Models;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // **** Welcome here ... 
            // Note : in this project there are two entry points one is for File Handling Purpose I used Program.cs
            // other is UserInput.cs which used to implement console app which write the user input to the text file
            // username.txt so lets start.... ****


            /* ==============================================================================================
             * Hello I have created this simple demonstration of File handling in C#
             * Point 1 : I have created 3 files Xml, Html & Text file in Files folder and by using file handling
             * concept Successfully read the data which is inside these 3 files. */

            // I have created string xmlPath which contains the file path where the actual file is located
            string xmlPath = @"S:\Office Work\Monocept Training\Assignments\FileHandling\Files\employee.xml";

            // For clean code I have created 3 classes [XmlFile, HtmlFile, TextFile] each class contains
            // Two Methods for file reading and writing.
            // Here I created xmlFile Object and call the Read Function which you can see in the XmlFile.cs

            XmlFile xmlFile = new XmlFile();
            string content = xmlFile.ReadXmlFile(xmlPath);

            // This Operations are same for the next 2 objects of different classes which i have mentioned above
            Console.WriteLine($"****** XML File is Readed Successfully ******\n\n" + content);

            // Refer the following code For Html and Text File.

            string htmlPath = @"S:\Office Work\Monocept Training\Assignments\FileHandling\Files\index.html";
            HtmlFile htmlFile = new HtmlFile();
            content = htmlFile.ReadHtmlFile(htmlPath);
            Console.WriteLine($"****** HTML File is Readed Successfully ******\n\n" + content);

            string txtPath = @"S:\Office Work\Monocept Training\Assignments\FileHandling\Files\text.txt";
            TxtFile txtFile = new TxtFile();
            content = txtFile.ReadTextFile(txtPath);
            Console.WriteLine($"****** Text File is Readed Successfully ******\n\n" + content);

            /*====================================================================================================
             * Point 2 : Here I Re used the objects created above for implementing Writing Operations to the
             * Corresponding files. I used separeate Methods for writing into the files, we can make it dynamic 
             * in Console Application, You can refer for dynamic text input for adding username into the text File
             * through Console Application.  */

             content = xmlFile.WriteXmlFile(xmlPath);
             Console.WriteLine(content);

             content = htmlFile.WriteHtmlFile(htmlPath);
             Console.WriteLine(content);
             
             content = txtFile.WriteTextFile(txtPath);
             Console.WriteLine(content);
        }
    }
}
