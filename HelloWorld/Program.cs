﻿using System;
using System.Numerics;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int someValue = 101;
            if (someValue > 100)
            {
                int anotherValue = someValue - 100; //Compiler error
                Console.WriteLine(anotherValue);
            }
            MyClass a = new MyClass();
            a.Show();
            string AString = Console.ReadKey().KeyChar + "!";
            Console.WriteLine(Environment.NewLine + AString);
            //int anotherValue = 123;
        }
    }
}
