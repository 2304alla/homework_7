// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}; ");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("|");
    }

}

void ReplaceRowMartix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int k = matrix.GetLength(1) - 1;
        while (k > 0)
        {


            for (int j = 0; j < k; j++)
            {
                if (matrix[i, j] < matrix[i, j + 1])
                {

                    int temp = matrix[i, j + 1];
                    matrix[i, j + 1] = matrix[i, j];
                    matrix[i, j] = temp;

                }

            }
            k--;
        }
    }
}




Console.WriteLine("Ведите колличесво строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите колличесто столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] matr = CreateMatrix(m, n, 1, 9);
PrintMatrix(matr);
Console.WriteLine();

ReplaceRowMartix(matr);
PrintMatrix(matr);