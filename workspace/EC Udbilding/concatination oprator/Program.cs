using System;

namespace concatination_oprator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string repeating = new string('.', 15);
            Console.WriteLine(repeating);
            //Console.Clear();
            //Concatenation Operator
            string start = "This is a ";
            string end = "concatenated string!";
            string concat = start + end;
            Console.WriteLine(concat);
            string repeating2 = new string('*', 20);
            Console.WriteLine(repeating2);

            Console.WriteLine("what is String 1 to compare.");
            string s1 = Console.ReadLine();
            Console.WriteLine("what is String 2 to compare.");
            string s2 = Console.ReadLine();
            //Console.WriteLine("what is String 3 to compare.");
            bool result = s1 == s2;                  // result = true
            Console.WriteLine("if we compare both the result is:");
            Console.WriteLine(result);
            /*
            string s3 = Console.ReadLine()
            string s3 = "String to Compare.";   // Note the capital "C"
            bool result;
            result = s1 == s2;                  // result = true
            Console.WriteLine(result);
            result = s1 == s3;                  // result = false */
            bool result2 = s1 != s2;             // result = false
            Console.WriteLine("if we compare not equal of a and b:");
            Console.WriteLine(result2);
            //result = s1 != s3;                  // result = true
        }
    }
}
