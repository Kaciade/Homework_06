// Написать программу, которая обменивает элементы первой строки и последней строки

Console.Write("\nВведите количество строк двумерного массива:    ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов двумерного массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите левую часть диапазона массива:          ");
int min = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите правую часть диапазона массива:         ");
int max = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int [m, n];
Random random = new Random();

Console.WriteLine();
Console.WriteLine($"Исходный массив {m} x {n}:");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = random.Next(min, max);
        Console.Write($"{matrix[i, j]}\t");
    }
    Console.WriteLine();
}

int[] a = new int [n];

Console.WriteLine();
Console.WriteLine($"Изменённый массив {m} x {n}:");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i == 0)
        {
            a[j] = matrix[i,j];
            matrix[i,j] = matrix[n-1,j];
            matrix[n-1,j] = a[j];
            Console.Write($"|{matrix[i, j]}|\t");
        }
        else if (i == (n - 1))
        {
            Console.Write($"|{matrix[i, j]}|\t");
        }
        else
        {
            Console.Write($"{matrix[i, j]}\t");
        }
    }
    Console.WriteLine();
}
Console.WriteLine("\n|...| - заменённые элементы массива, у которых оба индекса чётные\n");