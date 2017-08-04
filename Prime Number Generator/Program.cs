using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            input the start and endpoint on two lines when prompted.. 
            
            to display the statistics WITHOUT printing the actual array (for large arrays) include an 'n' on the end of your endpoint, e.g.
            
            10
            200n
            >>submit
            
            */

            bool arrayDisplay = true;
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            string b1 = Console.ReadLine();
            if (b1.EndsWith("n"))
            {
                arrayDisplay = false;
                b1 = b1.Replace("n", string.Empty);
            }
            int b = Convert.ToInt32(b1);

            int[] primes = new int[b - a];
            bool isPrime = false;
            int k = 0;

            for (int i = a; i <= b; i++)
            {
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    isPrime = true;
                }

                if (isPrime)
                {
                    primes[k] = i;
                    k++;
                }
            }
            int[] primesT = new int[k];
            for (int i = 0; i < k; i++)
            {
                primesT[i] = primes[i];
            }

            Console.WriteLine();
            double q = b / Math.Log(b);
            double z = Convert.ToDouble(k) / (b - a);

            Console.WriteLine("Prime density: " + z.ToString());
            Console.WriteLine("Prime # span: " + (b - a).ToString());
            Console.WriteLine("# of primes: " + k.ToString());
            Console.WriteLine("x / Log(x) = " + q.ToString());


            if (arrayDisplay)
            {
                for (int i = 0; i < primesT.Length; i++)
                {
                    Console.Write(primesT[i].ToString() + ", ");
                    if (i % 20 == 0)
                    {
                        Console.WriteLine();
                    }


                }
            }



        }
    }
}