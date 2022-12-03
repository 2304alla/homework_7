// Задача 59: Задайтедвумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

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

int[] MinElemIndexRowColum(int[,] matrix)
{
    int min = matrix[0, 0];
    int[] indexer = new int[2];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                indexer[0] = i;
                indexer[1] = j;
            }
        }
    }
    return indexer;
}

int[,] CreateNewMatrix(int[,] matrix, int[] ind)
{
    int[,] newmatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int row = 0;
    for (int i = 0; i < newmatrix.GetLength(0); i++)
    {
        if (row == ind[0]) row++;
        int columns = 0;
        for (int j = 0; j < newmatrix.GetLength(1); j++)
        {
            if (columns == ind[1]) columns++;
            newmatrix[i, j] = matrix[row, columns];
            columns++;
        }
        row++;
    }
    return newmatrix;
}


Console.WriteLine("Ведите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите колличесто столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] arraY2D = CreateMatrix(m, n, 10, 55);
PrintMatrix(arraY2D);
Console.WriteLine();
int[] indexMinElem = MinElemIndexRowColum(arraY2D);
Console.Write($"Минимальный элемент с индексами: {indexMinElem[0]},{indexMinElem[1]}");
Console.WriteLine();
int[,] newMatrix = CreateNewMatrix(arraY2D, indexMinElem);
PrintMatrix(newMatrix);