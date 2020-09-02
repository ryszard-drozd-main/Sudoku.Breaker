﻿using Sudoku.Model.Dto;
using Sudoku.Model.Impl.Services;
using System;
using System.Text;

namespace Sudoku.Breaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Initialie();
            new Program().Run(args);
            Console.WriteLine();
            Console.WriteLine("press any key");
            Console.ReadKey();
        }

        private static void Initialie()
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        }
        const string sudoku00 = "";
        const string sudoku01 = "0,0=7 0,2=1 0,5=6 0,7=9 " +
                                "1,4=1 1,8=2 " +
                                "2,1=9 2,7=7 " +
                                "3,0=3 3,2=8 3,3=5 3,4=6 3,5=4 3,8=9 " +
                                "4,6=8 " +
                                "5,0=5 5,1=2 5,5=7 5,7=3 5,8=1 " +
                                "6,2=5 6,3=1 6,8=7 " +
                                "7,0=2 7,1=3 7,4=7 7,8=5 " +
                                "8,0=1 8,3=3 8,7=8"; // rozwiązanie po 51 krokach
        const string sudoku02 = "0,6=9 0,8=6 " +
                                "1,0=9 1,2=4 1,4=3 1,5=7 " +
                                "2,0=8 2,1=1 2,3=2 2,4=6 " +
                                "3,0=1 3,3=3 3,4=2 3,6=7 " +
                                "4,0=5 4,2=3 4,3=1 4,4=7 " +
                                "5,1=7 5,2=8 5,3=4 5,8=2 " +
                                "6,0=2 6,4=8 6,6=1 6,7=9 " +
                                "7,1=9 7,5=2 7,6=8 7,7=3 " +
                                "8,4=4 8,5=1";
        const string sudoku03 = "0,0=7 0,2=1 0,5=6 0,7=9 " +
                                "1,4=1 1,8=2 " +
                                "2,1=9 2,2=7 2,7=7 " +
                                "3,0=3 3,2=8 3,3=5 3,4=6 3,5=4 3,8=9 " +
                                "4,6=8 " +
                                "5,0=5 5,1=2 5,5=7 5,7=3 5,8=1 " +
                                "6,2=5 6,3=1 6,8=7 " +
                                "7,0=2 7,1=3 7,4=7 7,8=5 " +
                                "8,0=1 8,3=3 8,7=8"; // 7 wystepuje w (0,0) i (2,2)
        const string sudoku04 = "0,0=7 0,2=1 0,5=6 0,7=9 " +
                                "1,4=1 1,8=2 " +
                                "2,1=9 2,7=7 " +
                                "3,0=3 3,2=8 3,3=5 3,4=6 3,5=4 3,8=9 " +
                                "4,6=8 " +
                                "5,0=5 5,1=2 5,5=7 5,7=3 5,8=1 " +
                                "6,0=7 6,2=5 6,3=1 6,8=7 " +
                                "7,0=2 7,1=3 7,4=7 7,8=5 " +
                                "8,0=1 8,3=3 8,7=8"; // 7 wystepuje w (0,0) i (6,2)
        const string sudoku05 = "0,0=7 0,2=1 0,5=6 0,7=9 0,8=7 " +
                                "1,4=1 1,8=2 " +
                                "2,1=9 2,7=7 " +
                                "3,0=3 3,2=8 3,3=5 3,4=6 3,5=4 3,8=9 " +
                                "4,6=8 " +
                                "5,0=5 5,1=2 5,5=7 5,7=3 5,8=1 " +
                                "6,2=5 6,3=1 6,8=7 " +
                                "7,0=2 7,1=3 7,4=7 7,8=5 " +
                                "8,0=1 8,3=3 8,7=8"; // 7 wystepuje w (0,0) i (0,8)
        private void Run(string[] args)
        {
            var accessor = new SquareAccessor();
            var fieldRefresh = new SquareRefresh(accessor);
            var promote = new SquarePromote();
            var square = new SquareFactory(accessor, fieldRefresh).FromString(sudoku03);
            var validator = new SquareValidator(accessor);
            Print(square);
            var vr = validator.Validate(square);
            if (!vr.Ok)
            {
                Console.WriteLine();
                Console.WriteLine($"{vr.Conflict.RealValue} występuje w ({vr.Conflict.FirstRow},{vr.Conflict.FirstCol}) i ({vr.Conflict.SecondRow},{vr.Conflict.SecondCol})");
            }
            else
            {
                int promotes = 0;
                while (promote.Promote(square))
                {
                    promotes++;
                    Console.WriteLine($"-- krok {promotes} --");
                    fieldRefresh.Refresh(square);
                    Print(square);
                }
                Console.WriteLine($"Rozwiązane po {promotes} krokach");
            }
        }

        private string Print(IField fld)
        {
            var builder = new StringBuilder();
            builder.Append("[");
            for(int i = 1; i <= 9; i++)
                if(fld.CouldBe[i])
                    builder.Append(i);
            builder.Append("]");
            return builder.ToString();
        }
        private void Print(IBoard square)
        {
            var chars = new string[] { ".","1","2","3","4","5","6","7","8","9"};
            var accessor = new SquareAccessor();
            for (int w = 0; w < 9; w++)
            {
                for (int k = 0; k < 9; k++)
                {
                    var fld = accessor.GetField(square, w, k);
                    var v = fld.RealValue;
                    string c = v == EmptyField.Empty ? Print(fld) : chars[v];
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var ex = e.ExceptionObject as Exception;
            Console.WriteLine(ex.Message);
            Console.WriteLine();
            Console.WriteLine(ex.StackTrace);
        }
    }
}
