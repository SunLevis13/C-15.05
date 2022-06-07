// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

void PrintArray (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        } 
        Console.WriteLine();       
    }
}

void FillArray (int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {   
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }        
    }
}

void ChangeRows(int[,]arr)
{
    int lr = arr.GetLength(0) - 1;
    int fr = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        (arr[fr,j], arr[lr,j]) = (arr[lr,j], arr[fr,j]);
    }
}

int[,] matrix = new int [4,4];
FillArray (matrix);
PrintArray (matrix);
Console.WriteLine();
ChangeRows (matrix);
PrintArray (matrix);