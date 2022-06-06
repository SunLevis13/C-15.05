// Задайте двумерный массив. Найдите сумму элементов главной диагонали.

void Print2dimensionarray (int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{arr[i, j]} ");
        } 
        Console.WriteLine();       
    }
}

int[,] Get2dimensionarray(int row, int column, int from, int to)
{
    int[,] result = new int [row,column];
    for (int i = 0; i < row; i++)
    {   
        for (int j = 0; j < column; j++)
        {
            result[i, j] = new Random().Next(from,to);
        }        
    }
    return result;
}

int [,] array = Get2dimensionarray(4,4,3,10);

Print2dimensionarray(array);
int count = 0;
for (int i =0; i < array.GetLength(0); i ++)
    { 
    count += array[i,i];
        }
   Console.WriteLine ("Сумма элементов по диагонали = " + count);


// int[,] matrix = new int [4,6];
// Massive(matrix);
// PrintArray(matrix);
// Console.WriteLine();
// Console.WriteLine(Position(matrix, 15));
