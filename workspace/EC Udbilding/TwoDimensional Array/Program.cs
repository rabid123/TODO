using System;
using System.Threading;
using static System.Console;
namespace ReferenceTypeAndFields
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] patients = new string[100][];
            int patientCounter = 0;
            while (true)
            {
                Clear();
                WriteLine("1. Register patient");
                WriteLine("2. List patients");
                ConsoleKeyInfo keyPressed = ReadKey();
                Clear();
                switch (keyPressed.Key)
                {
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        string[] patient = new string[3];
                        Write("First name: ");
                        patient[0] = ReadLine();
                        Write("Last name: ");
                        patient[1] = ReadLine();
                        Write("Social security number: ");
                        patient[2] = ReadLine();
                        // Add patient data to array of patient data
                        patients[patientCounter] = patient;
                        ++patientCounter;
                        break;
                    case ConsoleKey.D2:
                        foreach (var patientAttributes in patients)
                        {
                            if (patientAttributes == null) continue;
                            string firstName = patientAttributes[0];
                            string lastName = patientAttributes[1];
                            string socialSecurityNumber = patientAttributes[2];
                            WriteLine($"{firstName} {lastName}, {socialSecurityNumber}");
                        }
                        Thread.Sleep(2000);
                        break;
                }
            }
        }
    }
}


               