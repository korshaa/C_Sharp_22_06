// 3. Задайте две матрицы. Напишите программу,
//    которая будет находить произведение двух матриц.


void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],3} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

int[,] MatrixMultiplication(int[,] first_arr, int[,] second_arr)
{
    int row_size = first_arr.GetLength(0);
    int column_size = first_arr.GetLength(1);
    int[,] res_mat = new int[row_size, column_size];

    if (row_size != second_arr.GetLength(0) || column_size != second_arr.GetLength(1)) return res_mat;
    
    for (int i = 0; i < row_size; i++)       
        for (int j = 0; j < column_size; j++)
            res_mat[i, j] = first_arr[i, j] * second_arr[i, j];            
    return res_mat;
}

Console.Write("Введите количество строк первого масива: ");
int row_1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов первого масива: ");
int column_1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество строк второго масива: ");
int row_2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов второго масива: ");
int column_2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите минимальное число первого масива ");
int star_1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное число первого масива ");
int stop_1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите минимальное число второго масива ");
int star_2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное число второго масива ");
int stop_2 = int.Parse(Console.ReadLine()!);


int[,] matrix_1 = MassNums(row_1, column_1, star_1, stop_1);
Print(matrix_1);
int[,] matrix_2 = MassNums(row_2, column_2, star_2, stop_2);
Print(matrix_2);

int[,] result_mat = MatrixMultiplication(matrix_1, matrix_2);
Print(result_mat);
