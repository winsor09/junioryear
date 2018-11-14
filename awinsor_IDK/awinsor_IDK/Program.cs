using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Readtext
{
    class Program
    {
        static void Main(string[] args)
        {
            string path;
            int answr;
            int[] array = new int[10];
            int[] storage = new int[10];
            Random rand = new Random();
            path = AppDomain.CurrentDomain.BaseDirectory + "Example.txt";

            do
            {
                Console.WriteLine("***************************************");
                Console.WriteLine("1 - Save a random array to a file");
                Console.WriteLine("2 - Load a random array from a file");
                Console.WriteLine("3 - Print random array from memory");
                Console.WriteLine("4 - Exit Program");
                Console.WriteLine("***************************************");
                
                Console.WriteLine();
                answr = int.Parse(Console.ReadLine());

                switch (answr)
                {
                    case 1:
                        using (StreamWriter sw = new StreamWriter(path))
                        {
                            for (int i = 0; i < array.Length; i++)
                            {
                                array[i] = rand.Next();
                            }

                            for (int i = 0; i < array.Length; i++)
                            {
                                sw.WriteLine(array[i]);
                            }
                        }
                        Console.WriteLine("Saved Random Array To File!");
                        Console.WriteLine();
                        break;

                    case 2:
                        List<string> file = new List<string>();
                        using (StreamReader sr = new StreamReader(path))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                file.Add(line);
                            }
                        }
                        for (int i = 0; i < file.Count; i++)
                        {

                            storage[i] = int.Parse(file[i]);
                        }
                        Console.WriteLine("Loaded Random Array To Variable Storage!");
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine();
                        for (int i = 0; i < storage.Length; i++)
                        {

                            Console.WriteLine(storage[i]);
                        }
                       
                        Console.WriteLine();
                        Console.WriteLine("Variable Storage Printed To Console!");
                        Console.WriteLine();
                        break;
                }
            }
            while (answr != 4);

            Console.WriteLine();
            Console.WriteLine("Program Shutting Down, Goodbye!");
        }
    }
}


