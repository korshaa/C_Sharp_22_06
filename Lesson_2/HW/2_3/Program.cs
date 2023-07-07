/* Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет,
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

void SearchWeekend(int num)
{
    if (num > 0 && num < 8)
        if (num > 0 && num < 6)
        {
            Console.WriteLine("Рабочий день");
            if (num == 1)
                Console.WriteLine("Пн");
            else if (num == 2)
                Console.WriteLine("Вт");
            else if (num == 3)
                Console.WriteLine("Ср");
            else if (num == 4)
                Console.WriteLine("Чт");
            else
                Console.WriteLine("Вт");
        }
        else
        {
            Console.WriteLine("Выходной");
            if (num == 6)
                Console.WriteLine("Сб");
            else
                Console.WriteLine("ВС");
        }
    else
        Console.WriteLine("Такого дня недели не существует!!!");
}

// 123 % 10 -> 3
// 123 % 100 -> 23

// 123 / 10 -> 12
// 123 / 100 -> 1

Console.Write("Ввидите номер дня недели от 1 до 7: ");
int number = int.Parse(Console.ReadLine()!);
SearchWeekend(number);
