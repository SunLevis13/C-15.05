// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] Massive(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(16);
    }
    return arr;
}

int SumUneven(int[]arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i = i + 2);
    {
       sum += arr[i];
    }
    return sum;
}

int[] arr_1 = Massive(9);
SumUneven(arr_1);
Print(arr_1);
Console.WriteLine(SumUneven(arr_1));