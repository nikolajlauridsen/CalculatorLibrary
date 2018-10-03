 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Calculator
    {
        public static int Sum(int[] ints)
        {
            int sum = 0;
            for (int l = 0; l < ints.Length; l++)
            {

                sum = sum + ints[l];

            }
            return sum;

        }

        public static int Min(int[] ints)
        {
            int min = 0;
            for (int j = 0; j < ints.Length; j++)
            {
                if (ints[j] < ints[min])
                {
                    min = j;
                }
            }

            return ints[min];

        }

        public static int Max(int[] ints)
        {
            int max = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] > ints[max])
                {
                    max = i;
                }



            }

            return ints[max];
        }
    }
}
