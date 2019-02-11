using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Algorithm_Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;
            Console.WriteLine("1 - Problem 1\n2 - Problem 2\n3 - Problem 3\n");

            menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    string text = AppDomain.CurrentDomain.BaseDirectory + @"Prob01.in.txt";


                    List<string> file = new List<string>();
                    using (StreamReader sr = new StreamReader(text))
                    {

                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {

                            file.Add(line);

                        }
                    }


                    float ttl = 0;
                    float subttl = 0;
                    string amount = "";

                    for (int i = 0; i < file.Count; i++)
                    {
                        subttl = 0;
                        if (file[i].Contains("QUARTER"))
                        {

                            amount = file[i].Substring(8);
                            subttl = .25f * float.Parse(amount);
                        }

                        if (file[i].Contains("DIME"))
                        {

                            amount = file[i].Substring(5);
                            subttl = .10f * float.Parse(amount);
                        }

                        if (file[i].Contains("NICKEL"))
                        {

                            amount = file[i].Substring(7);
                            subttl = .05f * float.Parse(amount);
                        }

                        if (file[i].Contains("PENNY"))
                        {

                            amount = file[i].Substring(6);
                            subttl = .01f * float.Parse(amount);
                        }

                        if (file[i].Contains("HALFDOLLAR"))
                        {

                            amount = file[i].Substring(11);
                            subttl = .50f * float.Parse(amount);
                        }

                        ttl = ttl + subttl;

                    }

                    Console.WriteLine("$" + ttl);
                    Console.ReadLine();

                    break;


                case 2:

                    string text2 = AppDomain.CurrentDomain.BaseDirectory + @"Prob02.in.txt";


                    List<List<string>> file2 = new List<List<string>>();
                    using (StreamReader sr = new StreamReader(text2))
                    {

                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            file2.Add(new List<string>());
                            string[] Array = line.Split(' ');
                            for (int i = 0; i < Array.Length; i++)
                            {
                                file2[file2.Count - 1].Add(Array[i]);
                            }

                        }
                    }

                    for (int i = 0; i < file2.Count; i++)
                    {
                        bool isascending = true;
                        bool isdescending = true;
                        bool isvalid = true;
                        for (int j = 0; j < file2[i].Count - 1; j++)
                        {
                            int left = 0;
                            int right = 0;
                            if (!int.TryParse(file2[i][j], out left))
                            {
                                Console.WriteLine("Invalid.");
                                isvalid = false;
                                break;
                            }

                            if (!int.TryParse(file2[i][j + 1], out right))
                            {
                                Console.WriteLine("Invalid.");
                                isvalid = false;
                                break;
                            }

                            if (left < right)
                            {
                                isdescending = false;
                            }

                            if (left > right)
                            {
                                isascending = false;
                            }
                        }

                        if (isvalid == true)
                        {
                            if (isascending == false && isdescending == false)
                            {
                                Console.WriteLine("Random.");
                            }

                            else if (isdescending == true)
                            {
                                Console.WriteLine("Is Descending.");
                            }

                            else if (isascending == true)
                            {
                                Console.WriteLine("Is Ascending.");
                            }
                        }



                    }

                    Console.ReadLine();
                    break;

                case 3:
                    string text3 = AppDomain.CurrentDomain.BaseDirectory + @"Prob03.in.txt";


                    List<List<string>> file3 = new List<List<string>>();
                    using (StreamReader sr = new StreamReader(text3))
                    {

                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            file3.Add(new List<string>());
                            string[] Array3 = line.Split('-');
                            for (int i = 0; i < Array3.Length; i++)
                            {
                                file3[file3.Count - 1].Add(Array3[i]);
                            }

                        }
                    }

                    break;
            }

        }
    }
}
