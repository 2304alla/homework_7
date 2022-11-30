// Задача 50.
//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
//  , и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

int[,] CreateMatrixSumIndex(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)

    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}| ");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("|");
    }

}

bool SearhCoordinate(int[,] matrix, int m, int n)
{
    if (m < matrix.GetLength(0) && n < matrix.GetLength(1)) return true;
    return false;
}

Console.WriteLine("Введите координаты");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] arraY2D = CreateMatrixSumIndex(3, 4);
PrintMatrix(arraY2D);
Console.WriteLine();
bool result = SearhCoordinate(arraY2D, a, b);
Console.WriteLine(result ? $"Значение элемента: {arraY2D[a, b]}" : "такого элемента в массиве нет");


