﻿using System;
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
       

        public static int DifferenceInt(int a , int b)
        {
            return a < b ? (b - a) : (a - b);
        }
       
    }
}
