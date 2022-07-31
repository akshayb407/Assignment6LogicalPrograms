using System;

namespace LogicalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Logical Programming!");

            //.Console.WriteLine("Fibonacci Series Program");
            //Fibonacci f = new Fibonacci();
            //f.FindFibonacci();

            //Console.WriteLine("Perfect Number Program!");
            //PerfectNumber pf = new PerfectNumber();
            //pf.perfectNumber();

            //Console.WriteLine("Prime Number Program!");
            //PrimeNumber pn = new PrimeNumber();
            //pn.primeNumber();

            Console.WriteLine("Reverse Number Program!");
            ReverseNumber rn = new ReverseNumber();
            rn.Reverse();


        }
    }
}
