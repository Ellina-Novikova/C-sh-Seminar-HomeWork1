// Задача №58. Задайть две матрицы. Найти произведение двух матриц.

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

int[,] GetRandomArray(string text, int lines, int collumns)
{    
    int[,] array = InitializateArray(lines, collumns);
    int minValue = GetNumberFromConsole($"Введите минимальное число, допустимое в {text} массиве");
    int maxValue = GetNumberFromConsole($"Введите максимальное число, допустимое в {text} массиве");
    FillArray(array,minValue,maxValue);
    return array;
}

int[,] ProductArrays(int[,] arr1, int[,] arr2)
{
    int[,] product = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < product.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(0); j++)
        {
            for (int k = 0; k < arr2.GetLength(0); k++)
            {
                product[i,j] += arr1[i,k] * arr2[k,j];
            }            
        }        
    }
    return product;
}

//КОД ОСНОВНОЙ ПРОГРАММЫ
int m = GetNumberFromConsole("Введите размерность массива m");
int n = GetNumberFromConsole("Введите размерность массива n");
int[,] array1 = GetRandomArray("1", m, n);
int[,] array2 = GetRandomArray("2", n, m);
Console.WriteLine();
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
int[,] product = ProductArrays(array1, array2);
Console.WriteLine("Произведение массивов");
PrintArray(product);
