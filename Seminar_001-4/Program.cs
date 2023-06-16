int number = new Random().Next(1,10);
Console.WriteLine(number);    
int count = 1;
while (count<=number) 
{
int result = count % 2;

if (result == 0)
{
Console.WriteLine(count);                    
}  
count++;                  
}