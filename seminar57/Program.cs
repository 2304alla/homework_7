// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.



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

int[] MatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
        }
    }
    return array;
}

void DiktionElemArray(int[] array)
{
    int num = array[0];
    int count = 1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) count++;
        else
        {
            Console.WriteLine($"{num} встречается {count} раз(а)");
            num = array[i + 1];
            count = 1;
        }
    }
    Console.WriteLine($"{num} встречается {count} раз(а)");
}



Console.WriteLine("Ведите элемент: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите колличесто столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Ведите элемент: ");
//
//int k = Convert.ToInt32(Console.ReadLine());

int[,] arraY2D = CreateMatrix(m, n, 0, 9);
PrintMatrix(arraY2D);
Console.WriteLine();

int[] newArr = MatrixToArray(arraY2D);


DiktionElemArray(newArr);