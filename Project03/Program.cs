Console.WriteLine("=======Задача № 23=======");
Console.WriteLine("Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N");
void GetCube (int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine ("{0} \t {1}", i, Math.Pow(i, 3));
    }
}
try
{
Console.Write ("Введите полодительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    GetCube(number);
}
else
{
    Console.WriteLine("Ошибка, число должно быть положительным.");
}
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}