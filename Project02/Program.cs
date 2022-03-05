Console.WriteLine("=======Задача № 21=======");
Console.WriteLine("Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве");
const int n = 100;
Dot3D Get3DRandomDot()
{
    Dot3D dot = new Dot3D();
    dot.X = new Random().Next(- 1 * n, n + 1);
    dot.Y = new Random().Next(- 1 * n, n + 1);
    dot.Z = new Random().Next(- 1 * n, n + 1);
    return dot;
}
double Get3DDistance(Dot3D a, Dot3D b)
{
    return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2) + Math.Pow(a.Z - b.Z, 2));
}
try
{
    Dot3D[] dots = new Dot3D[2];
    for (int i = 0; i < dots.Length; i++)
    {
        Console.Write("Генерируются координаты " + i + " точки... ");
        dots[i] = Get3DRandomDot();
        Console.WriteLine("{0}; {1}; {2}",dots[i].X, dots[i].Y, dots[i].Z);
    }
    Console.WriteLine ("Рассояние между точками равно " + Get3DDistance(dots[0], dots[1]));
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

struct Dot3D
{
    public int X {get; set;}
    public int Y {get; set;}
    public int Z {get; set;}
}