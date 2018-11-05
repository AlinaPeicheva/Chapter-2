using System;


class Program
{
    static void Main()
    {
        //Декларирайте две променливи от тип int. Задайте им стойности съответно 5 и 10.Разменете стойностите им и ги отпечатайте.

        int a = 5;
        int b = 10;
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("a:{0} b:{1}", a, b);
    }
}

