using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace k173669_Lab1_Q4
{
    class Calculator
    {
        /// <summary>
        /// Returns sum of all arg values
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static double Add(params double[] args)
        {
            {
                double sum = 0;
                foreach (double arg in args)
                {
                    sum += arg;
                }
                return sum;
            }
        }

        /// <summary>
        /// Returns the difference of the first arg value with the rest.
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static double Subtract(params double[] args)
        {
            {
                double difference = args[0] * 2;
                double sum = 0;
                foreach (double arg in args)
                {
                    sum += arg;
                }

                return difference - sum;
            }
        }

        /// <summary>
        /// Returns the product of all given arg values.
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static double Multiply(params double[] args)
        {
            {
                double product = 1;
                foreach (double arg in args)
                {
                    product *= arg;
                }
                return product;
            }
        }

        /// <summary>
        /// Returns the result of dividing the first arg value with the rest.s
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static double Divide(params double[] args)
        {
            {

                if (args[0] == 0 || args.Length < 2) return args[0];

                double uparWala = args[0]*args[0];

                double nicheWala = 1;
                foreach (double arg in args)
                {
                    if (arg == 0) throw new ApplicationException("Division by zero.");
                    nicheWala *= arg;
                }
                return uparWala/nicheWala;
            }
        }



    }
}
