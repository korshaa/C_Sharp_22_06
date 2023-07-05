/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */


Console.Write("Write a first number: ");
int first = int.Parse(Console.ReadLine()!);

Console.Write("Write a second number: ");
int second = int.Parse(Console.ReadLine()!);

Console.Write("Write the third number: ");
int third = int.Parse(Console.ReadLine()!);

if (first > second)
{
    if (first > third)
    Console.WriteLine("max number: " + first);
    else
    Console.WriteLine("max number: " + third);
} 
else 
{
    if (second > third)
    Console.WriteLine("max number: " + second);
    else
    Console.WriteLine("max number: " + third);
}
