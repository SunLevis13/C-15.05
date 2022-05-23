// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int SumNum(int num)
{
    int all_sum = 0;
    while (num > 0)
    {
        all_sum = all_sum + num % 10;
        num = num / 10;

    }
    return all_sum;
}
Console.WriteLine(SumNum(452));