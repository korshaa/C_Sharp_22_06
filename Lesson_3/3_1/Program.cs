// 1. Напишите программу, которая по заданному номеру четверти,
//    показывает диапазон возможных координат точек в этой четверти (x и y).

void Quarters(int num)
{
    if (num < 1 || num > 4)
        Console.WriteLine("num < 1 or num > 4");
    else if (num == 1)
        Console.WriteLine("x > 0 and y > 0");
    else if (num == 2)
        Console.WriteLine("x < 0 and y > 0");
    else if (num == 3)
        Console.WriteLine("x < 0 and y < 0");
    else if (num == 4)
        Console.WriteLine("x > 0 and y < 0");
}

int num_1 = int.Parse(Console.ReadLine()!);
Quarters(num_1);
