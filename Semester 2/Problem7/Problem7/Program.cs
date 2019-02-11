using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = @"C:\Users\202092\Desktop\CodeQuest\CodeQuest\Prob07.in.txt";

            string result;
            
            List<List<string>> sets = new List<List<string>>();
            using (StreamReader sr = new StreamReader(text))
            {
                
                result = sr.ReadLine();

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    for (int i = 0; i < sets.Count; i++)
                    {
                        sets.Add(new List<string>());
                    }
                    
                    

                }
            }


            ///////////////////////

            for (int r = 0; r < sets.Count; r++)
            {
                
                
                    //palendrome
                    string plndrm = "";

                    plndrm = sets[r][0];

                    plndrm = plndrm.ToLower();

                    for (int i = 0; i < plndrm.Length; i++)
                    {
                        if (plndrm[i] != plndrm[plndrm.Length - 1 - i])
                        {
                            i = plndrm.Length - 1;
                            Console.WriteLine("False.");
                        }

                        else if (plndrm[i] == plndrm[plndrm.Length - 1 - i])
                        {
                            if (i == plndrm.Length - 1)
                            {
                                Console.WriteLine("True.");
                            }

                        }


                    }


                

               
            }




            Console.ReadLine();



        }
    }
}
