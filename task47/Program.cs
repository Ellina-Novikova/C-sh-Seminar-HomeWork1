// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

double GetRandomDoubleValue(double minValue, double maxValue)
{
    int tempNumber = new Random().Next(Convert.ToInt32(minValue), Convert.ToInt32(maxValue));
    // double tempVolume = new Random().NextDouble() + tempNumber;
    return Math.Round(new Random().NextDouble() + tempNumber, 2);  
    // double tempValue = new Random().NextDouble() + minValue + 1 - Math.Abs(minValue);
    // return Math.Round(tempValue, 2);
}

void FillArrayRandomDouble(double[,] array, double minValue, double maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = GetRandomDoubleValue(minValue, maxValue);
        }
    }
}

void PrintArray(double[,] arr)
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

int m = 3;
int n = 4;
double[,] array1 = new double[m, n];
double minValue = -10;
double maxValue = 10;
FillArrayRandomDouble(array1, minValue, maxValue);
PrintArray(array1);
