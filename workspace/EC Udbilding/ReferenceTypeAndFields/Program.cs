using System;
using System.Threading;
using static System.Console;

namespace ReferenceTypeAndFields
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Clear();

                WriteLine("1.Register Patient");
                WriteLine("2. List Patients");

                ConsoleKeyInfo keypressed = ReadKey();

                Clear();


                switch (keypressed.Key)
                {
                    case ConsoleKey.D1:
                        String[] patient = new string[3]; // skappa en string av Array.

                        Write("First name");
                        
                        patient[0] = ReadLine();
                        Write("last name");
                       
                        patient[1] = ReadLine();
                        Write("ssn");
                        
                        patient[2] = ReadLine();

                        foreach (var attribute in patient)
                        {
                            WriteLine(attribute);
                        }                 

                        //Thread.Sleep(8000); // 2 sec
                        break;
                }
            }
        }
    }
}
