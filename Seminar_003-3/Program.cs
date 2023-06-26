// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
int count = 1;
while(count<=n)
{
                        Console.WriteLine($"{count} в кубе = {count*count*count}");
                        count++;
}