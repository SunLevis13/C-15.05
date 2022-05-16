// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
void Squares(int a)
{
    int i = 1;
    Console.Write($"{a} -> ");

    while (i <= a)
    {
        Console.Write($"{Math.Pow(i, 2)}, ");
        i++;
    }
    Console.WriteLine();
}
Squares(5);
Squares(11);