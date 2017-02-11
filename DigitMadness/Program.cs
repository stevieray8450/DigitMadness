using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitMadness
{
    class Program
    {
        public static long digPow(int n, int p)
        {
            List<int> intList = new List<int>();

            int stepper = n;
            while (stepper != 0)
            {
                int lastDigit = stepper % 10;
                intList.Add(lastDigit);
                stepper /= 10;
            }

            intList.Reverse();

            // testing only
            foreach (int item in intList)
            {
                Console.Write(item.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("************");

            List<double> expoList = new List<double>();
            List<double> doubleList = new List<double>();

            foreach(int item in intList)
            {
                doubleList.Add(Convert.ToDouble(item));
            }

            foreach(double item in doubleList)
            {
                expoList.Add(Math.Pow(item, p));
                p++;
            }

            //testing only
            foreach (double item in expoList)

            {
                Console.WriteLine(item.ToString());
            }

            //sums up all expoList items
            double sumList = 0;
            foreach(double item in expoList)
            {
                sumList += item;
            }

            //testing only
            Console.WriteLine("*****************");
            Console.WriteLine(sumList.ToString());

            long longSumList = Convert.ToInt64(sumList);

            long k = longSumList / n;

            if (longSumList % n != 0)
            {
                return -1;
            }
            else
            {
                return k;
            }
        }
        static void Main(string[] args)
        {
           long poop = digPow(91, 3);
           Console.WriteLine(poop.ToString());
        }
    }
}
