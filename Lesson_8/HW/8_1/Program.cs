// 2. Задайте прямоугольный двумерный массив. Напишите программу,
//    которая будет находить строку с наименьшей суммой элементов.


void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],4} ");
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

int[] SumNumbers(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int[] all_numbers = new int[row];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            all_numbers[i] += arr[i, j];
        }
    }
    return all_numbers;
}

void FindMin(int[] arr)
{
    int min_ind = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < arr[min_ind]) min_ind = i;
    }
    Console.WriteLine($"Сумма: {arr[min_ind]}, Строка: {min_ind + 1}");
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

int[] mass_sum = SumNumbers(mass);
FindMin(mass_sum);
