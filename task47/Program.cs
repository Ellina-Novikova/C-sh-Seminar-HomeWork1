// Задача №47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

double GetDoubleNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToDouble(Console.ReadLine());
}

// Ввод с консоли границ диапазона.
double[] GetExtremeVoluesFromConsole()
{
    double[] extremeVolues = new double[2];    
    extremeVolues[0] = GetDoubleNumberFromConsole("Введите MIN значение диапазона");    
    extremeVolues[1] = GetDoubleNumberFromConsole("Введите MAX значение диапазона");
     while (extremeVolues[1] <= extremeVolues[0])
    {
        Console.WriteLine("Ошибка! MIN значение не может быть <= MAX!");        
        extremeVolues = GetExtremeVoluesFromConsole();
    }
    return extremeVolues;
}

// Случайное вещественное число с округлением до 2-х знаков после запятой
// в диапазоне от extremeVolues[0] до extremeVolues[1].
double GetRandomDoubleValue(double[] extremeVolues)
{
    int tempNumber = new Random().Next(
                    Convert.ToInt32(extremeVolues[0]), 
                    Convert.ToInt32(extremeVolues[1])); // tempNumber = целое число в заданном диапазоне. 
    return Math.Round(new Random().NextDouble() + tempNumber, 2);     
}

// Наполнение массива случайными вещественными числами
// в диапазоне от extremeVolues[0] до extremeVolues[1].
void FillArrayRandomDouble(double[,] array, double[] extremeVolues)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = GetRandomDoubleValue(extremeVolues);
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
