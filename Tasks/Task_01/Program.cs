// Показать двумерный массив размером m×n заполненный вещественными числами

Console.Write("Введите количество строк двумерного массива:    ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов двумерного массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
double max = 100;
double[,] matrix = new double [m, n];
Random random = new Random();

Console.WriteLine();
Console.WriteLine($"Двумерный массив размером {m} x {n}, заполненный вещественными числами:");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = random.NextDouble() * max;
        Console.Write("{0,6:F2}\t", matrix[i, j]);
    }
    Console.WriteLine();
}