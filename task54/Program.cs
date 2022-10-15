// Задача №54. Задайть двумерный массив. 
// Упорядочить по убыванию элементы каждой строки двумерного массива.

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

void SelectionSortInLine(int[,] array, int lineIndex)
{
    for(int j = 0; j < array.GetLength(1) - 1; j++)
    {
        int maxPosition = j;
        for(int k = j + 1; k < array.GetLength(1); k++)
        {
            if (array[lineIndex,k] > array[lineIndex,maxPosition]) maxPosition = k;
        }
        int temporary = array[lineIndex,j];
        array[lineIndex,j] = array[lineIndex,maxPosition];
        array[lineIndex,maxPosition] = temporary;
    }
}

void SortArrayLines(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        SelectionSortInLine(arr, i);
    }
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
SortArrayLines(array);
Console.WriteLine();
PrintArray(array);