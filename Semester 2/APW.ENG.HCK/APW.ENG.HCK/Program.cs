using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace APW.ENG.HCK
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = @"C:\Users\202092\Desktop\CodeQuest\CodeQuest\Prob01.in.txt";

            string result;
            List<string> file = new List<string>();
            using (StreamReader sr = new StreamReader(text))
            {
                result = sr.ReadLine();

                string line;
                while ((line = sr.ReadLine()) != null)
                {

                    file.Add(line);

                }
            }

            


            for (int i = 0; i < file.Count; i++)
            {

                if (int.Parse(file[i]) >= 70)
                {
                    Console.WriteLine("Passed");
                }

                else
                {
                    Console.WriteLine("Failed");
                }
                

            }



            Console.ReadLine();


        }
    }
}
