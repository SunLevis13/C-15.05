﻿// Задайте значение N.
//Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N при помощи рекурсии.

// void ValueSet(int num)
// {
//     if (num == 0)
//         return;
//     ValueSet(num - 1);
//     Console.Write($"{num}, ");
// }

// ValueSet(5);

void ValueSet(int num)
{
    if (num == 0)
        return;
    Console.Write($"{num}, ");
    ValueSet(num - 1);
}

ValueSet(5);
