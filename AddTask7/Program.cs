Console.WriteLine("=======Дополнительная задача № 7=======");
Console.WriteLine("Из центра координат к точке А(x, y) проведён отрезок АО. Напишите программу, определяющую наименьший угол наклона отрезка AO к оси X");
const int n = 100;
Dot2D Get2DRandomDot()
{
    Dot2D dot = new Dot2D();
    dot.X = new Random().Next(- 1 * n, n + 1);
    dot.Y = new Random().Next(- 1 * n, n + 1);
    return dot;
}
int GetQuater (Dot2D dot)
{
    if ((dot.X == 0) & (dot.Y == 0)) return -1;
    if ((dot.X >= 0) & (dot.Y >= 0)) return 1;
    if ((dot.X < 0) & (dot.Y >= 0)) return 2;
    if ((dot.X < 0) & (dot.Y < 0)) return 3;
    if ((dot.X >= 0) & (dot.Y < 0)) return 4;
    return -2;

}
double GetMinAngle (Dot2D dot)
{
    int quater = GetQuater(dot);
    if (quater < 0) return -1;
    double angle;
    angle = Math.Atan2(dot.Y, dot.X) * 180 / Math.PI;
    switch (quater)
    {
        case 1:
            return angle;
        case 2:
            return 180 - angle;
        case 3:
            return 180 + angle;
        case 4:
            return -1 * angle;
    }
    return angle;
}
try
{
Dot2D a = new Dot2D();
Console.Write("Генерируются координаты точки... ");
a = Get2DRandomDot();
Console.WriteLine("{0}; {1}",a.X, a.Y);
if (a.X == 0 & a.Y == 0)
{
    Console.WriteLine("Точка совпадает с началом координат");
}
else
{
    Console.WriteLine(GetMinAngle(a));
}

}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
struct Dot2D
{
    public int X {get; set;}
    public int Y {get; set;}
}