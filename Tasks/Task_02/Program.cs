// Задать двумерный массив следующим правилом: Aₘₙ = m+n

Console.Write("Введите количество строк двумерного массива:    ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов двумерного массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int [,] matrix = new int [m, n];

Console.WriteLine();
Console.WriteLine($"Ваш массив {m} x {n}:");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = i + j;
        Console.Write($"{matrix[i, j]}\t");
    }
    Console.WriteLine();
}