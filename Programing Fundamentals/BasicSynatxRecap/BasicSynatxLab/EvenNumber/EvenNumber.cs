﻿using System;

namespace EvenNumber
{
    internal class EvenNumber
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int number = int.Parse(Console.ReadLine());
                if(number % 2==0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(number)}");
                    return;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }
            }
        }
    }
}