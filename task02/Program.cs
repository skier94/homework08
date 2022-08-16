//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

//Functions

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

int SumElements(int[,] ar, int i)
{
    int sum = ar[i, 0];
    for (int j = 1; j < ar.GetLength(1); j++)
    {
        sum += ar[i, j];
    }
    return sum;
}
//Code

Console.WriteLine(" Введите количество строк ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine(" Введите количество столбцов ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] array = GetArray(rows, columns);
PrintArray(array);

int minRow = 0;
int sumLine = SumElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int ProvSumLine = SumElements(array, i);
    if (sumLine > ProvSumLine)
    {
        sumLine = ProvSumLine;
        minRow = i;
    }
}

Console.WriteLine($"{minRow + 1} - строкa с наименьшей суммой ({sumLine}) элементов ");