
string[] array = {"hello", "2", "world", ":-)"};
string[] new_array = new string[array.Length];

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void NewArray(string[] array, string[] new_array)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        new_array[j] = array[i];
        j++;
        }
    }
   
}
Console.WriteLine();

NewArray(array, new_array);
PrintArray(new_array);