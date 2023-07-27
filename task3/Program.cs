// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int rows = GetNum("Введите количество строк массива m = ");
int colums = GetNum("Введите количество столбцов массива n = ");
int[,] arrayRandom = GetArrayRandom(rows,colums);
PrintArray(arrayRandom);
PrintArithmeticMeans(GetArithmeticMeanInColums(arrayRandom));

int GetNum(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] GetArrayRandom(int m, int n)
{
    int[,] res = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i,j] = new Random().Next(0,10);
        }
    }
    return res;
}

double[] GetArithmeticMeanInColums(int[,] matrix)
{
    double[] arithmeticMeans = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i,j];
        }
        arithmeticMeans[j] = Math.Round(sum / matrix.GetLength(0), 3);
    }
    return arithmeticMeans;
}

void PrintArithmeticMeans(double[] arr)
{
    Console.Write("Среднее арифметическое каждого столбца:");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(" " + arr[i] + ";");
    }
    Console.WriteLine("\b.");
}

void PrintArray(int[,] arr)
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