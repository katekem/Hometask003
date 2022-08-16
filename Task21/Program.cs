//Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();

Console.Write("Координаты Ax: ");
int Ax = int.Parse(Console.ReadLine());
Console.Write("Координаты Ay: ");
int Ay = int.Parse(Console.ReadLine());
Console.Write("Координаты Az: ");
int Az = int.Parse(Console.ReadLine());

Console.Write("Координаты Bx: ");
int Bx = int.Parse(Console.ReadLine());
Console.Write("Координаты By: ");
int By = int.Parse(Console.ReadLine());
Console.Write("Координаты Bz: ");
int Bz = int.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(Ax-Bx,2) + Math.Pow(Ay-By,2) + Math.Pow(Az-Bz,2));

Console.WriteLine($"d={d:f2}");