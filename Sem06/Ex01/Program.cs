// Задача 60.
// Составить частотный словарь элементов двумерного массива.


int [] arr = {0, 1, 1, 6, 7, 8, 3, 3, 4, 4, 5, 5, 6, 7, 8, 9, 3, 3, 1, };
int[] count = new int[arr.Max() + 1];

for(int i = 0; i < arr.Length; i++) count[arr[i]]++;

for(int i = 0; i < count.Length; i++);
{
    if (count[i] ≠ 0)
    {
    Console.WriteLine(${i} встречается {count[i]}p);
    }
}