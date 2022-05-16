// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
void Squares(int a)
{
    int i = 1;
    
    while (i <= a)
    {
        Console.WriteLine(Math.Pow(i, 2));
        i++;
    }
}
Squares(5);