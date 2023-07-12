/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
 */

void Cubes(int N)
{
    if (N == 0)
        Console.Write("0 в кубе равняеться нулю");
    else if (N > 0)
    {
        Console.Write($"Кубы чисел от 1 до {N} -> ");
        int i = 1;
        while (i < N + 1)
        {
            Console.Write($"{Math.Pow(i, 3)}, ");
            i++;
        }
    }
    else if (N < 0)
    {
        Console.Write($"Кубы чисел от {N} до 1 -> ");
        while (N < 2)
        {
            Console.Write($"{Math.Pow(N, 3)}, ");
            N++;
        }
    }
}

Console.Write("Введите число: ");
int result = int.Parse(Console.ReadLine()!);
Cubes(result);
