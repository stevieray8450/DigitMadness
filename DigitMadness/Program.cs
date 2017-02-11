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
            Console.WriteLine("The integer argumnet, printed by splitting each digit from the integer itself: ");
            foreach (int item in intList)
            {
                Console.Write(item.ToString());
            }

            // for the sake of printing some space for separation
            Console.WriteLine();
            Console.WriteLine("*****************");

            List<double> expoList = new List<double>();
            List<double> doubleList = new List<double>();

            // converts each digit in the intList list to a double value
            // Math.Pow() method uses doubles
            foreach(int item in intList)
            {
                doubleList.Add(Convert.ToDouble(item));
            }

            // raises each digit in the doubleList to the power of argument p, but p increments
            // by 1 for each digit in the list 
            foreach(double item in doubleList)
            {
                expoList.Add(Math.Pow(item, p));
                p++;
            }

            //testing only
            Console.WriteLine("Prints the result of each digit being exponentially multiplied: ");
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
            Console.WriteLine("The sum of the exponents of each digit: " + sumList.ToString());

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
           long test = digPow(89, 1);
            Console.WriteLine("Prints the value of k, which is the value by which the sum needs to be multiplied to " +
               "equal the n argument: ");
           Console.WriteLine(test.ToString());
        }
    }
}
