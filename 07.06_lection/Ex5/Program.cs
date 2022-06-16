// Факториал числа

// обычный метод
int PowerFor(int a, int n)
{ int result = 1;
 for (int i = 1; i <= n; i++) result *= a;
 return result;
}

// метод Рекурсии
int PowerRec(int a, int n)
{ //return n == 0 ? 1 : PowerRec(a, n - 1) * a; // можно записать одной строкой
 if (n == 0) return 1;
 else return PowerRec(a, n - 1) * a;
}

Console.WriteLine(PowerFor(2, 10)); // 1024
Console.WriteLine(PowerRec(2, 10)); // 1024

// 3ий способ с испльзованием формул и рекурсии
int PowerRecMath(int a, int n)
{
 if (n == 0) return 1;
 else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
 else return PowerRecMath(a, n - 1) * a;
}

Console.WriteLine(PowerRecMath(2, 10)); // 1024