// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

double[] MassNums(int size)
{
    double[] arr = new double[size];
    Random n_new = new Random();

    for (int i = 1; i < size; i++)
    {
        arr[i] = Math.Round(n_new.NextDouble() * (10 + 12) - 10, 2);
    }
    return arr;
}

double NewArray(int [] arr)
{
    double []newarray = new int [size];
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        newarray[i] = arr[i];
    }
    return newarray;
   // Console.WriteLine($"NewMassive = {Math.Round(newarray[i], 2)}");
}

double[] arr_1 = MassNums(10);
Print(arr_1);
double [] arr_1_new = NewArray(arr_1);
Print(arr_1_new);


