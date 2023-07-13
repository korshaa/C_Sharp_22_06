// 2. Напишите программу, которая принимает на вход
//    число N и выдаёт произведение чисел от 1 до N.


int ProductofNumbers(int num)
{
    int all_sum = 1;
    for (int i = 1; i <= num; i++)
        all_sum *= i;
    return all_sum;
}

int N = int.Parse(Console.ReadLine()!);
int result = ProductofNumbers(N);
Console.WriteLine(result);
