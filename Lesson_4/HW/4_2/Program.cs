/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

Console.WriteLine("Ввидите диапазон чисел и длину списка");
Console.Write("Число от -> ");
int num_1 = int.Parse(Console.ReadLine()!);
Console.Write("Число до -> ");
int num_2 = int.Parse(Console.ReadLine()!);
Console.Write("Количество символов -> ");
int num_len = int.Parse(Console.ReadLine()!);

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    
    while (index < length)
    {
        collection[index] = new Random().Next(num_1, num_2);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.Write(col[position] + " ");
        position++;
    }
}

int[] array = new int[num_len];


FillArray(array);
PrintArray(array);
