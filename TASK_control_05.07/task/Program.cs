//Написать программу, которая из имеющегося массива строк формирует массив из строк,
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
//либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// void NewArray(string[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i].Length <= 3)
//         {
//             Console.Write($"{array[i]} ");
//         }

//     }
// }

// void PrintArray(string[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write("New array is: ");
//         break;
//     }
// }

// string[] array_1 = { "hello", "2", "world", ":-)" };
// PrintArray(array_1);
// NewArray(array_1);
// Console.WriteLine();

// string[] array_2 = { "1234", "1567", "-2", "computer science" };
// PrintArray(array_2);
// NewArray(array_2);
// Console.WriteLine();

// string[] array_3 = { "Russia", "Denmark", "Kazan" };
// PrintArray(array_3);
// NewArray(array_3);

void NewArray(string[] array)
{
    string[] newarray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarray[i] = array[i];
        }
        Console.Write($"{newarray[i]} ");
    }

}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("New Array =");
        break;
    }

}

string[] array_1 = { "hello", "2", "world", ":-)" };
PrintArray(array_1);
NewArray(array_1);
Console.WriteLine();

string[] array_2 = { "1234", "1567", "-2", "computer science" };
PrintArray(array_2);
NewArray(array_2);
Console.WriteLine();

string[] array_3 = { "Russia", "Denmark", "Kazan" };
PrintArray(array_3);
NewArray(array_3);
