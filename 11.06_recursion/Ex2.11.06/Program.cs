// Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел,
// для которых каждое следующее равно сумме двух предыдущих. 

int Value (int num1, int num2, int n)
{
    if (n == 1) return num1;
    Console.Write ($"{num1} ");
    (num1,num2) = (num2,num2 + num1);
    return Value (num1,num2,n-1);
}
Console.WriteLine(Value(3,4,5));