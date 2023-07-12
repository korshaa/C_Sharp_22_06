// 3. Напишите программу, которая будет принимать на вход два числа и выводить,
//    является ли второе число кратным первому. Если число 2 не кратно числу 1, то
//    программа выводит остаток от деление.




void OneOfNum(int first, int second)
{ 
    if (first % second == 0)
    {
        Console.WriteLine($"{first}, {second} -> multiple");
    }
    else
    {
        Console.WriteLine($"{first}, {second} -> not multiple, the remainder {first % second}");
    }
}

Console.Write("Write a first number: ");
int first = int.Parse(Console.ReadLine()!);

Console.Write("Write a second number: ");
int second = int.Parse(Console.ReadLine()!);

OneOfNum(first, second);


/* void OneOfNum(int num_1, int num_2)
{       
    if (num_1 % num_2 == 0)
    {
        Console.WriteLine($"{num_1}, {num_2} -> multiple");
    }
    else
    {
        Console.WriteLine($"{num_1}, {num_2} -> not multiple, the remainder {num_1 % num_2}");        
    }    
}

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
OneOfNum(a, b); */
