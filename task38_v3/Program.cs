// Задача №38. Вариант 3 (через массив [3]). Задать массив вещественных чисел. 
//Найти разницу между максимальным и минимальным элементами массива.

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

int[] MinMaxDiffArray(int[] array)   // Вариант 3. Минимальный, максимальный и разница
{
    int[] minMaxDiff = new int[3];
    minMaxDiff[0] = array[0];  // Минимальный элемент массива array
    minMaxDiff[1] = array[0];  // Максимальный элемент массива array
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minMaxDiff[0])
            minMaxDiff[0] = array[i];
        if (array[i] > minMaxDiff[1])
            minMaxDiff[1] = array[i];
    }
    minMaxDiff[2] = minMaxDiff[1] - minMaxDiff[0];  // разница Макс и Мин
    return minMaxDiff;
}


Console.WriteLine("Введите количество элементов массива!");
int[] array1 = new int[Convert.ToInt32(Console.ReadLine())];
FillArrayRandom(array1, 1, 100);
PrintArray(array1);
Console.WriteLine("MIN элемент массива = " + MinMaxDiffArray(array1)[0]); 
Console.WriteLine("MAX элемент массива = " + MinMaxDiffArray(array1)[1]);
Console.WriteLine("MAX - MIN = " + MinMaxDiffArray(array1)[2]);
