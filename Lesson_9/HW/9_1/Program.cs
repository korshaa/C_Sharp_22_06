/* Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N с помощью рекурсии.
 */

int SumNum(int M, int N)
{ 
    if (N < M) return 0;
    return SumNum(M, N - 1) + N;
}
Console.WriteLine(SumNum(4, 8));
Console.WriteLine(SumNum(1, 15));

/* int SumNum(int M, int N)
{

    if (N < M) return SumNum(M, N - 1) + N;
    if (N == M) return SumNum(M, N) + M;
    else return;
}
Console.WriteLine(SumNum(4, 8)); */
