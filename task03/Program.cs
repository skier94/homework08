//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

//Например, заданы 2 массива:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//и
//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7
//Их произведение будет равно следующему массиву:
//1 20 56 10
//20 81 8 6
//56 8 4 24
//10 6 24 49

int[,] SumArray(int[,] FirstAr, int[,] SecondAr, int[,] newar)
{
    for (int i = 0; i < newar.GetLength(0); i++)
    {
        for (int j = 0; j < newar.GetLength(1); j++)
        {
            newar[i, j] = FirstAr[i, j] * SecondAr[i, j];
        }
    }
    return newar;
}

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
//Code
Console.WriteLine(" Введите количество строк ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine(" Введите количество столбцов ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] array = GetArray(rows, columns);
PrintArray(array);
int[,] ar = GetArray(rows, columns);
PrintArray(ar);
int[,] newar = new int[rows, columns];


int[,] arr = SumArray(array, ar, newar);
PrintArray(arr);