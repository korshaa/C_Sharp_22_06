/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

double PowAB(int num_a, int num_b)
{
    if (num_b == 0 && num_a != 0)
        return num_a;

    double result = 1;
    int num_b_1 = Math.Abs(num_b);
    
    for (int i = 0; i < num_b_1; i++)
        if (num_b > 0)
            result *= num_a;
        else if (num_b < 0)
            result /= num_a;
    return result;
}

Console.Write("Введите Число А: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите Число B: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{A} в натуральной степени {B} -> {PowAB(A, B)}");
