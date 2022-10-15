// Задача №62. Написать программу, которая заполнит спирально массив 4 на 4.

int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillSpiralArray(int[,] arr, int minValue, int step)
{
    int value = minValue;
    int maxValue = step * arr.GetLength(0) * arr.GetLength(1) + minValue - 1;
    int iteration = 0;
    while (value <= maxValue)
    {
        // Заполнение верхней строки слева направо.
        for(int j = 0 + iteration; j < (arr.GetLength(1) - iteration); j++)
        {            
            if(value <= maxValue)
            {
                arr[0 + iteration,j] = value;
                value += step;
            }
        }
        // Заполнение правого столбца сверху вниз.
        for(int i = 1 + iteration; i < arr.GetLength(0) - iteration; i++)
        {
            if(value <= maxValue)
            {
                arr[i, arr.GetLength(1) - 1 - iteration] = value;
                value += step;
            }
        }
        // Заполнение нижней строки спава налево. 
        for(int j = (arr.GetLength(1) - 2 - iteration); j >= iteration; j--)
        {            
            if(value <= maxValue)
            {
                arr[arr.GetLength(0) - 1 - iteration,j] = value;
                value += step;
            }
        } 
        // Заполнение левого столбца снизу вверх.
        for(int i = (arr.GetLength(0) - 2 - iteration); i > iteration; i--)
        {
            if(value <= maxValue)
            {
            arr[i,0 + iteration] = value;
            value += step;
            }
        }
        iteration++;
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

//КОД ОСНОВНОЙ ПРОГРАММЫ
int m = 4;
int n = 4;
int[,] array = InitializateArray(m,n);
int minValue = GetNumberFromConsole("Введите минимальное число, допустимое в массиве");
int step = GetNumberFromConsole("Введите число = шаг последовательности");
FillSpiralArray(array,minValue,step);
PrintArray(array);
