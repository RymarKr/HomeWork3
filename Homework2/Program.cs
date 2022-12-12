// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Пожалуйста, введите координаты 2-х точек. Сначала Координаты 1-ой точки Ax, Ay и Az");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Теперь Координаты 2-ой точки Bx, By и Bz");
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());

double num(double x1, double x2, 
           double y1, double y2, 
           double z1, double z2)
{
  return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
}
double segmentLength =  Math.Round (num(x1, x2, y1, y2, z1, z2), 2 );
Console.WriteLine($"Длина отрезка  {segmentLength}");