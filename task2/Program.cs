// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] matrix = new int[,]
{
{1,4,7,2},
{5,9,2,3},
{8,4,2,4},
};

PrintArray(matrix);
string[] position = GetPosition("Введите позицию элемента двумерног массива через запятую: ");
PrintElementInPosition(matrix,position);

string[] GetPosition(string message)
{
    Console.Write(message);
    string[] pos = Console.ReadLine()!.Split(',');
    return pos;
}

void PrintElementInPosition(int[,] arr , string[] posit)
{
    int[] pos = new int[2];
    pos[0] = int.Parse(posit[0]);
    pos[1] = int.Parse(posit[1]);
    if (pos[0] < arr.GetLength(0) && pos[1] < arr.GetLength(1)) 
    Console.WriteLine($"({pos[0]},{pos[1]}) -> {arr[pos[0],pos[1]]}");
    else Console.WriteLine($"({pos[0]},{pos[1]}) -> такого элемента в массиве нет.");
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