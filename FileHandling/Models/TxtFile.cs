using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling.Models
{
    internal class TxtFile
    {
        // Function OR Method For Reading The File
        public string ReadTextFile(string path)
        {
            string content = File.ReadAllText(path);
            return content;
        }

        // Function OR Method For Writing into Existing File

        public string WriteTextFile(string path)
        {
            Console.WriteLine("\n****** Writing into the Text File ******\n\n");

            File.AppendAllText(path, "\n\n**** I am Durgesh Writing in Text File ****");
            return "\nContent Written to Text File, Thank You....";
        }
    }
}
