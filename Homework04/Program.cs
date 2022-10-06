// Есть магазин "Еда"
// В магазине есть охранник
// Охранник ведёт запись всех, кто заходит в магазин
// Охранник ведёт запись всех, кто выходит из магазин

// Зайти и выйти можно в целый час.

// Выяснить в какой промежуток времени было больше всего
// посетителей

// Данные вводятся парами: приход-уход
// Максимум 100 покупателей

// Входные данные
// 10-12
// 11-13
// 9-12

// Ответ
// 11-12


int ReedData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int[] CreateArray(int size)
{
    return new int[size];
}

void Fill(int[] array, int poc)
{
    for (var i = 0; i < array.Length; i++)
        array[i] = poc++;
}

void PrintArray(int[] array)
{
    int i = 0;
    int size = array.Length;
    while (i < size)
    {
        Console.Write(array[i] + " ");
        i++;
    }
    Console.WriteLine();
}

int[] FindOverlap(int[] array1, int[] array2, int[] array3)
{
    int count = 0;
    int[] overLap = new int[1];
    for (int i1 = 0; i1 < array1.Length; i1++)
    {
        for (int i2 = 0; i2 < array2.Length; i2++)
        {
            if (array1[i1] == array2[i2])
            {
                for (int i3 = 0; i3 < array3.Length; i3++)
                {
                    if (array2[i2] == array3[i3])
                    {
                        count = array3[i3];  
                        for (int index = 0; index < 1; index++)
                        {
                            overLap[index] = count;
                        }
                        for (int index = 0; index < 1; index++)
                        {
                            //Console.WriteLine(overLap[index]); Если запустить код без метода, то выводится интервал времени 11-12
                        }
                    }
                }
            }
        }
    }
    return overLap;
}


void PrintData(string prefix, string value)
{
    Console.Write(prefix + value);
}


int EnterMagazin1 = ReedData("Введите час входа в магазин 1го массива ");
int ExitMagazin1 = ReedData("Введите час выхода из магазина 1го массива ");
int EnterMagazin2 = ReedData("Введите час входа в магазин 2го массива ");
int ExitMagazin2 = ReedData("Введите час выхода из магазина 2го массива ");
int EnterMagazin3 = ReedData("Введите час входа в магазин 3го массива ");
int ExitMagazin3 = ReedData("Введите час выхода из магазина 3го массива ");


int countHours1 = ExitMagazin1 - EnterMagazin1 + 1; 
int countHours2 = ExitMagazin2 - EnterMagazin2 + 1;
int countHours3 = ExitMagazin3 - EnterMagazin3 + 1;


int[] size1 = CreateArray(countHours1);
int[] size2 = CreateArray(countHours2);
int[] size3 = CreateArray(countHours3);


Fill(size1, EnterMagazin1);
Fill(size2, EnterMagazin2);
Fill(size3, EnterMagazin3);


PrintData("Интервал времени: ", EnterMagazin1.ToString());
PrintData("-", ExitMagazin1.ToString());
Console.WriteLine();
PrintData("Интервал времени: ", EnterMagazin2.ToString());
PrintData("-", ExitMagazin2.ToString());
Console.WriteLine();
PrintData("Интервал времени: ", EnterMagazin3.ToString());
PrintData("-", ExitMagazin3.ToString());


int[] result = FindOverlap(size1, size2, size3);
Console.WriteLine();
Console.WriteLine("Наибольший промежуток времени: ");
PrintArray(result);