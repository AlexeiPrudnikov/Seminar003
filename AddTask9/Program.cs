Console.WriteLine("=======Дополнительная задача № 9=======");
Console.WriteLine("Напишите программу, который выводит на консоль таблицу умножения от 1 до n, где n задаётся случайно от 2 до 100");
Console.Write("Введите число от 2 до 100: ");
void GetMultTable (int n)
{
    for (int i = 0; i <= n; i++)
    {
        Console.Write( i + " \t");
    }
    Console.WriteLine();

    for (int i = 1; i <= n; i++)
    {
        Console.Write( i + " \t");
        for (int j = 1; j <= n; j++)
        {
            
            Console.Write( i * j + " \t");
        }
        Console.WriteLine();
    }

}
try
{
    int n = Convert.ToInt32(Console.ReadLine());
    if ((n >= 2) & (n <= 100))
    {
        GetMultTable(n);
    }
    else
    {
        Console.WriteLine("Ошибка ввода, число должно быть от 2 до 100");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}