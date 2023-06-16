int number = new Random().Next(1,10);
Console.WriteLine(number);
int result = number % 2;

if (result == 0)
{
Console.WriteLine("число четное");
}
else
{
Console.WriteLine("число нечетное");                
}