// 1. Напишите программу, которая на вход принимает два числа и проверяет,
//    является ли первое число квадратом второго.

Console.WriteLine("Write a two number: ");
int a = int.Parse(Console.ReadLine()!);  
int b = int.Parse(Console.ReadLine()!);

if (a == b * b)
{
    Console.WriteLine("yes");    
}
else
{
Console.WriteLine("no");
}
