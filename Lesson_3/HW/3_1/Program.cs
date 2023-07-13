﻿/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */


double DistancePoints(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}

int x_1 = int.Parse(Console.ReadLine()!);
int y_1 = int.Parse(Console.ReadLine()!);
int z_1 = int.Parse(Console.ReadLine()!);
int x_2 = int.Parse(Console.ReadLine()!);
int y_2 = int.Parse(Console.ReadLine()!);
int z_2 = int.Parse(Console.ReadLine()!);


Console.WriteLine(DistancePoints(x_1, y_1, z_1, x_2, y_2, z_2));
