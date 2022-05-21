//Напишите программу, которая принимает на вход координаты точки (X и Y),
//причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
void Quarters(int x, int y)
{
    if (x > 0)
    {
        if(y > 0)
        {
            Console.WriteLine("I");
        }
        else if (y < 0)
        {
            Console.WriteLine("IV");
        }
    }
    else if (x < 0)
    {
        if(y > 0)
        {
            Console.WriteLine("II");
        }
        else if (y < 0)
        {
            Console.WriteLine("III");
        }
    }
}

Quarters(2,2);
Quarters(-2,2);
Quarters(-2,-2);
Quarters(2,-2);
Quarters(0,-2);
Quarters(-2,0);