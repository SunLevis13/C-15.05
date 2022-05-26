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

int Proizv (int[]arr)
{
    int proizv=1;
    int size = arr.Length;
    for (int i = 0; i < size/2; i++)
    {
        if(size%2 != 0)
        {
            proizv = arr[i]*arr[size-1-i];
        }
        if(size%2 == 0)
        {
            proizv = arr[i]*arr[size-1-i];
        }
        Console.Write($"{proizv} ");
           
    }
    return proizv;
 }

int [] arr_1 = Massive(9);
Proizv(arr_1);
Console.WriteLine();
Print(arr_1);

