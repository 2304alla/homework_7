// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

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

int[] MeanSumColumns(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];

        }
        array[i] = sum;
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("");
}

int MinSumArray(int[] array)
{
    int min = array[0];
    int indexer = 0;
    for (int i = 1; i < array.Length; i++)
    {

        if (array[i] < min)
        {
            min = array[i];
            indexer = i;
        }
    }

    return indexer + 1;
}

Console.WriteLine("Ведите колличесво строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите колличесто столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < n) Console.WriteLine("Колличсево строк должно быть больше");
else
{
    int[,] matr = CreateMatrix(m, n, 1, 9);
    PrintMatrix(matr);
    Console.WriteLine();

    int[] arr = MeanSumColumns(matr);
    Console.WriteLine("Сумма элементов каждой строки");
    PrintArray(arr);
    Console.WriteLine();
    int minSum = MinSumArray(arr);
    Console.WriteLine($"Минимальная сумма в {minSum} строке ");
}