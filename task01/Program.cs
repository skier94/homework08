//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//В итоге получается вот такой массив:

//1 2 4 7

//2 3 5 9

//2 4 4 8

//Functions
void Reorder(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int a = 0; a < array.GetLength(1) - 1; a++)
            {
                if (array[i, a] > array[i, a + 1])
                {
                    int prov = array[i, a + 1];
                    array[i, a + 1] = array[i, a];
                    array[i, a] = prov;
                }
            }
        }
    }
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

int[,] array = GetArray(rows, columns);
PrintArray(array);

Reorder(array);
PrintArray(array);