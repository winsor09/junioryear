using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = @"C:\Users\202092\Desktop\CodeQuest\CodeQuest\Prob02.in.txt";

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

            int total = 0;
            var vowels = new HashSet<string> { "a", "e", "i", "o", "u" };

            for (int r = 0; r < file.Count; r++)
            {
                for (int i = 0; i < file[r].Length; i++)
                {

                    if (vowels.Contains(file[r][i].ToString()))
                    {
                        total++;
                    }


                }

                Console.WriteLine("Your total number of vowels is: " + total);
            }


            

            Console.ReadLine();

        }
    }
}
