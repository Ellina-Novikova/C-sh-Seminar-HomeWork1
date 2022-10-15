// Задача №56. Задайть прямоугольный двумерный массив. 
//Ннайти строку с наименьшей суммой элементов.

int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetRandomValue(int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue + 1);
}

void FillArray(int[,] arr, int minValue, int maxValue)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = GetRandomValue(minValue,maxValue);
        }
    }
}

void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] InitializateArray(int m, int n)
{
    return new int[m,n];
}

int SummLineArray(int[,] array, int lineIndex)
{
    int summ = 0;
    for(int j = 0; j < array.GetLength(1); j++)
    {
        summ += array[lineIndex,j];
    }
    return summ;
}

int MinLineIndexArray(int[,] arr)
{
    int minLineIndex = 0;
    int min = SummLineArray(arr, minLineIndex);
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (SummLineArray(arr, i) < min) 
        {
            min = SummLineArray(arr, i);
            minLineIndex = i;
        }
    }
    return minLineIndex;
}

//КОД ОСНОВНОЙ ПРОГРАММЫ
int m = GetNumberFromConsole("Введите размерность массива m");
int n = GetNumberFromConsole("Введите размерность массива n");
int[,] array = InitializateArray(m,n);
int minValue = GetNumberFromConsole("Введите минимальное число, допустимое в массиве");
int maxValue = GetNumberFromConsole("Введите максимальное число, допустимое в массиве");
FillArray(array,minValue,maxValue);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Наименьшая сумма элементов в {MinLineIndexArray(array) + 1} строке");
