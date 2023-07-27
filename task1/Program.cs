// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int rows = GetNum("Введите количество строк массива m = ");
int colums = GetNum("Введите количество столбцов массива n = ");
double[,] arrayRandom = GetArrayRandom(rows,colums);
PrintArray(arrayRandom);

int GetNum(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

double[,] GetArrayRandom(int m, int n)
{
    double[,] res = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i,j] = Math.Round(new Random().NextDouble() * 10, 1);
        }
    }
    return res;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write('|');
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine("\b|");
    }
}