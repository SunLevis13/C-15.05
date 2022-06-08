// Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.

int Step(int a, int b)
{
    if (b == 0)
        return 1;
    
    return Step(a, b-1) * a;
    
}

Console.Write(Step(2,3));
