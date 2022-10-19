// Задача №68. Вычисление функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int GetNumberFromConsole(string text)
{    
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    while (number < 0) GetNumberFromConsole(text);
    return number;
}

int AkkermanCalculation(int mValue, int nValue)
{    
    if (mValue == 0) return nValue + 1;
    if (mValue > 0 && nValue == 0) return AkkermanCalculation(mValue - 1, 1);
    else return AkkermanCalculation(mValue - 1, AkkermanCalculation(mValue, nValue - 1));
}

//КОД ОСНОВНОЙ ПРОГРАММЫ
int m = GetNumberFromConsole("Введите целое положительное число m");
int n = GetNumberFromConsole("Введите целое положительное число n");

Console.WriteLine();
Console.WriteLine($"A({m}, {n}) = {AkkermanCalculation(m,n)}");
