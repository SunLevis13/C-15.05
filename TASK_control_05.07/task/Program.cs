// string[] array = {"hello", "2", "world", ":-)"};
// string[] new_array = new string[array.Length];
void NewArray(string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Console.Write($"{array[i]} ");
        }
    }
}

void PrintArray(string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"new array is ");
    }
    
}


string [] array_1 = {"hello", "2", "world", ":-)"};
NewArray(array_1);
PrintArray(array_1);
