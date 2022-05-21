//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Cube(int N)
{
    int i=1;
    Console.Write($"{N} -> ");

    while(i <= N) 
    {
        Console.Write($"{Math.Pow(i,3)}, ");
        i++;
    }
Console.WriteLine();
}

Cube(5);
Cube(7);