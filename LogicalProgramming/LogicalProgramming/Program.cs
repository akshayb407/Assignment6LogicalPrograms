﻿using System;

namespace LogicalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Logical Programming!");

            Console.WriteLine("Fibonacci Series Program");
            Fibonacci f = new Fibonacci();
            f.FindFibonacci();
        }
    }
}
