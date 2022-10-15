string[] GetArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите строку {i+1}");
        array[i] = Console.ReadLine();
    } 
    return array;   
}

string[] NMarkArray (int n, string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n)
        {
            count++;
        }
    }

    string [] resultArray = new string [count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n)
        {
            resultArray[j] = array[i];
            j++;
        }  
    }
    return resultArray;
}

Console.WriteLine("Введите число строк в массиве:");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = GetArray(size);

Console.WriteLine();

string[] resultArray = NMarkArray(3, array);
Console.WriteLine("Получен следующий массив:");
for (int i = 0; i < resultArray.Length; i++)
{
    Console.WriteLine(resultArray[i]);
}
