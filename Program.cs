using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace secant_metode
{
   
        // C# Program to find root of an
// equations using secant method
using System;
 
class GFG
    {

        // function takes value of
        // x and returns f(x)
        static float f(float x)
        {

            // we are taking equation
            // as x^3+x-1
            float f = (float)Math.Pow(x, 3)
                                    + x - 1;
            return f;
        }

        static void secant(float x1, float x2,
                        float E)

        {

            float n = 0, xm, x0, c;
            if (f(x1) * f(x2) < 0)
            {
                do
                {

                    // calculate the intermediate
                    // value
                    x0 = (x1 * f(x2) - x2 * f(x1))
                        / (f(x2) - f(x1));

                    // check if x0 is root of
                    // equation or not
                    c = f(x1) * f(x0);

                    // update the value of interval
                    x1 = x2;
                    x2 = x0;

                    // update number of iteration
                    n++;

                    // if x0 is the root of equation
                    // then break the loop
                    if (c == 0)
                        break;
                    xm = (x1 * f(x2) - x2 * f(x1))
                        / (f(x2) - f(x1));

                    // repeat the loop until
                    // the convergence
                } while (Math.Abs(xm - x0) >= E);

                Console.WriteLine("Root of the" +
                        " given equation=" + x0);

                Console.WriteLine("No. of " +
                                  "iterations = " + n);
            }

            else
                Console.WriteLine("Can not find a" +
                                  " root in the given interval");
        }

        // Driver code
        public static void Main(String[] args)
        {

            // initializing the values
            float x1 = -1, x2 = 0, E = 0.0001f;
            secant(x1, x2, E);
            Console.ReadKey();
        }
        
    }
    
    // This code is contributed by vt_m.
}



