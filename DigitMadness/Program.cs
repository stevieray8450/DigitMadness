using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitMadness
{
    class Program
    {
        public static void digPow(int n, int p)
        {
            List<int> intList = new List<int>();

            while (n != 0)
            {
                int lastDigit = n % 10;
                intList.Add(lastDigit);
                n /= 10;
            }

            intList.Reverse();

            ////testing only
            //foreach(int item in intList)
            //{
            //    Console.Write(item.ToString());
            //}
            //Console.WriteLine();
            //Console.WriteLine("************");

            List<double> expoList = new List<double>();
            List<double> doubleList = new List<double>();

            foreach(int item in intList)
            {
                doubleList.Add(Convert.ToDouble(item));
                //expoList.Add(Math.Pow(item, p));
                //p++;
            }

            foreach(double item in doubleList)
            {
                expoList.Add(Math.Pow(item, p));
                p++;
            }

            ////testing only
            //foreach (double item in expoList)
            //{
            //    Console.WriteLine(item.ToString());
            //}
        
        }
        static void Main(string[] args)
        {
            digPow(44, 2);

        }
    }
}
