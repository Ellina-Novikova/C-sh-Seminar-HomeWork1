// Задача №27. Программа принимает на вход число 
// и выдаёт сумму цифр в числе.

int GetNumber()
{
    Console.WriteLine("Введите число!");
    return Convert.ToInt32(Console.ReadLine());
}

int GetDigCount(int num)  // количество цифр в числе
{
    int count = 0;
    for (int i = 1; num > 0; i++)
    {
        num = num / 10;
        count ++;
    }
    return count;
}

int SummDigit(int number)   // Сумма цифр числа
{
    int summ = 0;
    int digree = GetDigCount(number);
    for (int i = 1; i <= digree; i++)
    {
        summ = summ + (number % 10);
        number = number / 10;
    }
    return summ;
}

int A = GetNumber();
Console.WriteLine($"Сумма цифр числа {A} = {SummDigit(A)}");



