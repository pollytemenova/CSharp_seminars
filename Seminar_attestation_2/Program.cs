//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int sum=0;
int Sum(int n, int m)
{
if(n>m)
{
                        while (m<=n)
                        {
sum = sum+m;
m++;
                        }
}
else while (n<=m)
{
                        sum = sum+n;
                        n++;
}
return 1;
}
Sum(8, 4);
Console.WriteLine(sum);