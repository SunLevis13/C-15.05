// напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

void Sum(int num)
{
    int i = 0;
    while(num > 0){
        num = num / 10;
        i = i + 1;
    }
    Console.WriteLine(i);
}

Sum(1235);