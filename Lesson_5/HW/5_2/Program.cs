/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
 */

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

double[] MassNums(int size, int from, int to)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        // arr[i] = Math.Round(new Random().Next(from, to + 1) + new Random().NextDouble(), 2);
        arr[i] = Math.Round(rnd.NextDouble() * (to - from) + from, 2); 

    }
    return arr;
}

double DifferenceMinMAx(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
        else if (arr[i] < min)
            min = arr[i];
    }
    Console.Write($"max => {max}, min => {min, 2}");
    Console.WriteLine();
    return Math.Round(max - min, 2);
}


Console.Write("Ввидите длину масива -> ");
int range = int.Parse(Console.ReadLine()!);
Console.Write("Диапазон масива от -> ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("До -> ");
int stop = int.Parse(Console.ReadLine()!);

double[] mass = MassNums(range, start, stop);
Print(mass);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {DifferenceMinMAx(mass)}");
