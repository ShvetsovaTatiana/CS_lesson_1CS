// Считать с консоли строку, состоящую из цифр и латинских букв. Сформировать массив, состоящий из цифр этой строки.
// Пример
// abc123def06g => [1, 2, 3, 0, 6]
// Рекомендации
// • Разделить логику алгоритма на функции
// • Память под массив выделять необходимого размера (не больше, чем количество элементов)

string GetSymbolsFromString(string str)
{
    string symbols = "";
    foreach (char e in str)
    {
        if (char.IsDigit(e) == true)
        {
            symbols = symbols + e;
        }
    }
    return symbols;
}

int CalculateNumberOfDigit(string str)
{
    int count = 0;
    foreach (char e in str)
    {
        if (char.IsDigit(e) == true)
        {
            count += 1;
        }
    }
    return count;
}

int[] CreateArray(string digits)
{
    int cnt = CalculateNumberOfDigit(digits);
    int[] array = new int[cnt];
    int num = Convert.ToInt32(digits);
    for (int i = 0; i < array.Length; i++)
    {
        array[array.Length - i - 1] = num % 10;
        num = num / 10;
    }
    return array;
}

void PrintArray(int[] array)
{
    //  вывод будет в скобках массива
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.WriteLine("]");
}

Console.WriteLine("Введите строку из цифр и латинских букв: ");
string str = Console.ReadLine();
string digits = GetSymbolsFromString(str);


int[] DigitsArray = CreateArray(digits);
PrintArray(DigitsArray);