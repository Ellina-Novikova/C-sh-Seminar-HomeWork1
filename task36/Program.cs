// Задача 36. Задать одномерный массив, заполненный случайными числами.
// Найти сумму элементов, стоящих на нечетных позициях.

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

int SumUnEvenArray(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

Console.WriteLine("Введите количество элементов массива!");
int[] array1 = new int[Convert.ToInt32(Console.ReadLine())];
FillArrayRandom(array1, -10, 10);
PrintArray(array1);
Console.WriteLine("Сумма элементов с нечетными индексами = " + SumUnEvenArray(array1));