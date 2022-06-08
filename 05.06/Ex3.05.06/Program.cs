// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//Использовать рекурсию.

int Summ(int num)
{
    if (num == 0)
        return 0;
    return Summ(num / 10) + num % 10;
}

Console.Write(Summ(453));

