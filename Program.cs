using System;
using System.Collections.Generic;

namespace Assignment1
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello World");
            int a = 15, b = 25;
            printPrimeNumbers(a, b);

            int n1 = 5;
            Console.WriteLine("The sum of the series is: " + roundUp(getSeriesResult(n1), 2));


            long n2 = 15;
            long r2 = decimalToBinary(n2);
            Console.WriteLine("Binary conversion of the decimal number " + n2 + " is: " + r2);


            long n3 = 1111;
            long r3 = binaryToDecimal(n3);
            Console.WriteLine("Decimal conversion of the binary number " + n3 + " is: " + r3);


            int n4 = 5;
            printTriangle(n4);

            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);

            // write your self-reflection here as a comment

        }

        public static void printPrimeNumbers(int x, int y)
        {
            try
            {
                int count = 0;
                List<int> primeList = new List<int>();
                for (int i = x; i <= y; i++)
                {
                    if (isPrime(i))
                    {
                        count++;
                        primeList.Add(i);
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine("There are no prime numbers between " + x + " and " + y + ".");
                }
                else
                {
                    Console.WriteLine("Prime numbers between " + x + " and " + y + " are: " + String.Join(", ", primeList));
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
        }

        public static Boolean isPrime(int n)
        {
            // Corner case 
            if (n <= 1)
                return false;

            // Check from 2 to n-1 
            for (int i = 2; i < n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }

        public static double getSeriesResult(int n)
        {
            try
            {
                if (n == 0)
                {
                    return 0;
                }
                double result = 0.0;
                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        result = result - (computeFactorial(i) / (double) (i + 1));
                    }
                    else
                    {
                        result = result + (computeFactorial(i) / (double) (i + 1));
                    }
                }
                return result;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }

            return 0;
        }

        public static int computeFactorial(int n)
        {
            // corner case for n = 0 which is 1.
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return (n * computeFactorial(n - 1));
            }
        }

        public static decimal roundUp(double input, int places)
        {
            decimal d = (decimal)input;
            return decimal.Round(d, places);
        }

        public static long decimalToBinary(long n)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing decimalToBinary()");
            }

            return 0;
        }

        public static long binaryToDecimal(long n)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing binaryToDecimal()");
            }

            return 0;
        }

        public static void printTriangle(int n)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static void computeFrequency(int[] a)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }
    }
}
