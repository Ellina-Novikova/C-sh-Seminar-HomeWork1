// Задача №41. Пользователь вводит с клавиатуры M чисел. 
// Посчитать, сколько чисел больше 0 ввёл пользователь.

void FillArray(int[] arr) //Наполняем массив 
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} числo");
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

int CheckPositivArray(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            count ++;
    }
    return count;
}

int M = 5;
int[] array = new int[M];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Вы ввели {CheckPositivArray(array)} положительных чисел");
