﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Calculator
    {
        public static double Add(double v1, double v2)
        {
            double resultat = 0;
            resultat = v1 + v2;
            return resultat;
        }
        public static double Subtract(double v1, double v2)
        {
            double resultat = 0;
            resultat = v1 - v2;
            return resultat;
        }
        public static double Average(double[] numbers)
        {
            double average = 0;
            for (int i = 0; i < numbers.Length; i++)
            {

                average = average + numbers[i] / numbers.Length;

            }
            return average;

        }

        public static double Minimum(double[] numbers)
        {
            int min = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[min])
                {
                    min = i;
                }
            }

            return numbers[min];

        }

        public static double Maximum(double[] numbers)
        {
            int max = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[max])
                {
                    max = i;
                }
            }

            return numbers[max];
        }
        public static double Sum(double[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {

                sum = sum + numbers[i];

            }
            return sum;

        }
        public static double Divide(double v, double v1)
        {
            double divided = 0;
            divided = v / v1;
            return divided;
        }

        public static double Multiply(double v, double v1)
        {
            double multiply = 0;
            multiply = v * v1;
            return multiply;
        }
 
    }
}
