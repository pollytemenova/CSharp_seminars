// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координаты первой точки через запятую");
string a = Console.ReadLine();
Console.WriteLine("Введите координаты второй точки через запятую");
string b = Console.ReadLine();
string [] arrayOne = a.Split(",");
string [] arrayTwo = b.Split(",");
int x1 = int.Parse(arrayOne[0]);
int y1 = int.Parse(arrayOne[1]);
int z1 = int.Parse(arrayOne[2]);
int x2 = int.Parse(arrayTwo[0]);
int y2 = int.Parse(arrayTwo[1]);
int z2 = int.Parse(arrayTwo[2]);
double distance = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
Console.WriteLine(distance);