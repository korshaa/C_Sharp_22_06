// 0. Напишите программу, которая на вход принимает число и
//    выдаёт его квадрат (число умноженное на само себя).

Console.WriteLine("Write a number: ");
string num_str = Console.ReadLine()!;

int a = int.Parse(num_str);
// int a = int.Parse(Console.ReadLine());

Console.WriteLine(a * a);