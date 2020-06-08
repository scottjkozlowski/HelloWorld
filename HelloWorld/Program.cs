using System;

namespace HelloWorld
{
    public class Program
    {
        

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");
            string part1 = "the ultimate question";
            string part2 = "of something";
            int theAnswer = 42;

            part2 = "of life, the universe, and everything";

            string questionText = "What is the answer to " + part1 + ", " + part2 + "?";
            string answerText = "The answer to " + part1 + ", " +
                part2 + ", is: " + theAnswer;

            Console.WriteLine(questionText);
            Console.WriteLine(answerText);

            int anotherValue = 123;
            int someValue = 101;
            if (someValue > 100)
            {
                int anotherValueLocal = someValue - 100 + anotherValue;  // Compiler error
                Console.WriteLine(anotherValueLocal);
            }

            double a = 1, b = 2.5, c = -3;
            double x = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            Console.WriteLine(x);

#pragma warning disable CS0219
            byte ss = (byte)1;
            int aa = (int)1;
            int ab = (int)2_147_483_645;
            int ac = checked(aa + ab);
            Console.WriteLine(ss);

            string name = "Bob";
            string age = "34";
            string message = $"{name} is {age} years old";
            Console.WriteLine(message);
        }
    }
}
