using System;


class Program
{
    static void Main()
    {
        /*
         Кои от следните стойности може да се присвоят на променливи от тип 
         float, double и decimal: 34.567839023; 12.345; 8923.1234857; 3456.091124875956542151256683467 ?
         */
        double number1 = 34.567839023;
        float number2 = 12.345f;
        double number3 = 8923.1234857;
        decimal number4 = 3456.091124875956542151256683467m;

        Console.WriteLine(number1 + " double ");
        Console.WriteLine(number2 + " float ");
        Console.WriteLine(number3 + " double ");
        Console.WriteLine(number4 + " decimal ");

    }
}

