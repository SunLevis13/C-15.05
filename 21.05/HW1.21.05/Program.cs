// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//void DegreeNum(int num1, int num2)
//{
  // Console.WriteLine(Math.Pow(num1, num2));
//}

//DegreeNum(3,3);

double DegreeNum(int num1, int num2)
{
   return Math.Pow(num1, num2);
}

Console.WriteLine(DegreeNum(3,3));