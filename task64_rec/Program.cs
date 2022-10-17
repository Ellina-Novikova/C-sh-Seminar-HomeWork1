// Задача №64. Задать значение N.
// Вывести все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

double GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToDouble(Console.ReadLine());
}

// Вывод натуральных чисел по возрастанию
void WriteNumbersTo(int startNumber, int lastNumber)
{
    if (startNumber < lastNumber)
    {
        Console.Write(startNumber + ", ");
        WriteNumbersTo(startNumber+1, lastNumber);
    }
    else Console.WriteLine(startNumber);     
}

// 
void WriteNumbersFrom(double startNumber, int lastNumber)
{
    if (startNumber <= 0) startNumber = 1;
    if (startNumber < lastNumber) WriteNumbersTo(Convert.ToInt32(startNumber), lastNumber);    
    else
    {    
        int startIntNumber = Convert.ToInt32(startNumber);
        if (startIntNumber > startNumber) startIntNumber -=1;
        if (startIntNumber > lastNumber)
        {
            Console.Write(startIntNumber + ", ");
            WriteNumbersFrom(startNumber - 1, lastNumber);
        }
        else Console.WriteLine(lastNumber);
    }    
}

// Основная программа
double number = GetNumberFromConsole("Введите число");
Console.WriteLine();
WriteNumbersFrom(number,1);
