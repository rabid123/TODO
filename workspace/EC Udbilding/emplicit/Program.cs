using System;

namespace emplicit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 3;
            int b = 7;
            int result;
            int clear;
            result = a + b;         // result = 10
            // Console.WriteLine("result of a and b: {0}" ,(result));
            Console.WriteLine(result);
           
            result = a - b;         // result = -4
            Console.WriteLine(result);
            result = a * b;  // result = 21
           Console.WriteLine(result);
            
            result = a / b;         // result = 0
            Console.WriteLine(result);
            result = a + b - 1;     // result = 9
            Console.WriteLine(result);

        }
    }
}
