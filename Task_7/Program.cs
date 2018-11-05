using System;


class Program
{
    static void Main()
    {
        /*Декларирайте две променливи от тип string със стойности "Hello" и "World". Декларирайте променлива от тип object. 
         Присвоете на тази променлива стойността, която се получава от конкатенацията на двете стрингови променливи 
         (добавете интервал, ако е необходимо). Отпечатайте променливата от тип object.
        */
        string str1 = "Hello";
        string str2 = "World";
        object obj = str1 + ", " + str2 + "!";
        Console.WriteLine(obj);
    }
}

