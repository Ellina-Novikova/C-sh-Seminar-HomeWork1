// Задача №10. Принимает на вход трехзначное число, 
// на выходе показывает вторую цифру этого числа.

int EnterNumber()
{
    Console.WriteLine("Введите число от 100 до 999");
    return Convert.ToInt32(Console.ReadLine());
}

int SecondDigit(int number)
{
    int Decimal = (number % 100) / 10;
    return Decimal;     
}

int a = EnterNumber();
Console.WriteLine(SecondDigit(a));