// Вывод на экран квадратов чисел от 1 до N. 

void PrintSquears(int limit)
{
    int i = 1;
    while (i <= limit)
    {
        Console.Write($"{i * i} ");
        i++;
    }
}

PrintSquears(5);
PrintSquears(10);
PrintSquears(15);