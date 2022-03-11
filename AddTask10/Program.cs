Console.WriteLine("=======Дополнительная задача № 10=======");
Console.WriteLine("Дана игра со следующими правилами. Первый игрок называет любое натуральное число от 2 до 9, второй умножает его на любое натуральное число от 2 до 9, первый умножает результат на любое натуральное число от 2 до 9 и т. д. Выигрывает тот, у кого впервые получится число больше 1000. Запрограммировать консольный вариант игры");
int GetNum (int i)
{
    Console.Write("Игрок " + i + " введите число от 2 до 9: ");
    int num;
    do
    {
        num = Convert.ToInt32(Console.ReadLine());
        if ((num < 2) | (num > 9))
        {
            Console.Write("Ошибка ввода, введите число от 2 до 9: ");
        }
    }
    while ((num < 2) | (num > 9));
    return num;
}
try
{
    bool first = false;
    int sum;
    sum = GetNum(1);
    int playerNum = 1;
    do
    {
        if (first) playerNum = 1; else playerNum = 2;
        sum *= GetNum(playerNum);
        if (sum > 1000)
        {
        Console.WriteLine("Победа!!!! Итоговая сумма - " + sum);
        Console.WriteLine("Победил " + playerNum + " игрок");
        }
        else
        {
        Console.WriteLine("Промежуточное значение - " + sum);
        }
        first = !(first);
    }
    while (sum < 1000);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}