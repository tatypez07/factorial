using System;
using System.Collections.Generic;
using System.Text;

namespace TipFactorial.Core.Services
{
    public class FactorialService : IFactorialService
    {
        public double TipFactorial(double numero)
        {
          
            int i = 2;
            double fac= 1;
            while ( i <= numero)
            {
                fac *= i;
                i++;
            }

            return fac;
        }
    }
}
