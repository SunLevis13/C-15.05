// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Count(int num)
{
    int i = 0;
    while(num>0)
    {i = i + 1;}
    return i;
    
}

Console.Write (Count(4));
