Console.WriteLine("=======Дополнительная задача № 6=======");
Console.WriteLine("На вход подаётся число n > 4, указывающее длину пароля. Создайте метод, генерирующий пароль заданной длины. В пароле обязательно использовать цифру, букву и специальный знак");
Console.Write("Введите длину пароля (минимум 5 символов):");
string GetPassword(int passLength)
{
    bool num = false;
    bool ch = false;
    bool spechial = false;
    char[] password = new char[passLength];
    int symb = 0;
    do
    {
        num = false;
        ch = false;
        spechial = false;
        for (int i = 0; i < passLength; i++)
        {
            symb = new Random().Next(33, 127);
            password[i] = Convert.ToChar(symb);
            if ((symb >= 48) & (symb <=57)) 
            {
                num = true;
            }
            else
            {
                if (((symb >= 65) & (symb <=90)) | ((symb >= 65) & (symb <=90))) 
                {
                    ch = true;
                }
                else
                {
                    spechial = true;
                }
            }
        }       
    }
    while (!num | !ch | !spechial);
    return new string(password);
}
try
{
    int passLength = Convert.ToInt32(Console.ReadLine());
    if (passLength > 4)
    {
        char[] character = new char[94];
        string password = GetPassword(passLength);
        Console.WriteLine(password);
    }
    else
    {
        Console.WriteLine("Длина пароля слишком маленькая");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}