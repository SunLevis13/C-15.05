// Задайте двумерный массив. Найдите элементы, у которых обе позиции чётные, и замените эти элементы на их квадраты.

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

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arrnums = new int[row, column];

    for (int i = 0; i < row; i++)
    {   
        for (int j = 0; j < column; j++)
        {
            arrnums[i, j] = new Random().Next(from, to);
        }        
    }
    return arrnums;
}

int[,]GetNewArray (int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    for (int i =0; i<row; i += 2)
    {
        for (int j = 0; j<column ; j += 2)
            array [i,j] = array [i,j]* array [i,j];
     }
    return array;
}

int[,] matrix = MassNums (4,6,3,10);
PrintArray(matrix);
Console.WriteLine(); 
PrintArray(GetNewArray(matrix));