// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

var list = new List<int>();
int Number(int n)
{
list.Add(n);
if(n == 1) return 1;
else return Number(n-1); 
}
Number(8);
Console.WriteLine(String.Join(",", list));
