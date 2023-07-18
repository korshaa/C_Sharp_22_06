/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */


void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to + 1);
    }
    return arr;
}

int SumNumbers(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0)
            sum += arr[i];
    }
    return sum;
}


Console.Write("Ввидите длину масива -> ");
int range = int.Parse(Console.ReadLine()!);
Console.Write("Диапазон масива от -> ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("До -> ");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(range, start, stop);
Print(mass);
Console.Write($"Сумма не четных позиций равна: {SumNumbers(mass)}");
