using System;
using System.Numerics;

namespace HelloWorld
{
    public class Program
    {
        

        public static void Main(string[] args)
        {

            double width = 3, height = 4;
            string info = $"Hypotenuse: {Math.Sqrt(width * width + height * height):f4}";
            Console.WriteLine(info);
        }
    }
}
