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
    int diff = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        int min = 0;
        for (int i = 0; i < arr.Length; i++)

        {
            if (arr[i] < arr[min])
            {
                min = i;
            }
        }

        int max = 0;
        for (int i = 0; i < arr.Length; i++)

        {
            if (arr[i] > arr[max])
            {
                max = i;
            }
        }
        return arr;
    }
    diff = diff + arr[min] + arr[max];
    return diff;

}


int[] arr_1 = Massive(9);
MinMaxdiff(arr_1);
Print(arr_1);


