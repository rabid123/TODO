using System;
using System.Collections.Generic;
using System.Threading;
using static System.Console;

namespace sunfleet
{
    class Program
    {

        static void Main(string[] args)
        {
            bool shouldNotExit = true;
            Car[] cars = new Car[100];
            int carCounter = 0;
            while (shouldNotExit)
            {
                Clear();
                WriteLine("1. Add car ");
                WriteLine("2. List cars");
                WriteLine("3. Charge cars");
                WriteLine("4. Exit");
                ConsoleKeyInfo input = ReadKey(true);
                Clear();
                switch (input.Key)
                {

                    case ConsoleKey.D1:
                        SetCursorPosition(2, 1);
                        Write("Registration Number: ");
                        SetCursorPosition(2, 3);
                        Write("Brand: ");
                        SetCursorPosition(2, 5);
                        Write("Model: ");
                        SetCursorPosition(2, 7);
                        Write("Car type: ");
                        SetCursorPosition("Registration Number: ".Length + 2, 1);
                        String regnum = ReadLine();
                        SetCursorPosition("Brand: ".Length + 2, 3);
                        String brand = ReadLine();
                        SetCursorPosition("Model: ".Length + 2, 5);
                        String model = ReadLine();
                        SetCursorPosition(" Car type: ".Length + 2, 7);
                        String ctype = ReadLine();
                   
                        cars[carCounter++] = new Car();
                        ReadLine();
                        Clear();
                        Write("car added");
                        Thread.Sleep(2000);                   
                        break;
                    case ConsoleKey.D2:
                        { 
                        SetCursorPosition(2, 1);
                        WriteLine("Registration number        type          ischarged:");
                        SetCursorPosition(2, 3);
                        WriteLine(".................................");
                        foreach (var thecar in cars)
                        {
                     if (thecar == null) continue;
                            Write(thecar.regnum);
                            Write(thecar.ctype);
                            if (thecar.isCharged)
                            {
                                Write("Yes");
                            }
                            else
                            {
                                Write("No");
                            }
                            WriteLine();
                        }
                            WriteLine("<Press any key to continue");
                            ReadKey();
                }
                        Thread.Sleep(2000);
                        Clear();
                        break;
                }
            }
        }
    }
    class Car
    {
        public string regnum;
        public string brand;
        public string model;
        public string ctype;
        public bool isCharged;
        //public Car(string regnum, string brand, string model, string ctype);



    }
}





    

