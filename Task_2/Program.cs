int n = 10;
int[] arr = new int[n]; //Создание массива с неизвестным количеством элементов
int i = 0;

while (i < arr.Length) // arr.Length - подразумевает кол-во элементов выделенных под массив (аналог i<n)
{
    arr[i] = i + 1;
    // Console.Write(arr[i]);
    // Console.Write(" ");
    Console.Write($"{arr[i]} "); // В место 8 и 9 строки можно сделать так
    i++;

}
