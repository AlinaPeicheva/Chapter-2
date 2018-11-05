using System;


class Program
{
    static void Main()
    {
    /*Декларирайте две променливи от тип string и им присвоете стойности "Hello" и "World". 
    Декларирайте променлива от тип object и ѝ присвоете
    стойността на конкатенацията на двете променливи от тип string (не изпускайте интервала по средата).     Декларирайте трета променлива от тип string и я инициализирайте със стойността на променливата от тип object.    */

        string str1 = "Hello";
        string str2 = "World";
        object obj = str1 + ", " + str2;
        string str3 = obj.ToString();

        Console.WriteLine(str3);
    }
}

