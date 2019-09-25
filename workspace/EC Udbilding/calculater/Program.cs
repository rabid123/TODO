using System;
using System.Threading;

namespace calculater
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
               
           

            {


                string start = "Enter ur required commonds";  // required commonds i.e Addition,sub div,mul,mod

                Console.WriteLine("1. Addition:");
                Console.WriteLine("2. substraction:");
                Console.WriteLine("3. multiplication:");
                Console.WriteLine("4. Division:");
                Console.WriteLine("5. Modulus:");
                start = Console.ReadLine();
                Console.Clear();

                Console.Write("Enter first value :");
                int i = int.Parse(Console.ReadLine());
                Console.Write("Enter second value:");
                int j = int.Parse(Console.ReadLine());
                int result = i + j;
                Console.WriteLine("enter multipal opration +,-,*,/");
                char op = char.Parse(Console.ReadLine());
                switch (op)
                {
                    case '+':
                        result = i + j;
                        break;
                    case '-':
                        result = i - j;
                        break;
                    case '*':
                        result = i * j;
                        break;
                    case '/':
                        result = i / j;
                        break;
                    case '%':
                        result = i % j;
                        break;

                }
                Console.Write("resultat: {0}\n", result);
                Console.ReadLine();
                Thread.Sleep(8000); // 2 sec
                break;
            }
        }
    }
}

