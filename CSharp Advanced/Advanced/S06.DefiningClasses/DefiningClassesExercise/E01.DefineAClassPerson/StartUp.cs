﻿using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person peter = new Person();
            peter.Name= "Peter";
            peter.Age = 20;

            Person george= new Person
            {
                Name= "George",
                Age = 18,
            };
        }
    }
}