// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

// Ввод с консоли границ диапазона.
double[] GetExtremeVoluesFromConsole()
{
    double[] extremeVolumes = new double[2];
    Console.WriteLine("Введите MIN значение диапазона");
    extremeVolumes[0] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите MAX значение диапазона");
    extremeVolumes[1] = Convert.ToDouble(Console.ReadLine());
    return extremeVolumes;
}

// Случайное вещественное число с округлением до 2-х знаков после запятой
// в диапазоне от extremeVolumes[0] до extremeVolumes[1].
double GetRandomDoubleValue(double[] extremeVolumes)
{
    int tempNumber = new Random().Next(
                    Convert.ToInt32(extremeVolumes[0]), 
                    Convert.ToInt32(extremeVolumes[1])); // tempNumber = целое число в заданном диапазоне. 
    return Math.Round(new Random().NextDouble() + tempNumber, 2);     
}

// Наполнение массива случайными вещественными числами
// в диапазоне от extremeVolumes[0] до extremeVolumes[1].
void FillArrayRandomDouble(double[,] array, double[] extremeVolumes)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = GetRandomDoubleValue(extremeVolumes);
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

// Основная программа.
int m = GetNumberFromConsole("Введите количество строк массива");
int n = GetNumberFromConsole("Введите количество столбцов массива");
double[,] array1 = new double[m, n];
double[] range = GetExtremeVoluesFromConsole(); // Границы возможных значений.
FillArrayRandomDouble(array1, range);
PrintArray(array1);
