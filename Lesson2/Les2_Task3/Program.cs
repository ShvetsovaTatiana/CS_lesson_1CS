﻿int n = 10;
int[] array = { 2, 5, 4, 7, 8, 35, 1, 3, 8, 5 };
int i = 0;

while (i < n) //если писать arr.length вместо n, то строку 1 можно не писать или закомменитровать
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i = i + 1;
}