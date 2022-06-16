// Демонстрация парсинга входной строки

// using System.Linq;

// string text = "(1,2) (2,3) (4,5) (6,7)" // задаем координаты каких то точек
//         .Replace ("(", "") // убираем скобки
//         .Replace (")", "")
//         ;
// Console.WriteLine (text);

// var data = text.Split (" ") // задаем разделитель, в качестве разделителя пробел
//         .Select (item => item.Split (',')) // выбрать элементы для которых надо будет новое разбиение через запятую
//         .Select (e => (x: int.Parse (e[0]), y: int.Parse (e[1]))) // сделать выборку из текущего массива такого, что 1ая координата X
//         //будет взята как 1ый эл-т массива и сразу превращена в число. И то же самое со 2ой Y
//         .ToArray(); // вывод в массив

// for (int i=0; i < data.Length; i++)
// {
// 		Console.WriteLine (data[i].x*10 ); // вывод точка массива с координатой х умноженной на 10 
//         // Console.WriteLine (data[i].Item1*10); То же самое если без использования x и y
// }

using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)" 
        .Replace ("(", "") 
        .Replace (")", "")
        ;
Console.WriteLine (text);

var data = text.Split (" ") 
        .Select (item => item.Split (',')) 
        .Select (e => (x: int.Parse (e[0]), y: int.Parse (e[1]))) 
        .Where (e => e.x % 2 == 0) // условие: первая координата - четная
        .Select (point => (point.x * 10, point.y)) // первая координата умножается на 10
        .ToArray(); 

for (int i=0; i < data.Length; i++)
{
		Console.WriteLine (data[i]);
}