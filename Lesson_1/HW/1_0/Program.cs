/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.Write("Write a first number: ");
int first = int.Parse(Console.ReadLine()!);

Console.Write("Write a second number: ");
int second = int.Parse(Console.ReadLine()!);

if (first > second)
{
    Console.WriteLine("Max number: " + first);
    Console.WriteLine("Min number: " + second);
/*     if (first = second)
    Console.WriteLine("the numbers are equal");
    else
    Console.WriteLine("max number: " + first);
 */
}
else if (first < second)
{
    Console.WriteLine("max number: " + second);
    Console.WriteLine("min number: " + first);
}

else
{ 
    Console.WriteLine("The numbers are equal!!!");
}

/* Console.WriteLine("first second: " + second); */
