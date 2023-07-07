// 0. Напишите программу, которая принимает на вход трёхзначное число
//    и на выходе показывает последнюю цифру этого числа.

int TakeNum(int num)
{
    Console.Writeline(num);
    return num % 10;
}

// 123 % 10 -> 3
// 123 % 100 -> 23

// 123 / 10 -> 12
// 123 / 100 -> 1

int result = TakeNum(new Random().Next(100, 1000));
Console.WriteLine(result);