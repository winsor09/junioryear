using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionChallenge_awinsor
{
    class Program
    {
        static Random rand = new Random(1234);
        static void Main(string[] args)
        {
            List<int> integers = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                integers.Add(rand.Next(0, 1000));
            }
            integers.Sort();
            bool result = SearchIntList(integers, 0);

        }

        public static bool SearchIntList(List<int> integers, int n)
        {
            return SearchIntListRecursive(integers, n, 0, integers.Count - 1);
        }

        private static bool SearchIntListRecursive(List<int> integers, int n, int lowerBound, int upperBound)
        {
            if (lowerBound == upperBound)
            {
                return false;
            }

            int midpoint = ((upperBound - lowerBound) / 2) + lowerBound;

            if (midpoint == n)
            {
                return true;
            }

            if (upperBound - 1 == lowerBound)
            {
                return false;
            }

            if (midpoint > n)
            {
                SearchIntListRecursive(List<int> integers, int n, int lowerBound, int upperBound)
            }

            return false;
        }

    }
}
