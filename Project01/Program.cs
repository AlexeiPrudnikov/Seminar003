Console.WriteLine("=======Задача № 19=======");
Console.WriteLine("Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом");

bool IsPolindromicNumber(int number)
{
    number = Math.Abs(number);
    string numStr = number.ToString();
    for (int i = 0; i < (numStr.Length / 2); i++)
    {
        if (numStr[i] != numStr[numStr.Length - i - 1])
        {
            return false;
        }
    }
    return true;
}
try
{
    Console.Write("Введите пятизначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (((number >= 10000) & (number <= 99999))|((number <= -10000) & (number >= -99999)))
    {
        Console.Write("Число " + number);
        if (!IsPolindromicNumber(number)) Console.Write(" НЕ");
        Console.Write(" является полиндромом.");
    }
    else
    {
        Console.WriteLine("Число не является пятизначным.");
    }
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}