// 1. Напишите программу замена элементов массива:
//    положительные элементы замените на соответствующие отрицательные, и наоборот.

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

void ChangePosNeg(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] *= -1;
}


Console.WriteLine("Ввидите диапазон чисел и длину списка");
Console.Write("Количество символов -> ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Число от -> ");
int start = int.Parse(Console.ReadLine()!);
Console.Write(" Число до -> ");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
ChangePosNeg(mass);
Print(mass);

