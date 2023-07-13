﻿// 3. Напишите программу, которая выводит массив из 8 элементов,
//    заполненный нулями и единицами в случайном порядке.
/* 
void MassEight(int num)
{   
    int[] arr = new int[num];
    
    for (int i = 0; i < num; i++)
    {
        arr[i] = new Random().Next(2);
        Console.Write($"{arr[i]} ");
    }    
}

MassEight(int.Parse(Console.ReadLine()!));
 */

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 2);
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

int[] array = new int[8];


FillArray(array);
PrintArray(array);
