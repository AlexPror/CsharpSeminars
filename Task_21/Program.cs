/* Задача 21: Напишите программу, которая
принимает на вход координаты двух точек и
находит расстояние между ними в 2D
пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/
Console.WriteLine("Введите координаты точек");
Console.Write("Xa: "); 
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Ya: "); 
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Xb: "); 
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Yb: "); 
int yb = Convert.ToInt32(Console.ReadLine());

double Length (int x1, int y1, int x2, int y2)
{
    double num = Math.Abs (Math.Sqrt(Math.Pow((x2-x1), 2)) - (Math.Pow((y2-y1), 2)));
    return num;
}
double length = Length (xb, xa, yb, ya);
Console.WriteLine(length); 
