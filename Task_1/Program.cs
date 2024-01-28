/*
 Работа с массивами в С#
*/

int[] arr = new int[5]; // после данной операции будет создан массив на 5 чисел
arr[0] = 5;  // обращаемся к массиву
arr[1] = 7;
arr[2] = 5;
arr[3] = 4;
arr[4] = 3;

Console.WriteLine(arr[0]);
Console.WriteLine(arr[1]);
Console.WriteLine(arr[2]);
Console.WriteLine(arr[3]);
Console.WriteLine(arr[4]);
// Console.WriteLine(arr[5]); // Ошибка - Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.

int[] arr2 = new int[5] { 1, 2, 3, 4, 5 }; // сразу заполняем массив
int[] arr3 = { 1, 2, 3, 4, 5 }; // можем не фиксироватьмассив так как известно число элементов

