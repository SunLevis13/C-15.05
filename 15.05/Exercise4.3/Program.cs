// 3. Напишите программу, которая принимает на вход число (N) 
//    и выдаёт таблицу квадратов чисел от 1 до N.

double[] Squares(int n)
{
    double[] nums = new double[n];
    int index = 0;

    while (index < n)
    {
        nums[index] = Math.Pow((index + 1), 2);
        index += 1;
    }

    return nums;
}

void PrintList(int num)
{
    double[] arr = Squares(num); 
    int index = 0;
    
    Console.Write($"{num} -> ");

    while (index < arr.Length)
    {
        Console.Write($"{arr[index]}, ");
        index += 1;
    }
}

PrintList(6);