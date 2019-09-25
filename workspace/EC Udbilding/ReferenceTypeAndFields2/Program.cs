using System;
using System.Collections.Generic;
using System.Threading;
using static System.Console;

namespace ReferenceTypeAndFields2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] shelf = new string[0, 0];
            Name name = new Name();
            int availableSlots = 0;
            bool isFalse = false;
            while (!isFalse)
            {
                WriteLine("1. Create Shelf ");
                WriteLine("2. Print Shelf ");
                WriteLine("3. Place Package ");
                WriteLine("4. Fetch Package ");
                WriteLine("5. Exit");
                ConsoleKeyInfo input = ReadKey(true);
                Clear();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        {
                            SetCursorPosition(2, 1);
                            Write("Shelf_Name: ");
                            SetCursorPosition(2, 3);
                            Write(" Num of Rows: ");
                            SetCursorPosition(2, 5);
                            Write("Num of Columns: ");
                            SetCursorPosition("Shelf_Name: ".Length + 2, 1);
                            name.theName = ReadLine();
                            SetCursorPosition("Num of Rows: ".Length + 2, 3);
                            ushort srows = ushort.Parse(ReadLine());
                            SetCursorPosition("Num of Columns: ".Length + 2, 5);
                            ushort scolumn = ushort.Parse(ReadLine());
                            shelf = new string [srows, scolumn];
                            Write(" shelf successfully created ");
                            ReadLine();
                            Clear();
                            break;
                        }
                    case ConsoleKey.D2:
                        for (int i = 0; i < shelf.GetLength(0); i++)
                        {
                            for (int j = 0; j < shelf.GetLength(1); j++)
                            {
                                if (shelf[i, j] != null)
                                {
                                    Write("|X|");
                                }
                                else
                                {
                                    Write("| |");
                                    availableSlots++;
                                }
                            }
                           WriteLine("\n");
                        }
                        
                        WriteLine("shelf name:" + name.theName);
                        WriteLine("available slots:" + availableSlots);
                        availableSlots = 0;
                        WriteLine("press Esc to continue ");
                        WriteLine("\n");
                        ReadKey();
                        Clear();
                        break;
                    case ConsoleKey.D3:
                        {
                        SetCursorPosition(2, 1);
                        WriteLine("Row: ");
                        SetCursorPosition(2, 3);
                        WriteLine("Colum: ");
                        SetCursorPosition(2, 5);
                        WriteLine("content:  ");
                        SetCursorPosition("row: ".Length + 2, 1);
                        ushort row = ushort.Parse(ReadLine());
                        row -= 1;
                        SetCursorPosition("colum:  ".Length + 2, 3);
                        ushort colum = ushort.Parse(ReadLine());
                        colum -= 1;
                        SetCursorPosition("content: ".Length + 2, 5);
                        string content = ReadLine();
                        WriteLine("\n");
                        Clear();
                        if (shelf[row, colum] != null)
                        {
                        WriteLine("slot Already occupied");
                        }
                        else
                        {
                        shelf[row, colum]= content;
                        WriteLine(" slot Successfully installed ");
                        }
                        Thread.Sleep(2000); // 2 sec
                        Clear();
                        break;
                        }
                    case ConsoleKey.D4:
                        {
                            SetCursorPosition(2, 1);
                            WriteLine("rows:");
                            SetCursorPosition(2, 3);
                            WriteLine("Columns:");
                            SetCursorPosition("rows1: ".Length + 2, 1);
                            ushort rows1 = ushort.Parse(ReadLine());
                            rows1 -= 1;
                            SetCursorPosition("columns1: ".Length + 2, 3);
                            ushort columns1 = ushort.Parse(ReadLine());
                            columns1 -= 1;
                            if (shelf[rows1, columns1] != null)
                            {
                            WriteLine(" content :" + shelf[rows1, columns1]);
                            WriteLine(" package retrived successfully");
                            }
                            else
                            {
                            WriteLine(" slot empty ");  
                            }
                            Thread.Sleep(2000);
                            Clear();
                            break;
                        }

                    case ConsoleKey.D5:
                        isFalse = true;
                        break;
                }
            }
        }
    }
    class Name
    {
        public string theName;
}
}

    

    

