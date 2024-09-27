using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Models
{
    internal class HtmlFile
    {
        // Function OR Method For Reading The File
        public string ReadHtmlFile(string path)
        {
            string content = File.ReadAllText(path);
            return content;
        }

        // Function OR Method For Writing into Existing File

        public string WriteHtmlFile(string path)
        {
            Console.WriteLine("\n****** Writing into the Html File ******\n\n");

            File.AppendAllText(path, "\n\n**** I am Durgesh Writing in HTML File ****");
            return "\nContent Written to Html File, Thank You....";
        }
    }
}
