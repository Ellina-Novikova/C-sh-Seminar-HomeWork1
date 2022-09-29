// Программа задаёт массив из 8 элементов и выводит их на экран.

void FillArrayRandom(int[] arr) //Наполняем массив случ.числами от 1 до 99
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 100);        
    }
}

void FillArrayRead(int[] arr)  //Наполняем массив с клавиатуры
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i} элемент массива");
        arr[i] = Convert.ToInt32(Console.ReadLine());        
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

int[] arrayRandom = new int[8];
int[] arrayRead = new int[8];
FillArrayRandom(arrayRandom);
FillArrayRead(arrayRead);
Console.Write("Рандомный массив:  ");
PrintArray(arrayRandom);
Console.Write("Введенный массив:  ");
PrintArray(arrayRead);
