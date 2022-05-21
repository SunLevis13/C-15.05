// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Palindrome(int n)
{
    int i = 0;
    string num = n.ToString();
    int size = num.Length - 1;
    string flag = "yes";
    
    while (i < size / 2)
    {
        if (num[i] != num[size - i]) 
        {
            flag = "no";
            break;
        }        
        i += 1;
    }    
    Console.WriteLine($"{n} -> {flag}");
}

Palindrome(14212);
Palindrome(23432);
Palindrome(12821);
Palindrome(1248421);
Palindrome(12488421);