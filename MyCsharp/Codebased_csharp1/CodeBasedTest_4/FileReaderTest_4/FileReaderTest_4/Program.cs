
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileReaderTest_4
{
    class Program
    {
        static void Main()
        {
            string fileAddress= "FileReader.txt";
            using (StreamWriter writer = new StreamWriter(fileAddress, true))
            {
                Console.WriteLine("Enter any data to append to the file (Ctrl+Z to finish):");
                while (true)
                {
                    string input = Console.ReadLine();
                    if (input == null)
                        break;
                    writer.WriteLine(input);
                }
                Console.WriteLine("Data got appended to the file successfully.");
                Console.ReadLine();
            }
        }
    }
}
