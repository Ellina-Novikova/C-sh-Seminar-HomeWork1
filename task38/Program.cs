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

int DiffMaxMinArray(int[] array)   // Разница максимального и минимального элементов
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

Console.WriteLine("Введите количество элементов массива!");
int[] array1 = new int[Convert.ToInt32(Console.ReadLine())];
FillArrayRandom(array1, 1, 100);
PrintArray(array1);
Console.WriteLine("MAX - MIN = " + DiffMaxMinArray(array1));  
