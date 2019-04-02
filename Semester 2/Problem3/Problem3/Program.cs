using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = @"C:\Users\202092\Desktop\CodeQuest\CodeQuest\Prob03.in.txt";
            
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
            string mystring;
            for (int i = 0; i <= file.Count -1; i++)
            {
                mystring = file[i];
                mystring = mystring.Remove(mystring.Length - 2);
                Console.WriteLine(mystring);
            }

        }
        public void Suffix(string x)
        {
           
            if ( 0 <int.Parse(x) && int.Parse(x) <=1 )
            {

            }
        }
    }
   
}
