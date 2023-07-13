// 2. Напишите программу, которая принимает
//    на вход число и выдаёт сумму цифр в числе.
/* 452 -> 11
82 -> 10
9012 -> 12 */


int SumNum(int num)
{
    int all_sum = num % 10;
    for (int i = 0; num > 0; i = num % 10)
    {
        num /= 10;
        all_sum += i;
    }
    return all_sum;
}

int number = int.Parse(Console.ReadLine()!);
int result = SumNum(number);
Console.WriteLine(result);
