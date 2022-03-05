Console.WriteLine("=======Дополнительная задача № 8=======");
Console.WriteLine("Массив из ста элементов заполняется случайными числами от 1 до 100. Удалить из массива все элементы, содержащие число 3. Вывести в консоль новый массив и количество удалённых элементов.");
const int count = 100;
const int range = 100;
List<int> FillArray (int n)
{
    List<int> array = new List<int>();
    for (int i = 0; i < n; i++)
    {
        array.Add(new Random().Next(-1 * range, range + 1));
    }
    return array;
}
List<int> GetArrayWithout3(List<int> array)
{
    List<int> newArray = new List<int>();
    foreach (int num in array)
    {
        if (!IsContain3(num))
        {
            newArray.Add(num);
        }
    }
    return newArray;
}
bool IsContain3 (int num)
{
    string numStr = num.ToString();
    return numStr.Contains('3');

}
void PrintArray(List<int> array)
{
    foreach(int num in array)
    {
        Console.Write (num + " ");
    }
    Console.WriteLine();
}
List <int> array = new List<int>();
array = FillArray(count);
Console.WriteLine();
Console.WriteLine("Исходный массив:");
PrintArray(array);
List <int> newArray = new List<int>();
Console.WriteLine("Новый массив:");
newArray = GetArrayWithout3(array);
Console.WriteLine("Длина нового массива - {0}", newArray.Count);
PrintArray(newArray);
