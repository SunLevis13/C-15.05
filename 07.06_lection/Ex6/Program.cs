﻿// В некотором машинном алфавите имеются четыре
//буквы «а», «и», «с» и «в». Покажите все слова,
//состоящие из T букв, которые можно построить из букв
//этого алфавита

// char[] s = { 'а', 'и', 'с','в'};
// int count = s.Length;
// int n = 1;
// for (int i = 0; i < count; i++) // если нужно слово из 1 буквы
// {
//  for (int j = 0; j < count; j++) // если нужно слово из 2 букв
//  {
//  for (int k = 0; k < count; k++) // если нужно слово из 3 букв
//  {
//  for (int l = 0; l < count; l++) // если нужно слово из 4 букв
//  {
//  for (int m = 0; m < count; m++) // если нужно слово из 5 букв ....
//  // и т.д. если увеличиваем количество букв в слове, для каждой буквы пишем новую переменную и счетчик
//  {
//  Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}{s[m]}");
//  }
//  }
//  }
//  } 
// }

// способ Рекурсии
int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
    {
       if (length == word.Length)
       {
           Console.WriteLine($"{n++} {new String(word)}");  return;
       }

       for (int i = 0; i < alphabet.Length; i++)
       {
           word[length] = alphabet[i];
           FindWords(alphabet, word, length + 1);
       }
   }
FindWords("аисв", new char[5]);