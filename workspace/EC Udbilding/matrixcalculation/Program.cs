using System;
using System.Collections.Generic;
using System.Threading;
using static System.Console;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] matrix = new bool[0, 0];
            bool isFalse = false;// use this for D7
            while(true)
            while (!isFalse)// we use this for D7 case.
            {


                WriteLine("1. Create battery grid");
                WriteLine("2. Purge battery grid");
                WriteLine("3. Install human");
                WriteLine("4. Discard human");
                WriteLine("5. Print battery grid ");
                WriteLine("6. Calculate energy output");
                WriteLine("7. Exit");

                ConsoleKeyInfo input = ReadKey(true);
                Clear();
                switch (input.Key)

                {
                    case ConsoleKey.D1:
                        SetCursorPosition(2, 1);
                        Write("Name: ");
                        SetCursorPosition(2, 3);
                        Write("Width: ");
                        SetCursorPosition(2, 5);
                        Write("Height: ");
                        SetCursorPosition("Name: ".Length + 2, 1);
                        String Name = ReadLine();
                        SetCursorPosition("Width: ".Length + 2, 3);
                        ushort width = ushort.Parse(ReadLine());
                        SetCursorPosition("Hight: ".Length + 2, 5);
                        ushort hight = ushort.Parse(ReadLine());
                        matrix = new bool[width, hight];
                        Clear();
                        break;
                    case ConsoleKey.D2:
                            matrix = new bool[0, 0];
                            Thread.Sleep(2000);
                            Write(" grid purge successfully");
                            ReadLine();
                            Clear();
                            break;
                    case ConsoleKey.D3:
                        SetCursorPosition(2, 1);
                        Write("Row: ");
                        SetCursorPosition(2, 3);
                        Write("Colum: ");
                        SetCursorPosition("row: ".Length + 2, 1);
                        ushort row = ushort.Parse(ReadLine());
                        row -= 1;
                        SetCursorPosition("colum: ".Length + 2, 3);
                        ushort colum = ushort.Parse(ReadLine());
                        colum -= 1;
                        Clear();
                        if (matrix[row,colum])
                        {
                            Write("Already occupied");
                        }
                        else
                        {
                            matrix[row, colum] = true;
                            Write("Successfully installed human");
                        }
                        Thread.Sleep(2000); // 2 sec
                        Clear();

                        break;
                   case ConsoleKey.D4:
                        SetCursorPosition(2, 1);
                        Write("Rowws: ");
                        SetCursorPosition(2, 3);
                        Write("Columns: ");
                        SetCursorPosition("rowws: ".Length + 2, 1);
                        ushort rowws = ushort.Parse(ReadLine());
                        rowws -= 1;
                        SetCursorPosition("columns: ".Length + 2, 3);
                        ushort columns = ushort.Parse(ReadLine());
                        columns -= 1;
                        Clear();
                        if (matrix[rowws, columns])

                        {
                            matrix[rowws, columns] = false;
                            Write("grind sussesfully deleated");
                        }
                        else
                            {
                                Write("Place vaccent");
                            }

                        
                        Thread.Sleep(2000);
                        Clear();

                        break;

                   case ConsoleKey.D5:

                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                if (matrix [i,j])
                                {
                                    Write("|X|");
                                }
                                else
                                {
                                    Write("| |");
                                }
                            }
                                    WriteLine("\n");
                                }                         
                        ReadKey();
                          Clear();
                            break;
                     case ConsoleKey.D6:
                            int human = 0;
                            int watt = 0;

                            foreach(bool humans in matrix)  // we use bool function to check    T/F value.
                            {
                                if (humans)
                                {
                                    human++;
                                    watt = human * 100;
                                }
                            }
                            Write("human"+human);
                            Write("watt"+watt);
                            Thread.Sleep(2000);
                                    Clear();
                            break ;

                     case ConsoleKey.D7:
                        {
                            isFalse = true;
                            break;
                        }
                            }
                            
                        }
                }
            }
        }
    



