using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    static class CalcoliHelper
    {
       
        public static int SumInt(int a, int b) => a + b;
        
        public static double SumDouble(double a, double b) => (double)a + (double)b;
       
        public static int DifferenceInt(int a , int b) => a < b ? (b - a) : (a - b);
       
        public static double DifferenceDouble(double a, double b) => a < b ? (b - a) : (a - b);  

        public static int MoltiplicationInt(int a, int b) => a * b;

        public static double MoltiplicationDouble(double a, double b) => a * b;

        public static int AbsoluteValueInt(int number) => number < 0 ? -number : number;

        public static double AbsoluteValueDouble(double number) => number < 0 ? -number : number;

        public static int MinInt(int a, int b) => a < b ? a : b;

        public static double MinDouble(double a, double b) => a < b ? a : b;

        public static int MaxInt(int a, int b) => a > b ? a : b;

        public static double MaxDouble(double a, double b) => a > b ? a : b;

        // BONUS
        public static double Power(double a, double b)
        {
            double result = 1;

            for (int i = 0; i< b; i++)
            {
                result *= a;
            }

            if(b < 0 )
            {
                b = -b;
                for(int i = 0; i < b; i++)
                {
                    result /= (a * b);
                }
            }

            return b >= 0 ? result : 1 / result;
        }
    }
}
