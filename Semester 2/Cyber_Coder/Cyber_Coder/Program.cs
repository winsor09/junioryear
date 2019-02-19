using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cyber_Coder
{
    class Program
    {
        static void Main(string[] args)
        {

            //reading in the file
            string text = AppDomain.CurrentDomain.BaseDirectory + @"Prob01.in.txt";

            
            List<List<string>> file = new List<List<string>>();
            
            //puts file into list so it can be read
            using (StreamReader sr = new StreamReader(text))
            {

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    file.Add(new List<string>());
                    string[] Array = line.Split(',');
                    for (int i = 0; i < Array.Length; i++)
                    {
                        file[file.Count - 1].Add(Array[i]);
                    }

                }
            }
            
            for (int i = 0; i < file.Count; i++)
            {

                

                file[i] = file[i].OrderBy(t => t).ToList();
            }


            for (int i = 0; i < file.Count; i++)
            {
                for (int j = 0; j < file[i].Count; j++)
                {
                    Console.Write(file[i][j] + ", ");
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
