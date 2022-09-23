// Задача №13. Выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. (Вариант для чисел любой разрядности)

int EnterNumber()
{
    Console.WriteLine("Введите число ");
    return Convert.ToInt32(Console.ReadLine());
}

int TherdDigit(int arg)
{
    int therdDigit;
    int n = 1;  
    if (arg < 100) //1 и 2 значные
    {
        Console.Write("Нет третьей цифры. ");
        return therdDigit = -1;
    }
    else
    {
        while (arg / (n * 100) >= 1)
        {
            n = n * 10;
        }
        Console.Write("Третья цифра ");
        return therdDigit = (arg % n) / (n / 10);
    }
}

Console.WriteLine(TherdDigit(EnterNumber()));
