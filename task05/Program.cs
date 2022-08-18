//Задача 62. Заполните спирально массив 4 на 4.

//Например, на выходе получается вот такой массив:

//1 2 3 4

//12 13 14 5

//11 16 15 6

//10 9 8 7

int n = 4;
int[,] GetMatrix = new int[n, n];

int count = 1;
int i = 0;
int j = 0;

while (count <= GetMatrix.GetLength(0) * GetMatrix.GetLength(1))
{
    GetMatrix[i, j] = count;
    count++;
    if (i <= j + 1 && i + j < n - 1)
        j++;
    else if (i < j && i + j >= n - 1)
        i++;
    else if (i >= j && i + j > n - 1)
        j--;
    else
        i--;
}

PrintArray(GetMatrix);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}

