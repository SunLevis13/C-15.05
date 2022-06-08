// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
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

void CheckNum (int num, int[]arr)
{
    string flag = "no";
    for (int i = 0; i < arr.Length; i++)
    {
    if(arr[i] == num)
    {
        flag = "yes";
        break;
    }
    }
    Console.WriteLine(flag);

}


int[] arr_1 = Massive(12);
CheckNum (4, arr_1);
Print(arr_1);