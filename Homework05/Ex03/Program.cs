// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] array = { 3, 7, 22, 2, 78 };

double count = 0;
double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
count = max - min;

Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Минимальное число = {min}");
Console.WriteLine($"Максимальное число = {max}");
Console.WriteLine($"Разница между максимальным и минимальным элементом = {count}");

