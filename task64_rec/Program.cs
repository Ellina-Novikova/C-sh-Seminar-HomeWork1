// Задача №64. Задать значение N.
// Вывести все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

double GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToDouble(Console.ReadLine());
}

int GetBigInt(double number) // Округление в большую сторону.
{
    int numberInt = Convert.ToInt32(number);
    if (numberInt < number) numberInt +=1;            
    return numberInt;
}

int GetSmallInt(double number) // Округление в меньшую сторону.
{
    int numberInt = Convert.ToInt32(number);
    if (numberInt > number) numberInt -=1;
    return numberInt;
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

// Вывод натуральных чисел общий
void WriteNumbersFrom(double startNumber, int lastNumber)
{
    if (startNumber < 1) startNumber = 1;
    if (startNumber < lastNumber) WriteNumbersTo(GetBigInt(startNumber), lastNumber);    
    else
    {    
        int startIntNumber = GetSmallInt(startNumber);        
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
int lastNumber = 1;
Console.WriteLine();
Console.WriteLine($"Натуральные числа от {number} до {lastNumber}:");
WriteNumbersFrom(number,lastNumber);
