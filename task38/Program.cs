// Задача №38. Задать массив вещественных чисел. 
//Найти разницу между максимальным и минимальным элементов массива.

void FillArrayRandom(int[] arr, int from, int to) //Наполняем массив случ.числами от from до to
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(from, to + 1);        
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}

int DiffMaxMinArray(int[] array)   // Вариант 1. Разница максимального и минимального элементов
{
    int min = array[0];  // Минимальный элемент массива array
    int max = array[0];  // Максимальный элемент массива array
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
        if (array[i] > max)
            max = array[i];
    }
    return max - min;
}


int[] MinMaxArray(int[] array)  // Вариант 2. Поиск Миниимального и Максимального
{
    int[] minmax = new int[2];
    minmax[0] = array[0];  // Минимальный элемент массива array
    minmax[1] = array[0];  // Максимальный элемент массива array
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minmax[0])
            minmax[0] = array[i];
        if (array[i] > minmax[1])
            minmax[1] = array[i];
    }
    return minmax;
}


int[] MinMaxDiffArray(int[] array)   // Вариант 3. Минимальный, максимальный и разница
{
    int[] minMaxDiff = new int[3];
    minMaxDiff[0] = array[0];  // Минимальный элемент массива array
    minMaxDiff[1] = array[0];  // Максимальный элемент массива array
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minMaxDiff[0])
            minMaxDiff[0] = array[i];
        if (array[i] > minMaxDiff[1])
            minMaxDiff[1] = array[i];
    }
    minMaxDiff[2] = minMaxDiff[1] - minMaxDiff[0];  // разница Макс и Мин
    return minMaxDiff;
}


Console.WriteLine("Введите количество элементов массива!");
int[] array1 = new int[Convert.ToInt32(Console.ReadLine())];
FillArrayRandom(array1, 1, 100);
PrintArray(array1);
Console.WriteLine("MAX - MIN = " + DiffMaxMinArray(array1));  // Вывод для Варианта 1


// int[] outMinMax = new int[2];   // Вывод для Варианта 2
// outMinMax = MinMaxArray(array1);
// Console.WriteLine("MIN элемент массива = " + outMinMax[0]);
// Console.WriteLine("MAX элемент массива = " + outMinMax[1]);
// Console.WriteLine("MAX - MIN = " + (outMinMax[1] - outMinMax[0]));

// Console.WriteLine("MIN элемент массива = " + MinMaxArray(array1)[0]);  // Или Вывод для Варианта 2
// Console.WriteLine("MAX элемент массива = " + MinMaxArray(array1)[1]);
// Console.WriteLine("MAX - MIN = " + (MinMaxArray(array1)[1] - MinMaxArray(array1)[0]));

// Console.WriteLine("MIN элемент массива = " + MinMaxDiffArray(array1)[0]);   // Вывод для Варианта 3.
// Console.WriteLine("MAX элемент массива = " + MinMaxDiffArray(array1)[1]);
// Console.WriteLine("MAX - MIN = " + MinMaxDiffArray(array1)[2]);