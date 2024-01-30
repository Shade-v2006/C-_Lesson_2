// Нахождение максимального числа в массиве - Finding the maximum number in the array
int n = 5;
int[] array = { 12, 4, 17, 3, 9 };
int i = 0;
int max = array[0];

while (i < array.Length)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i++;
}
Console.WriteLine(max);

// second example с использованием for

max = array[0];
for (int j = 0; j < n; j++)
{
    if (array[j] > max)
    {
        max = array[j];
    }
}
Console.WriteLine(max);

// the third example - третий пример с использованием foreach
max = array[0];
foreach (int e in array)
{
    if (e > max)
    {
        max = e;
    }
}
Console.WriteLine(max);