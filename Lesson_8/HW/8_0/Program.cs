// 1. Задайте двумерный массив. Напишите программу, которая
//    упорядочит по убыванию элементы каждой строки двумерного массива.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to + 1);
    return arr;
}

void Decreasing(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            for(int f =0; f < column_size - j - 1; f++)
                if (arr[i, f] < arr[i, f +1])
                    (arr[i, f], arr[i, f + 1]) = (arr[i, f + 1], arr[i, f]);
        }
    }                
}

Console.Write("Введите количество строк:: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int column_num = int.Parse(Console.ReadLine()!);

Console.Write("Введите минимальное число в масива ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное число масива ");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num, start, stop);

Print(mass);

Decreasing(mass);
Print(mass);


