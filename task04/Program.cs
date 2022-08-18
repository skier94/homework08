//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

//массив размером 2 x 2 x 2

//12(0,0,0) 22(0,0,1)

//45(1,0,0) 53(1,0,1)

int[,,] GetArray(int m, int n, int t)
{
    int[,,] result = new int[m, n, t];
    int counter = 10;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
                result[i, j, k] = counter++;
            }
        }
    }
    return result;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]}");
                Console.Write($"({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

}
//Code
Console.WriteLine(" Введите x ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine(" Введите y ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine(" Введите z ");
int z = int.Parse(Console.ReadLine());
Console.WriteLine();


int[,,] array = GetArray(x, y, z);
PrintArray(array);