﻿using System;


class Program
{
    static void Main()
    {
        /* 
        Декларирайте променлива от тип char и присвоете като стойност символа, който има Unicode код 72
        (използвайте калкулатора на Windows, за да намерите шестнайсетичното представяне на 72).
        */

        char num = '\u0048';

        // Шестнайсетичното представяне на 72 = \u0048  e символа H 

        Console.WriteLine(num);
    }
}
