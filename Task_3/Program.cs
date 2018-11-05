using System;


class Program
{
    static void Main()
    {
        // Напишете програма, която сравнява вярно две реални числа с точност до 0.000001.

        decimal number1 = 2.34759837463m;
        decimal number2 = 6.2310976532m;
        number1 += number2;
        Console.WriteLine(number1.ToString("#.######"));
    }
}

