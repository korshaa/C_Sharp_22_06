// 3. Напишите программу, которая принимает на вход число и проверяет,
//    кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

void Multiple(int num)
{
    if (num % 7 == 0 && num % 23 == 0)
    {
        Console.Write("Number multiple 7 and 23");
    }
    else
    {
        Console.Write("Number NO multiple 7 and 23");
    }

}


Console.Write("Write a number: ");
int num = int.Parse(Console.ReadLine()!);
Multiple(num);

/* 
int Multiple(int num)
{
    if (num % 7 == 0 && num % 23 == 0)
        return ("Number multiple 7 and 23");
    return ("Number NO multiple 7 and 23");
}


Console.Write("Write a number: ");
int result = Multiple(int.Parse(Console.ReadLine()!));
Console.Write(result); */
