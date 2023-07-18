// 2. Задайте массив. Напишите программу, которая определяет,
//    присутствует ли заданное число в массиве.

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

string SearchNums(int[] arr, int searchnums)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == searchnums) return "Yes";            
    }
    return "No";       
}


Console.WriteLine("Ввидите диапазон чисел и длину списка");
Console.Write("Количество символов -> ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Число от -> ");
int start = int.Parse(Console.ReadLine()!);
Console.Write(" Число до -> ");
int stop = int.Parse(Console.ReadLine()!);
Console.Write(" Введите искомое число -> ");
int search = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
Console.Write(SearchNums(mass, search));

