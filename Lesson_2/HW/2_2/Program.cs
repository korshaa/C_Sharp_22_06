/* Напишите программу, которая выводит 
третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

void BackThird(int num)
{
    Console.WriteLine(num);
    if (num > 99)
    {
        while (num > 1000)
            num = num / 10;
        Console.WriteLine("Третья цифра:" + num % 10);
    }
    else
        Console.WriteLine("Нет третьей цыфры!");
}

Console.Write("Ввидите число: ");
int number = int.Parse(Console.ReadLine()!);
BackThird(number);

// BackThird(int.Parse(Console.ReadLine()!));
