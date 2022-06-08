// Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
void Print(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
Console.Write($"{arr[i]} ");
}
Console.WriteLine();
}

int[] Massive(int size)
{
int[] arr = new int[size];
for (int i = 0; i < arr.Length; i++)
{
arr[i] = new Random().Next(2, 10);
}
return arr;
}

int[] Proizv(int[] arr)
{
int size = arr.Length;
int[] proizv = new int[size / 2 + 1];
for (int i = 0; i < size / 2; i++)
{
    if (size % 2 != 0)
    {
        proizv[i] = arr[i] * arr[size - 1 - i];
    }
    if (size % 2 == 0)
    {
        proizv[i] = arr[i] * arr[size - 1 - i];
    }
    Console.Write($"{proizv[i]} ");

}
return proizv;
}
int[] arr_1 = Massive(5);
int[] arr_2 = Proizv(arr_1);
Console.WriteLine();
Print(arr_1);
Print(arr_2);