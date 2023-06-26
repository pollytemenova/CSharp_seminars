// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
int count = 1;
while(count<=n)
{
                        Console.WriteLine($"{count} в кубе = {count*count*count}");
                        count++;
}