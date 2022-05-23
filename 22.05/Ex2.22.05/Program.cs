// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
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
        arr[i] = new Random().Next(-9, 10);
    }
    return arr;
}

void ChangeNum(int[]arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
}


int[] arr_1 = Massive(12);
Print(arr_1);
ChangeNum(arr_1);
Print(arr_1);

int[] arr_2 = Massive(12);
Print(arr_2);
ChangeNum(arr_2);
Print(arr_2);