//string[,] table = new string[2, 5];
// как выглядит массив (цифры - индексы)
// table[0,0] table[0,1] table[0,2] table[0,3] table[0,4]
// table[1,0] table[1,1] table[1,2] table[1,3] table[1,4]


// table[1, 2] = "слово";
// for (int rows = 0; rows < 2; rows++) // цикл строк
// {
//     for (int columns = 0; columns < 5; columns++) // внутренний цикл столбцов
//     {
//         Console.WriteLine($"-{table[rows,columns]}-");

//     }

// }

int [,] matrix = new int [3,4];
// вместо rows, columns будем использовать i,j
for (int i=0; i < matrix.GetLength(0); i++) // вывод строк; matrix.GetLength(0) - аналогично 3
{
    for (int j=0; j < matrix.GetLength(1); j++) //вывод столбцов в строке; matrix.GetLength(1) - аналогично 4
    {
        Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();
}
