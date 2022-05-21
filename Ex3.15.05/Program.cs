// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int Proizv(int num)
{
    int all_pow = 1;
    for (int i = 1; i <= num; i++)
    {
        all_pow *= i; // = all_sum = all_sum * i
    }
    return all_pow;
}

Console.WriteLine(Proizv(7));
Console.WriteLine(Proizv(4));
Console.WriteLine(Proizv(8));