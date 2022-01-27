using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class SumMethod : ISuminterface
    {
        
       public int Sum(int a,int b)
        {
            int Sum;
            Sum = a + b;
            return Sum;
        }

       public float Sum(float a, float b)
        {
            float Sum;
            Sum = a + b;
            return Sum;
        }
       public double Sum(double a, double b)
        {
            double Sum;
            Sum = a + b;
            return Sum;
        }

    }
}
