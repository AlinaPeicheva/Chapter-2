using System;


class Program
{
    static void Main()
    {
        /*
         Декларирайте две променливи от тип string и им присвоете стойност "The "use" of quotations causes difficulties." 
         (без първите и последни кавички). В едната променлива използвайте quoted string, а в другата не го използвайте.
        */
        string str1 = "The \"use\" of quotations causes difficulties.";
        string str2 = "The " + "\u0022" + "use" + "\u0022" + " of quotations causes difficulties.";

        Console.WriteLine(str1);
        Console.WriteLine(str2);
    }
}

