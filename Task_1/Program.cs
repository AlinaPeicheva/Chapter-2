using System;



class Program
{
    static void Main()
    {
        /* 
        Декларирайте няколко променливи, като изберете за всяка една найподходящия
        от типовете sbyte, byte, short, ushort, int, uint, long и ulong, за да им присвоите следните стойности:
        52130, -115, 4825932, 97, -10000, 20000; 224; 970700000; 112; -44; -1000000; 1990; 123456789123456789.        */
        ushort number1 = 52130;
        sbyte number2 = -115;
        uint number3 = 4825932;
        byte number4 = 97;
        short number5 = -10000;
        short number6 = 20000;
        byte number7 = 224;
        uint number8 = 970700000;
        sbyte number9 = 112;
        sbyte number10 = -44;
        int number11 = -1000000;
        ushort number12 = 1990;
        long number13 = 123456789123456789;

        Console.WriteLine(number1 + " ushort ");
        Console.WriteLine(number2 + " sbyte ");
        Console.WriteLine(number3 + " uint ");
        Console.WriteLine(number4 + " byte ");
        Console.WriteLine(number5 + " short ");
        Console.WriteLine(number6 + " short ");
        Console.WriteLine(number7 + " byte ");
        Console.WriteLine(number8 + " uint ");
        Console.WriteLine(number9 + " sbyte ");
        Console.WriteLine(number10 + " sbyte ");
        Console.WriteLine(number11 + " int ");
        Console.WriteLine(number12 + " ushort ");
        Console.WriteLine(number13 + " long ");
    }
}

