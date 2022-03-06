Console.WriteLine("=======Дополнительная задача №№ 2 и 4=======");
Console.WriteLine("Даны 4 точки a, b, c, d. Пересекаются ли вектора AB и CD? Если пересекаются, то найти четверть");
const int n = 100;
Dot2D Get2DRandomDot()
{
    Dot2D dot = new Dot2D();
    dot.X = new Random().Next(- 1 * n, n + 1);
    dot.Y = new Random().Next(- 1 * n, n + 1);
    return dot;
}
int GetQuater (DoubleDot2D dot)
{
    if ((dot.X == 0) & (dot.Y == 0)) return -1;
    if ((dot.X >= 0) & (dot.Y >= 0)) return 1;
    if ((dot.X < 0) & (dot.Y >= 0)) return 2;
    if ((dot.X < 0) & (dot.Y < 0)) return 3;
    if ((dot.X >= 0) & (dot.Y < 0)) return 4;
    return -2;

}
Line2D GetLine (Dot2D a, Dot2D b)
{
    Line2D line = new Line2D();
    line.A = a.Y - b.Y;
    line.B = b.X - a.X;
    line.C = a.X * b.Y - b.X * a.Y;
    return line;
}
DoubleDot2D LineIntersection(Line2D l1, Line2D l2)
{
    DoubleDot2D dot = new DoubleDot2D();
    dot.Y = Convert.ToDouble(l2.C * l1.A - l1.C * l2.A) / Convert.ToDouble(l1.B * l2.A - l2.B * l1.A);
    dot.X = Convert.ToDouble(l2.C * l1.B - l1.C * l2.B) / Convert.ToDouble(l1.A * l2.B - l1.B * l2.A);
    return dot;
}
bool IsInSegments (Dot2D[] dots, DoubleDot2D dot)
{
    int x1min;
    int x1max;
    int y1min;
    int y1max; 
    int x2min;
    int x2max;
    int y2min;
    int y2max;
    if (dots[0].X > dots[1].X)
    {
        x1max = dots[0].X;
        x1min = dots[1].X;
    } 
    else
    {
        x1min = dots[0].X;
        x1max = dots[1].X;  
    }
    if (dots[0].Y > dots[1].Y)
    {
        y1max = dots[0].Y;
        y1min = dots[1].Y;
    } 
    else
    {
        y1min = dots[0].Y;
        y1max = dots[1].Y;  
    }
    if (dots[2].X > dots[3].X)
    {
        x2max = dots[2].X;
        x2min = dots[3].X;
    } 
    else
    {
        x2min = dots[2].X;
        x2max = dots[3].X;  
    }
    if (dots[2].Y > dots[3].Y)
    {
        y2max = dots[2].Y;
        y2min = dots[3].Y;
    } 
    else
    {
        y2min = dots[2].Y;
        y2max = dots[3].Y;  
    }

    if (
        (dot.X >= x1min) & 
        (dot.X >= x2min) &
        (dot.X <= x1max) &
        (dot.X <= x2max) &
        (dot.Y >= y1min) & 
        (dot.Y >= y2min) &
        (dot.Y <= y1max) &
        (dot.Y <= y2max)
        )
    {
        return true;
    }
    else
    {
        return false;
    }
}


Dot2D[] dots = new Dot2D[4];
for (int i = 0; i < dots.Length; i++)
{
    Console.Write("Генерируются координаты " + i + " точки... ");
    dots[i] = Get2DRandomDot();
    Console.WriteLine("{0}; {1}",dots[i].X, dots[i].Y);
}
/*
dots[0].X = 0; 
dots[0].Y = 0; 
dots[1].X = 0; 
dots[1].Y = 1; 
dots[2].X = -1; 
dots[2].Y = 0; 
dots[3].X = 2; 
dots[3].Y = 0; 
*/
Line2D[] lines = new Line2D[2];
lines[0] = GetLine (dots[0], dots[1]);
lines[1] = GetLine (dots[2], dots[3]);
DoubleDot2D ddot = LineIntersection(lines[0], lines[1]);
if (IsInSegments(dots, ddot))
{
    int quater = GetQuater(ddot);
    if (quater == -1)
    {
        Console.WriteLine ("Пересечение в начале координат");
    }
    else
    {
        if (quater > 0)
        Console.WriteLine("Точка пересечения в " + quater + "-й четверти");
        else
        Console.WriteLine("Отрезки не пересекаются");
    }
}
else
{
    Console.WriteLine("Отрезки не пересекаются");
}
struct Dot2D
{
    public int X {get; set;}
    public int Y {get; set;}
}
struct DoubleDot2D
{
    public double X {get; set;}
    public double Y {get; set;}
}
struct Line2D
{
    public int A {get; set;}
    public int B {get; set;}
    public int C {get; set;}
}