﻿/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли 
число чётным (делится ли оно на два без остатка). 
4 -> да
-3 -> нет
7 -> нет      */

Console.Write("Write a  number: ");
int num = int.Parse(Console.ReadLine()!);

if (num%2 == 0)
{
    Console.WriteLine("Четное число.");
}
else
{
    Console.WriteLine("Нечетное число.");
}

if (num == 0)
{
    Console.WriteLine("НУЛЬ СЧИТАЕТСЯ ЧЕТНЫМ ЧИСЛОМ. xD.");
}
