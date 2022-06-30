// Задан массив. Задать новый массив, где все элементы четные
void methodArray (string [] array)
{
     string[] newarr = new string[array.Length];
     for (int i=0; i<array.Length; i++)
     {      
        if(array[i].Length<=3)
        {
        newarr[i]=array[i];
        Console.WriteLine(newarr[i]); 
        }
     }
        Console.WriteLine(); 
}

void Print(string [] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
    Console.WriteLine();
}

string [] array = {"hello", "2", "world", ":-)"};

methodArray(array);
Print(array);