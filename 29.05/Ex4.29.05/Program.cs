// Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, выведите позиции по горизонтали и вертикали,
//или напишите, что такого элемента нет.

void PrintArray (int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        } 
        Console.WriteLine();       
    }
}

void Massive(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {   
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }        
    }
}

string Position (int[,] arr, int num)
{
    for (int i =0; i < arr.GetLength(0); i ++)
    {
        for (int j = 0; j < arr.GetLength(1); j ++)
        {
            if(arr [i,j] == num) return $"({i+1}, {j+1})";
     }
    }
    return $"No element: {num}";
}

int[,] matrix = new int [4,6];
Massive(matrix);
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine(Position(matrix, 15));