// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
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

int[] MinMaxdiff(int[] arr)
{
    int i = 0;
    int min = 1;
    int diff = 0;
    while (i < arr.Length)
    {
        if (arr[i] < arr[min])
        {
            arr[i] = arr[min];
        }
        diff = diff + arr[min];
        i++;
    }
    return arr[min];
}


int[] arr_1 = Massive(9);
MinMaxdiff(arr_1);
Print(arr_1);
Console.WriteLine(MinMaxdiff(arr_1));


