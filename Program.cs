using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        public static void writeFile()
        {
            using(StreamWriter fileWriter = new StreamWriter(new FileStream("toolDAT.DAT", FileMode.Create)))
            {
                fileWriter.WriteLine("130");
            }
        }

        public static string readFile()
        {
            try
            {
                using(StreamReader fileReader = new StreamReader("toolDAT.DAT"))
                {
                    string line = fileReader.ReadLine().ToString();
                    if(line != null) return line;
                    else return "";
                }
            }
            catch { return "Exception";}
        }

        public static void Main()
        {
            writeFile();
            Console.WriteLine(readFile());
            Console.ReadLine();
        }
    }
}
