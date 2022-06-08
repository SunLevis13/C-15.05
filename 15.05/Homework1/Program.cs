// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Palind(int num)
{
    int n1 = num / 10000;
    int n2 = num / 1000 % 10;
    int n3 = num / 100 % 10;
    int n4 = num / 10 % 10;
    int n5 = num % 10;
    if (n1 == n5 & n2 == n4)
    {
        Console.WriteLine("It is Palindrom");
    }
    else
    {
        Console.WriteLine("It is NOT Palindrom");
    }
}

Palind(12421);
Palind(23423);

