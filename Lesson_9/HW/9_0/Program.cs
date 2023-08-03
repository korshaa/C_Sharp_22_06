/* Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные
натуральные числа в промежутке от M до N с помощью рекурсии. */

void EvenInteger(int M, int N)
{
    if (N < M) return;
    EvenInteger(M, N - 1);
    if (N % 2 == 0) Console.Write($"{N}, ");
}

EvenInteger(3, 8);
