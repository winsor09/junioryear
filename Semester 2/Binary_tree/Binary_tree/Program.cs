using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_tree
{
    class Program
    {
        static void Main(string[] args)
        {


            Binary_Tree mine = new Binary_Tree();


            mine.Insert('i');
            mine.Insert('b');
            mine.Insert('q');
            mine.Insert('t');
            mine.Insert('r');
            mine.Insert('d');
            mine.Insert('e');
            mine.Insert('l');
            mine.Insert('w');
            mine.Insert('z');
            mine.Insert('t');
            mine.Insert('x');

           

            //Console.WriteLine(mine.Search( 'x' ));
            //while (true )
            //{
            //    mine.Print();
            //    mine.Remove(Console.ReadLine()[0]);
            //}
            mine.InOrderPrint();
            Console.WriteLine();
            mine.PostOrderPrint();
            Console.WriteLine();
            mine.PreOrderPrint();


            //mine.Print();

            Console.ReadLine();
        }
    }
}
