// Программа задаёт массив из 8 элементов и выводит их на экран.

void FillArray(int[] arr) //Наполняем массив случ.числами от 1 до 99
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 100);        
    }
}

// void FillArray(int[] arr)  //Наполняем массив с клавиатуры
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
    Console.WriteLine();
}

void PrintArray53(int[] array)  // Вывод групп по 5 и 3 элемента массива
{
    Console.Write("[");  // выводим первые 5 элементов
    for (int i = 0; i < 4; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[4] + "]");
    Console.WriteLine();
    
    Console.Write("[");   // выводим остальные 3 элемента
    for (int j = 5; j < 7; j++)
    {
        Console.Write(array[j] + ", ");
    }
    Console.WriteLine(array[7] + "]");
}

int[] array8 = new int[8];
FillArray(array8);
PrintArray(array8);
PrintArray53(array8);
