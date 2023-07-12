/* Напишите программу, которая принимает выводит случайное
трёхзначное число и удаляет вторую цифру.
456 -> 46
782 -> 72
918 -> 98 */


int DellFirst(int num)
{
    Console.WriteLine(num);
    return num / 100 * 10 + num % 10;
}

// 123 % 10 -> 3
// 123 % 100 -> 23

// 123 / 10 -> 12
// 123 / 100 -> 1

int result = DellFirst(new Random().Next(100, 1000));
Console.WriteLine(result);
