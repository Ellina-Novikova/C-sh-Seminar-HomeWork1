// Задача №38. Вариант 2 (через массив [2]). Задать массив вещественных чисел. 
//Найти разницу между максимальным и минимальным элементами массива.

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

int[] MinMaxArray(int[] array)  // Поиск Миниимального и Максимального
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

Console.WriteLine("Введите количество элементов массива!");
int[] array1 = new int[Convert.ToInt32(Console.ReadLine())];
FillArrayRandom(array1, 1, 100);
PrintArray(array1);
// int[] outMinMax = new int[2];                                // Вариант вывода подробный
// outMinMax = MinMaxArray(array1);
// Console.WriteLine("MIN элемент массива = " + outMinMax[0]);
// Console.WriteLine("MAX элемент массива = " + outMinMax[1]);
// Console.WriteLine("MAX - MIN = " + (outMinMax[1] - outMinMax[0]));
Console.WriteLine("MIN элемент массива = " + MinMaxArray(array1)[0]);  // Вариант вывода сокрвщенный
Console.WriteLine("MAX элемент массива = " + MinMaxArray(array1)[1]);
Console.WriteLine("MAX - MIN = " + (MinMaxArray(array1)[1] - MinMaxArray(array1)[0]));
