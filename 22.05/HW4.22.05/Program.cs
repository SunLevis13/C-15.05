// Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

void Print(int[]arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int [] Massive (int size)
{
    int [] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(2,19);
    }
    return arr;
}


int [] arr_1 = Massive(5);
Print(arr_1);
