int number1 = new Random().Next(1,10);
int number2 = new Random().Next(1,10);
int number3 = new Random().Next(1,10);
int max = 0;
Console.WriteLine(number1);
Console.WriteLine(number2);
Console.WriteLine(number3);
if(number1>number2)
{
max = number1;
}
else
{
max = number2;
}
if (max>number3)
{
Console.WriteLine(max);
}
else 
{
Console.WriteLine(number3);
}
