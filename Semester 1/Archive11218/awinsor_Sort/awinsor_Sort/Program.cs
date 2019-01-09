using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awinsor_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
        
            int temp = 0;
            int[] array = new int[10];
            int seed = 1234;
            Random rand = new Random(seed);

            for( int x = 0; x < array.Length; x++)
            {
                array[x] = rand.Next(0, 10);
            }

            for(int i = 0; i < array.Length; i ++)
            {
                Console.WriteLine(array[i]);
            }
            
            Console.ReadLine();
            for(int i = 0; i < array.Length; i++)
            {

                for(int j = 0; j < array.Length; j++)
                {
                    if (array[j] > array[i])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;


                    }
                }
               
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();

        }
    }
}
