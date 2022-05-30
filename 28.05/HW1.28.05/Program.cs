// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Check(int num)
{
    int count = 0;
    
    for (int i = 1; i <= num; i++)
    {
        Console.Write($"Number {i}: ");
        int a = int.Parse(Console.ReadLine());
        if (a > 0) count++;
    }
    return count;
}

Console.Write("How many number will you fill?: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine($"Numbers value greater zero: {Check(a)}");
