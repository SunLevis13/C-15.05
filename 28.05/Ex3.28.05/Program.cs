// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
void Someting(int num){
    string i = "";
    while (num>0)
    {
        i = num%2+i;
        num = num/2;
    }
    Console.Write(i);
}
Someting(23);