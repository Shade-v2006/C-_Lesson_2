﻿//int n = 10;
int[] array = { 2, 5, 4, 7, 8, 3, 23, 14, 34, 6 };
int i = 0;

while (i < array.Length)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i++;
}