using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    // Test only Method This Time
   public class Calculator
    {
        #region Method

        public int Sum(int a, int b)
        {
            int c = a + b;
            return c;
        }
        public int Sub(int a, int b)
        {
            int c = a - b;
            return c;
        }
        public int Mul(int a, int b)
        {
            int c = a * b;
            return c;
        }
        public int Div(int a, int b)
        {
            int c = 0;
            try
            {
                c = a / b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return c;
        }






        #endregion

    }
}
