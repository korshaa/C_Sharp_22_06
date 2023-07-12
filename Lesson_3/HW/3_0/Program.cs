/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

void Palindrome(int num)
{
    if (num > 9999 && num < 100000)
    {
        /* Console.WriteLine(num / 10000);
        Console.WriteLine(num % 10);
        Console.WriteLine(num / 10 % 10 );
        Console.WriteLine(num % 10000 / 1000); */
        //Console.WriteLine(num % 10000 / 10 / 100);
        if (num / 10000 == num % 10)
            if (num / 10 % 10 == num % 10000 / 1000)
                Console.WriteLine($"Число {num} является палиндромом");
            else
                Console.WriteLine($"Число {num} не является палиндромом");
        else
            Console.WriteLine($"Число {num} не является палиндромом");
    }
    else
        Console.WriteLine($"Error: Чиисло {num} не является пятизначным");
}

Console.Write("Введите пяти значное число: ");
int number = int.Parse(Console.ReadLine()!);
Palindrome(number);
