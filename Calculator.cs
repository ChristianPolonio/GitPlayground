using System;
using System.Reflection;

namespace GitPlayground
{
    public class Calculator
    {
       public int Add(int a, int b)
       {
          return a + b;
       }

       public int Sub(int a, int b)
       {
          return a - b;
       }

       public int Mult(int a, int b)
       {
          return a * b;
       }

       public float Div(int a, int b)
       {

          return (float) b / a;
       }
    }
}
