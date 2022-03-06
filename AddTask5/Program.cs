Console.WriteLine("=======Дополнительная задача № 5=======");
Console.WriteLine(@"Дан массив средних температур (массив заполняется случайно) за последние 10 лет. На ввод подают номер месяца и год начали и конца.
Определить самые высокие и низкие температуры для лета, осени, зимы и весны в заданном промежутке. Если таких температур нет, сообщить, что определить не удалось.");
int[] FillArray()
{
    int[] temp = new int[120];
    for (int z = 0; z < temp.Length; z++)
    {
        temp[z] = new Random().Next(-20, 36);
    }
    return temp;
}
int[] GetTempOfSeason(DateTime start, DateTime finish, int[] temp)
{
    int[] tempResult = new int[8];
    for (int i = 0; i < tempResult.Length; i++)
    {
    tempResult[i] = -1000;
    }
    start = UpdateDate(start);
    finish = UpdateDate(finish);
    DateTime now = UpdateDate(DateTime.Now);
    int startIndex = 120 - MonthOffset(now, start) - 1;
    int finishIndex = 120 - MonthOffset(now, finish) - 1;
    for(int i = startIndex; i <= finishIndex; i++)
    {
        switch ((i + DateTime.Now.Month + 1) % 12)
        {
            case 0:
            case 1:
            case 2:
                if ((temp[i] < tempResult[0])| (tempResult[0] == -1000))
                {
                    tempResult[0] = temp[i];
                }
                if ((temp[i] > tempResult[1])| (tempResult[1] == -1000))
                {
                    tempResult[1] = temp[i];
                }
                break;
            case 3:
            case 4:
            case 5:
                if ((temp[i] < tempResult[2])| (tempResult[2] == -1000))
                {
                    tempResult[2] = temp[i];
                }
                if ((temp[i] > tempResult[3])| (tempResult[3] == -1000))
                {
                    tempResult[3] = temp[i];
                }                
                break;
            case 6:
            case 7:
            case 8:
                if ((temp[i] < tempResult[4])| (tempResult[4] == -1000))
                {
                    tempResult[4] = temp[i];
                }
                if ((temp[i] > tempResult[5])| (tempResult[5] == -1000))
                {
                    tempResult[5] = temp[i];
                }   
                break;
            case 9:
            case 10:
            case 11:
                if ((temp[i] < tempResult[6])| (tempResult[6] == -1000))
                {
                    tempResult[6] = temp[i];
                }
                if ((temp[i] > tempResult[7])| (tempResult[7] == -1000))
                {
                    tempResult[7] = temp[i];
                }   
                break;
        }
    }
    return tempResult;

}
int MonthOffset(DateTime end, DateTime start)
{
    end = UpdateDate(end);
    start = UpdateDate(start);
    return (end.Year - start.Year) * 12 + (end.Month - start.Month);
}
DateTime UpdateDate(DateTime date)
{
    return new DateTime(date.Year, date.Month, 1);
}
void TranslateResults (int[] temperature)
{
    if (temperature.Length != 8)
    {
        Console.WriteLine("Ошибка входных данных");
    }
    else
    {
        if (temperature[0] != -1000) 
            Console.WriteLine("Минимальная температура зимой за период: " + temperature[0]);
        else
            Console.WriteLine("Данные по минимальной температуре зимой за период отсутствуют");
        if (temperature[1] != -1000) 
            Console.WriteLine("Максимальная температура зимой за период: " + temperature[1]);
        else
            Console.WriteLine("Данные по максимальной температуре зимой за период отсутствуют");
        if (temperature[2] != -1000) 
            Console.WriteLine("Минимальная температура весной за период: " + temperature[2]);
        else
            Console.WriteLine("Данные по минимальной температуре весной за период отсутствуют");
        if (temperature[3] != -1000) 
            Console.WriteLine("Максимальная температура весной за период: " + temperature[3]);
        else
            Console.WriteLine("Данные по максимальной температуре весной за период отсутствуют");
        if (temperature[4] != -1000) 
            Console.WriteLine("Минимальная температура летом за период: " + temperature[4]);
        else
            Console.WriteLine("Данные по минимальной температуре летом за период отсутствуют");
        if (temperature[5] != -1000) 
            Console.WriteLine("Максимальная температура летом за период: " + temperature[5]);
        else
            Console.WriteLine("Данные по максимальной температуре летом за период отсутствуют");
        if (temperature[6] != -1000) 
            Console.WriteLine("Минимальная температура осенью за период: " + temperature[6]);
        else
            Console.WriteLine("Данные по минимальной температуре осенью за период отсутствуют");
        if (temperature[7] != -1000) 
            Console.WriteLine("Максимальная температура осенью за период: " + temperature[7]);
        else
            Console.WriteLine("Данные по максимальной температуре осенью за период отсутствуют");
    }
}
try
{
Console.Write("Введите дату начала периода: ");
DateTime startDate = Convert.ToDateTime(Console.ReadLine());
Console.Write("Введите дату конца периода: ");
DateTime endDate = Convert.ToDateTime(Console.ReadLine());
if ((endDate < startDate) | (startDate > DateTime.Now) | (endDate > DateTime.Now))
{
    Console.WriteLine("Ошибка ввода дат");
    System.Environment.Exit(-1);
}
else
{
    if ((MonthOffset(DateTime.Now, startDate) >= 120)|(MonthOffset(DateTime.Now, endDate) >= 120))
    {
        Console.WriteLine("Отсутствуют данные за данный период");
        System.Environment.Exit(-2);
    }
}
int[] temperature = FillArray();
int[] tempStat = new int[8];

tempStat = GetTempOfSeason(startDate, endDate, temperature);
foreach (int i in tempStat)
{
    Console.Write(i + " ");
}
Console.WriteLine();
TranslateResults(tempStat);
Console.WriteLine();
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
