﻿// 4. Найдите произведение пар чисел в одномерном массиве.
//    Парой считаем первый и последний элемент, второй и предпоследний
//    и т.д. Результат запишите в новом массиве. 


void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 11);
    }
    return arr;
}

int[] PairsNum(int[] arr)
{
    int size = arr.Length;
    int[] new_arr = new int[size / 2];

    if (size % 2 == 1)
    {
        new_arr = new int[size / 2 + 1];
        new_arr[new_arr.Length - 1] = arr[size / 2];
    }

    for (int i = 0; i < size / 2; i++)
    {
        new_arr[i] = arr[i] * arr[size - i - 1];
    }

    return new_arr;
}

int[] arr_1 = MassNums(5);
Print(arr_1);
int[] arr_1_new = PairsNum(arr_1);
Print(arr_1_new);

int[] arr_2 = MassNums(6);
Print(arr_2);
int[] arr_2_new = PairsNum(arr_2);
Print(arr_2_new);

