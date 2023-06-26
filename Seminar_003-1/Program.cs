// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число");
int n = int.Parse(Console.ReadLine()!);
int [] array = {0,0,0,0,0};
int result = n;
int i = 0;
while (result>0)
{
                        int res = result%10;
                        array[i] = res;
                        result = result/10;
                        i++;
}
if (array[0]==array[4] && array[1]==array[3])
                        Console.WriteLine("Это палиндром");
else 
                        Console.WriteLine("Это НЕ палиндром");