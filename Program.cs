using System;

namespace Lab3_A_та_П
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task 1");
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter m: ");
            int m = int.Parse(Console.ReadLine());
            int sum = 0;

            if (n >= m)
            {
                Console.WriteLine("Error: n must be less than m.");
                return;
            }

            
            Console.WriteLine("Numbers, multiples of 4, between n and m:");
            for (int i = n; i <= m; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }
            Console.WriteLine($"The sum of numbers that are multiples of 4: {sum}"); ;
            Console.ReadKey();


            Console.WriteLine("task 2");
            double x = 2.05;
            double epsilon = Math.Pow(10, -3);
            double term;
            double sumS1 = 0;
            int b = 1;
            double factorial = 1;

            do
            {
                term = Math.Pow(x, b) / factorial;
                sumS1 += term;

                Console.WriteLine($"Iteration: {b}");
                Console.WriteLine($"Current term (a_b): {term}");
                Console.WriteLine($"Accumulated sum S1: {sumS1}");
                Console.WriteLine($"Error at this iteration: {Math.Abs(term / sumS1)}");

                b++;
                factorial *= b;

            } while (term > epsilon);
            Console.WriteLine($"Final sum S1: {sumS1}");
            Console.WriteLine($"Number of iterations: {b - 1}");
            Console.ReadKey();






            Console.WriteLine("task 3");
            double a = -1;  
            double c = 1;   
            double h = 0.05;  

            Console.WriteLine("k=a,y = e^(3*(x - 0.6)),z = arcsin(x)");

            for (double k = a; k <= c; k += h)
            {
               
                double y = Math.Exp(3 * (k - 0.6));
                double z = Math.Asin(k);

                Console.WriteLine($"k={k},y={y},z= {z}");
                Console.ReadKey();
            }


        }
    }
}
