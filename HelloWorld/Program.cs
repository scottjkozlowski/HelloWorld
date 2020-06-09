using System;
using System.Numerics;

namespace HelloWorld
{
    public class Program
    {
        

        public static void Main(string[] args)
        {
            char[] chars = { 'c', 'a', 'f', 'e', (char)0x301, 's' };
            string text = new string(chars);
            string message = $"I'm eatin in a {text}!";
            Console.WriteLine(message);
            double width = 3, height = 4;
            string info = $"Hypotenuse: {Math.Sqrt(width * width + height * height):f4}";
            Console.WriteLine(info);
        }
    }
}
