// 2. Задайте значения M и N. Напишите программу, которая 
//    рекурсивно выведет все натуральные числа в промежутке от M до N.


void ValuesSet(int num_N, int num_M)
{
    if (num_N > num_M) return;
    ValuesSet(num_N, num_M - 1);
    Console.Write($"{num_M}, ");
}

ValuesSet(5, 8);

/* void Spacing(int M, int N) -из разбора
{
    if (N < M) return;
    Spacing(M, N - 1);
    Console.Write($"{N}, ");
}

Spacing(3, 5); */
