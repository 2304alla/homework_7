// Задача 58: Задайте две матрицы. 
//Напишите программу, которая будет
// находить произведение двух матриц.


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

int[,] MultiplicationTwoMatrix(int[,] matr1, int[,] matr2)
{
    int[,] matr3 = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            matr3[i, j] = 0;
            for (int k = 0; k < matr2.GetLength(1); k++)
            {
                matr3[i, j] += matr1[i, k] * matr2[k, j];
            }
        }
    }
    return matr3;
}




Console.WriteLine("Ведите колличесво строк для петвой матрицы : ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите колличесто столбцов первой матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите колличесво строк для второй матрицы : ");
int k = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите колличесто столбцов второй матрицы: ");
int l = Convert.ToInt32(Console.ReadLine());

if (m != l) Console.WriteLine("Умножение не возможно! колличсево строк первой матрицы должно быть равно столбцам второй");
else
{
    int[,] matrix1 = CreateMatrix(m, n, 1, 9);
    int[,] matrix2 = CreateMatrix(k, l, 1, 9);

    PrintMatrix(matrix1);
    Console.WriteLine();
    PrintMatrix(matrix2);
    Console.WriteLine();
    Console.WriteLine();

    int[,] result = MultiplicationTwoMatrix(matrix1, matrix2);
    Console.WriteLine("Произведение двух матриц");
    PrintMatrix(result);

}



