﻿using System;

namespace Problem6.PlanckConstant
{
    public class Calculation
    {
        public const double planck= 6.62606896e-34;
        public const double pi = 3.14159;

        public static double ReducePlanck()
        {
            double reducedPlanck = planck/(2*pi);
            return reducedPlanck;
        }
    }
    public class PlanckConstant
    {
        public static void Main()
        {
            Console.WriteLine(Calculation.ReducePlanck());
        }
    }
}
