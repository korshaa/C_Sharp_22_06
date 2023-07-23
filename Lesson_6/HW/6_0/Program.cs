/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
 */


void NumberNumbers(int nums)
{
    int count = 0;
    for (int i = 0; i < nums; i++)
    {
        Console.Write($"Ввидите целое число {i+1}: ");
        int  number = int.Parse(Console.ReadLine()!);
        if (number > 0)
            count++;
    }
    Console.Write($"Введеных числе больше нуля -> {count}");
}



Console.Write("Сколько хотите ввести чисел ?: ");
int  numbers = int.Parse(Console.ReadLine()!);
NumberNumbers(numbers);
