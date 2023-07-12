/* Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */


int FirstNum(int num)
{
    return num % 100 / 10;
}

Console.Write("Write a number: ");
int result = FirstNum(int.Parse(Console.ReadLine()!));
Console.WriteLine(result);
