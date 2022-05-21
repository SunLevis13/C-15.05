// напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
int NumCount(int num)
{
    string result = num.ToString();
    return result.Length;
}

Console.WriteLine(NumCount(456));
Console.WriteLine(NumCount(78));
Console.WriteLine(NumCount(89126));