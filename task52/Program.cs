// Задача №52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

// Ввод с консоли границ диапазона.
int[] GetExtremeVoluesFromConsole()
{
    int[] extremeVolues = new int[2];
    Console.WriteLine("Введите MIN значение диапазона");
    extremeVolues[0] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите MAX значение диапазона");
    extremeVolues[1] = Convert.ToInt32(Console.ReadLine());
    while (extremeVolues[1] <= extremeVolues[0])
    {
       Console.WriteLine("Ошибка! MIN значение не может быть <= MAX!");
       Console.WriteLine("Введите MIN значение диапазона");
       extremeVolues[0] = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Введите MAX значение диапазона");
       extremeVolues[1] = Convert.ToInt32(Console.ReadLine()); 
    }
    return extremeVolues;
}

// Случайное целое число в диапазоне от extremeVolues[0] до extremeVolues[1].
int GetRandomValue(int[] extremeVolues)
{
    return new Random().Next(extremeVolues[0], extremeVolues[1] + 1);
}

// Наполнение массива целыми числами в диапазоне
// от extremeVolues[0] до extremeVolues[1].
void FillArray(int[,] arr, int[] extremeVolues)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = GetRandomValue(extremeVolues);
        }
    }
}

void PrintArrayDuo(int[,] arr) // Печать двумерного массива int.
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + "  ");
        }
        Console.WriteLine();
    }
}

void PrintArrayUno(double[] arr) // Печать одномерного массива double.
{
    for(int i = 0; i < arr.Length; i++)
    {        
        Console.Write(arr[i] + "  ");        
    }
    Console.WriteLine();
}

// Суммы элементов в столбцах.
double[] SummsCollumnsArray(int[,] arr)
{
    double[] summsCollumns = new double[arr.GetLength(1)];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            summsCollumns[j] = summsCollumns[j] + arr[i,j];
        }        
    }
    return summsCollumns;
}

// Среднее арифметическое столбцов.
double[] AverageCollumnsArray(int[,] arr)
{    
    double[] averageCollumns = SummsCollumnsArray(arr);
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        averageCollumns[j] = Math.Round(averageCollumns[j] / arr.GetLength(0), 2);
    }   
    return averageCollumns;
}

//КОД ОСНОВНОЙ ПРОГРАММЫ
int m = GetNumberFromConsole("Введите количество строк массива");
int n = GetNumberFromConsole("Введите количество столбцов массива");
int[,] array1 = new int[m,n];
int[] range = GetExtremeVoluesFromConsole(); // Границы возможных значений.
FillArray(array1, range);
Console.WriteLine();
PrintArrayDuo(array1);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое каждого столбца массива:");
PrintArrayUno(AverageCollumnsArray(array1));
Console.WriteLine();
