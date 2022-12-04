// Ex: 5.1 (i)



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 8;
            int[] numArr = new int[num];
            int sumOfOdd = 0;
            int sumOfEven = 0;
            for(int i = 0; i < num; i++)
            {
                numArr[i] = Convert.ToInt32(Console.ReadLine()); 
            }
            for (int j = 0; j < num; j++)
            {
                if(numArr[j] % 2 == 0)
                {
                    sumOfEven += numArr[j];
                }
                else
                {
                    sumOfOdd += numArr[j];

                }
            }
            Console.WriteLine("Sum of given Odd Numbers is {0}",sumOfOdd);
            Console.WriteLine("Sum of given Even Numbers is {0}", sumOfEven);
        }
    }
}
