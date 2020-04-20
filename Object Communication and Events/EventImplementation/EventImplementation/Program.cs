﻿using System;

namespace EventImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Dispatcher dispatcher = new Dispatcher();
            Handler handler = new Handler();
            dispatcher.NameChange += handler.OnDispatcherNameChange;

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                dispatcher.Name = input;
            }
        }
    }
}
