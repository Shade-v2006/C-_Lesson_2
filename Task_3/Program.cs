// Нахождение четных элементов массива

//int n = 10;
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

// Второй пример - the second example

int[] array2 = { 9, 5, 1, 7, 15, 36, 3, 1, 1, 7 };
i = 0;
while (i < array2.Length)
{
    if (array2[i] % 2 == 0)
    {
        Console.WriteLine();
        Console.Write($"{array2[i]} ");
    }
    i++;
}
