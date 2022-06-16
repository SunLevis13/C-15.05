// Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
int Sum(int m, int n)
{
    if (m > n) return 0;    
    return Sum(m, n - 1) + n;
}

Console.WriteLine(Sum(2, 8));
