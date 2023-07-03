// // 3. Напишите программу, которая на вход принимает одно число
//    (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Write a number: ");
int N = int.Parse(Console.ReadLine()!);
int count = -N;
Console.WriteLine(count);
while (count != N)
{
    if (N > 0)
    count++;
    else
    count--;
Console.WriteLine(count);
}
