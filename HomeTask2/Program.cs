﻿using System;

namespace HomeTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            static void PrintString(string st)
            {
                Console.WriteLine(st);
            }

            //for (int i = 0; i < length; i++)
            //{
                
            //    for (int j = 0; j < length; j++)
            //    {
            //        Index = Random(0, cards.length - j);
            //        temp[j] = cards[index];
            //        temp = cards[cards.length - j];
            //        cards[cards.length - j] = cards[index];
            //        cards[]
            //    }
            }
            byte byteNumber1 = 10, byteNumber2 = 10, maxByteNumber = 255, minByteNumber = 0;
            byteNumber1 = (byte)(byteNumber1 + byteNumber2);               
            
            
            Console.WriteLine("Особенности арифметических операций для целых чисел");

            int maxIntNumber = 2147483647, minIntNumber = -2147483648, resultAddition = maxIntNumber + 10;
            bool resultCompare = maxIntNumber > resultAddition;
            Console.WriteLine($"(2147483647) > (2147483647+10): {resultCompare}");
            Console.WriteLine($"(2147483647)(2147483647) + 10 = {resultAddition}");

            int resultSubtraction = minIntNumber - 10; 
            resultCompare = minIntNumber < resultSubtraction;
            Console.WriteLine($"(-2147483648) > (-2147483648-10): {resultCompare}");
            Console.WriteLine($"(-2147483648) - 10 = {resultSubtraction}");


            int resultMultiplication = maxIntNumber * 2;
            resultCompare = maxIntNumber > resultMultiplication;
            Console.WriteLine($"(2147483647) > (2147483647*2): {resultCompare}");
            Console.WriteLine($"(2147483647) * 2 = {resultMultiplication}");

            Console.WriteLine("Особенности арифметических операций для вещественных чисел");

            float floatNumber = 0.1F + 0.2F;
            decimal decimalNumber = 0.1M + 0.2M;
            double doubleNumber = 0.1 + 0.2;

            Console.WriteLine($"Тип double: 0.1 + 0.2 = {doubleNumber}");
            Console.WriteLine($"Тип float: 0.1 + 0.2 = {floatNumber}");
            Console.WriteLine($"Тип decimal: 0.1 + 0.2 = {decimalNumber}");

        
            Console.ReadKey();

        }
    }
}
