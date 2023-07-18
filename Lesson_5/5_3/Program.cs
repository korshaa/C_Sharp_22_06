// 3. Задайте одномерный массив из 123 случайных чисел.
//    Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 


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

int QuantityNums(int[] arr)
{
    int quant = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 10 && arr[i] < 99)
            quant++;
    }
    return quant;
}


Console.WriteLine("Ввидите диапазон чисел и длину списка");
Console.Write("Количество значений в списке -> ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Число от -> ");
int start = int.Parse(Console.ReadLine()!);
Console.Write(" Число до -> ");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
Console.Write(QuantityNums(mass));
