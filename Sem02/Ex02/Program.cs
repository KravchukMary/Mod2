﻿
Console.Clear();
int count = 10;
int[] array = new int [count];
int find = new Random().Next(1, 21);
int index = 0;
Console.Write("Ищем = ");
Console.WriteLine(find);
Console.WriteLine("Массив: ");


while (index < count)
{
    array[index] = new Random().Next(1, 101);
    Console.WriteLine(array[index] + " ");
    index += 1;
}

index = 0;

while (index < count)
{
    if (array[index] == find)
    {
        Console.WriteLine("\nТакой элемент есть");
    }
    index += 1;
}

Console.WriteLine("\nEND");