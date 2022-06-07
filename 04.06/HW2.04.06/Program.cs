// Задайте прямоугольный двумерный массив. 
// Напишите программу,которая будет находить строку с наименьшей суммой элементов.

void Print(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($" {arr[i, j],3} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Massive(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

void SummMin(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int summ = 1000;
    int num;
    int min = 0;

    for (int i = 0; i < row; i++)
    {   
        num = 0;
        for (int j = 0; j < column; j++)
            num += arr[i, j];
            // Console.WriteLine(num);

        if (summ > num)
        {
            summ = num;
            min = i;
        }
    }
    Console.Write($"Строка c наименьшей суммой - {min + 1}");
}


Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = Massive(row, column, 0, 10);
Print(arr_1);

SummMin(arr_1);
