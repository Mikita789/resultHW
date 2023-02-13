// функция печати элементов массива
void PrintArr<T>(T[] arr)
{
    Console.Write("Cгенерированный массив: ");
    foreach (T i in arr)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}


Console.WriteLine("Введите строку содержащую элементы массива: ");
string strElements = Console.ReadLine();

//функция поиска элементов длинной больше заданного числа
string[] LenSubString(int len, string str)
{
    string[] s = str.Split(' ');
    if (s.Length == 0)
    {
        string[] res = new string[0];
        return res;
    }
    else
    {
        string result = "";
        foreach (string item in s)
        {
            if (item.Length >= len)
            {
                result += item + " ";
            }
        }
        string[] resultArr = result.Split(' ');
        return resultArr;
    }
}

string[]resultArr = LenSubString(3, strElements);
PrintArr(resultArr);

//вариант 2
string[] LenSubString2(int len, string str)
{
    string[] itemsArr = str.Split(' ');
    string[] resultArr = itemsArr.Where(substring => substring.Length >= 3).ToArray();
    return resultArr;
}

Console.WriteLine();
string[]resultArr2 = LenSubString2(3, strElements);
PrintArr(resultArr2);