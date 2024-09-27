using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Models
{
    internal class XmlFile
    {
        // Function OR Method For Reading The File
        public string ReadXmlFile(string path)
        {
            string content = File.ReadAllText(path);
            return content;
        }

        // Function OR Method For Writing into Existing File

        public string WriteXmlFile(string path) 
        {
            Console.WriteLine("\n****** Writing into the Xml File ******\n\n");

            File.AppendAllText(path, "\n\n**** I am Durgesh Writing in XML File ****");
            return "\nContent Written to Xml File, Thank You....";
        }
    }
}
