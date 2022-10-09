// Задача №50. на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента
// или же указание, что такого элемента нет.

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

// Ввод с консоли индексов элемента двумерного массива.
int[] GetIndexFromConsole()
{
    int[] elementIndex = new int[2];
    for (int i = 0; i < elementIndex.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} индекс элемента");
        elementIndex[i] = Convert.ToInt32(Console.ReadLine());
    }
    return elementIndex;
}

// Нахождение элемента массива по заданному индексу.
void FindeElementByIndex(int[,] array, int[] arrayIndex)
{
    if (arrayIndex[0] >= array.GetLength(0) ||
        arrayIndex[1] >= array.GetLength(1))
        Console.WriteLine($"Элемента с индексом [{arrayIndex[0]}, {arrayIndex[1]}] нет в заданном массиве!");
    else 
        Console.WriteLine("Элемент с индексом [" +
                        $"{arrayIndex[0]}, {arrayIndex[1]}] = " +
                        $"{array[arrayIndex[0], arrayIndex[1]]}"); 
}

//КОД ОСНОВНОЙ ПРОГРАММЫ
int m = 10;
int n = 10;
int[,] array1 = new int[m,n];
int[] range = GetExtremeVoluesFromConsole(); // Границы возможных значений.
FillArray(array1, range);
Console.WriteLine();
PrintArray(array1);
Console.WriteLine();
FindeElementByIndex(array1, GetIndexFromConsole());

