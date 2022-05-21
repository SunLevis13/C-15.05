// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат
//точек в этой четверти (x и y).
void Func (int quarter)
{
    if (quarter == 1)
    {
        Console.WriteLine($"Quarter {quarter} -> x>0, y>0");
    }
    else if (quarter == 2)
    {
        Console.WriteLine($"Quarter {quarter} -> x<0, y>0");
    }
    else if (quarter == 3)
    {
        Console.WriteLine($"Quarter {quarter} -> x<0, y<0");
    }
    else if (quarter == 4)
    {
        Console.WriteLine($"Quarter {quarter} -> x>0, y<0");
    }
    else
    {
         Console.WriteLine("Please, print from 1 to 4");
    }
}

Func (1);
Func (2);
Func (3);
Func (4);
Func (7);