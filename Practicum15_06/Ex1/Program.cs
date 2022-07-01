// Задан массив. Задать новый массив, где все элементы четные
// void methodArray (string [] array)
// {
//      string[] newarr = new string[array.Length];
//      for (int i=0; i<array.Length; i++)
//      {      
//         if(array[i].Length<=3)
//         {
//         newarr[i]=array[i];
//         Console.Write("newarr = ");
        
//         }Console.Write($"{newarr[i]} ");
//            }
//         Console.WriteLine();
// }

// void Print(string [] array)
// {
//     for (int i=0; i<array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// string [] array = {"hello", "2", "world", ":-)"};

// methodArray(array);
// Print(array);


string[] array = {"123", "23", "hello", "world", "res"};
string[] new_array = new string[array.Length];

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SecondArray(string[] array, string[] new_array)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(i <= 2)
        {
        new_array[j] = array[i];
        j++;
        }
    }
}


SecondArray(array, new_array);
PrintArray(new_array);