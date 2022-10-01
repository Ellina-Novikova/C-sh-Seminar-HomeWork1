// Задача №34. Заполнить массив случайными положительными трехзначными числами.
// Показать количество четных чисел в массиве.

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

int CountEvenArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}

Console.WriteLine("Введите количество элементов массива!");
int[] array1 = new int[Convert.ToInt32(Console.ReadLine())];
FillArrayRandom(array1, 100, 999);
PrintArray(array1);
Console.WriteLine("Количество четных элементов массива = " + CountEvenArray(array1));