// Задача №66. Задать значения M и N. 
// Найти сумму натуральных элементов в промежутке от M до N.

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

// Вывод натуральных чисел для любых startNumber и lastNumber
void WriteNumbersFrom(double startNumber, double lastNumber)
{
    if (startNumber < 1 && lastNumber < 1) Console.WriteLine($"Нет натуральных чисел от {startNumber} до {lastNumber}");
    else
    {
        if (startNumber < 1) startNumber = 1;
        if (lastNumber < 1) lastNumber = 1;
        if (startNumber < lastNumber) WriteNumbersTo(GetBigInt(startNumber), GetSmallInt(lastNumber));    
        else
        {    
            int startIntNumber = GetSmallInt(startNumber);
            int lastIntNumber = GetBigInt(lastNumber);
            if (startIntNumber > lastIntNumber)
            {
                Console.Write(startIntNumber + ", ");
                WriteNumbersFrom(startNumber - 1, lastNumber);
            }
            else Console.WriteLine(lastIntNumber);
        }
    }    
}

// Сумма натуральных чисел от startNumber до lastNumber
int GetSummNatutal(double startNumber, double lastNumber)
{
    int summNatural = 0;
    if (startNumber < 1 && lastNumber < 1) return summNatural = 0;
    else
    {
        if (startNumber < 1 && lastNumber >= 1) startNumber = 1;
        if (startNumber >= 1 && lastNumber < 1) lastNumber = 1;
       
        if (startNumber >= 1 && lastNumber >= 1)
        {                
            if (startNumber > lastNumber)
            {
                double temp = startNumber;
                startNumber = lastNumber;
                lastNumber = temp;
            }
            int startIntNumber = GetBigInt(startNumber);
            int lastIntNumber = GetSmallInt(lastNumber);
            
            if (startIntNumber == lastIntNumber) return startIntNumber;
            else return startIntNumber + GetSummNatutal(startNumber + 1, lastNumber);    
        }
    } 
    return summNatural;   
}           

//КОД ОСНОВНОЙ ПРОГРАММЫ
double numberFrom = GetNumberFromConsole("Введите число M");
double numberTo = GetNumberFromConsole("Введите число N");
Console.WriteLine();
Console.WriteLine($"Натуральные числа от {numberFrom} до {numberTo}:");
WriteNumbersFrom(numberFrom,numberTo);
Console.WriteLine($"Сумма равна {GetSummNatutal(numberFrom, numberTo)}");

