// Напишите программу, которая принимает на вход три числа и проверяет,
//может ли существовать треугольник с сторонами такой длины.

string Triangle(int a, int b, int c)
{
    if (a<b+c && c<a+b) return "yes";
    return "no";
}

Console.WriteLine(Triangle(2,3,7));
