// 1. Напишите программу, которая принимает
//    на вход число и выдаёт количество цифр в числе.


int Quantity(int num)
{
    int res = 0;
    for (int result = 1; num > 0; result++)
    {
        num /= 10;
        res = result;
    }
        // Console.WriteLine(count);
    return res;
}


int number = int.Parse(Console.ReadLine()!);
int result = Quantity(number);
Console.WriteLine(result);
/* int num = 9;
int count = 0;
while(num > 0)
{
    num = num / 10;
    count++;
}
Console.WriteLine(count); */

/* // 2 вариант

int NumCount_2(long num)
{
    int result = 0;

    while (num > 0)
    {
        num /= 10;
        result += 1;
    }
    return result;
}

Console.WriteLine(NumCount_2(long.Parse(Console.ReadLine()!))); */
