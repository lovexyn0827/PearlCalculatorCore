﻿using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PearlCalculatorLib.CalculationLib
{
    public static class MathHelper
    {
        public static float Sqrt(double value)
        {
            return (float)Math.Sqrt(value);
        }

        public static double DegreeToRadiant(double degree)
        {
            return degree * Math.PI / 180;
        }

        public static double RadiantToDegree(double radiant)
        {
            return radiant * 180 / Math.PI;
        }

        public static bool IsInside(double border1 , double border2 , double num)
        {
            return num <= GetBigger(border1 , border2) && num >= GetSmaller(border1 , border2);
        }

        public static double GetBigger(double num1 , double num2)
        {
            return num1 > num2 ? num1 : num2;
        }

        public static double GetSmaller(double num1 , double num2)
        {
            return num1 < num2 ? num1 : num2;
        }
    }
}
