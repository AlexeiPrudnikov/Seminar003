const int max = 11;
void PrintList (List<int>[] list)
{
    for (int i = 0; i < list.Length; i++)
    {
        foreach (int num in list[i])
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
int[] FillArray (int n)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = i;
    }
    return array;
}
void GetOptimalWay (Dot[] dots, List<int>[] ways)
{
    int wayNum = 0;
    double min = 0;
    double wayLength = 0;
    Dot o = new Dot();
    o.X = 0;
    o.Y = 0;
    for (int i = 0; i < ways.Length; i++)
    {
        wayLength = 0;

        for (int j = 0; j < ways[i].Count - 1; j++)
        {
            if (j == 0)
            {
                wayLength = GetLenght(o, dots[ways[i][j]]);
            }
            if (ways[i].Count > 1)
            {
                wayLength += GetLenght(dots[ways[i][j]], dots[ways[i][j + 1]]);
            }
        }
        if (i == 0)
        {
            wayNum = i;
            min = wayLength;
        }
        else
        {
            if (wayLength < min)
            {
                wayNum = i;
                min = wayLength;  
            }
        }
        Console.WriteLine("Маршрут " + i + ". Его длина -> " + wayLength);
    }
    Console.WriteLine ("Оптимальный маршрут " + wayNum);
    Console.WriteLine ("Его длина " + min);

}
Dot GetDotCoordinate(int ch)
{
    Dot dot = new Dot();
    switch(ch)
    {
        
        case 1:
            dot.X = new Random().Next(max);
            dot.Y = new Random().Next(max);
            break;
        case 2:
            dot.X = -1 * (new Random().Next(max));
            dot.Y = new Random().Next(max);
            break;
        case 3:
            dot.X = -1 * (new Random().Next(max));
            dot.Y = -1 * (new Random().Next(max));
            break;
        case 4:
            dot.X = new Random().Next(max);
            dot.Y = -1 * (new Random().Next(max));
            break;

    }
    return dot;
}
double GetLenght (Dot a, Dot b)
{
    return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
}

List<int>[] GetPer (List<int>[] array, int num)
{
    List<int>[] result = new List<int>[array.Length * (array[0].Count + 1)];
    int j = 0;
    for (int k = 0; k < array.Length; k++)
    {
        for (int i = 0; i <= array[k].Count; i++)
        {
            List<int> temp = new List<int>(array[k]);
            temp.Insert(i, num);
            result[j] = temp; 
            j++;
        }
    }
    return result;
}
List<int>[]resultArray = new List<int>[1];
List<int> temp = new List<int>();

try
{
    Console.WriteLine("=======Дополнительная задача № 1-3=======");
    Console.WriteLine("На ввод подаётся номер четверти. Создаются N случайных точек в этой четверти. Определите самый оптимальный маршрут для торгового менеджера, который выезжает из центра координат.");

    Console.Write("Введите количество точек: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер четверти: ");
    int chNum = Convert.ToInt32(Console.ReadLine());
    if (n <= 1) 
    {
        Console.WriteLine("Количество точек должно быть положительным.");
        System.Environment.Exit(-1);
    }
    if ((chNum < 1) | (chNum > 4))
    {
        Console.WriteLine("Такого номера четверти не существует.");
        System.Environment.Exit(-1);
    }
    int [] array = FillArray(n);
    temp.Add(array[0]);
    resultArray[0] = temp;
    for (int i = 1; i < array.Length; i++)
    {
        resultArray = GetPer(resultArray, array[i]);    
        Console.WriteLine(resultArray.Length);
    }


    Dot[] dots = new Dot[n];
    for (int i = 0; i < dots.Length; i++)
    {
        Console.Write("Генерируются координаты " + i + " точки... ");
        dots[i] = GetDotCoordinate(chNum);
        Console.WriteLine("{0}; {1}",dots[i].X, dots[i].Y);
    }
    Console.WriteLine("Генерируются пути...");
    PrintList(resultArray);
    Console.WriteLine();
    GetOptimalWay(dots, resultArray);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

public struct Dot
{
    public int X {get; set;}
    public int Y{get; set;}
}