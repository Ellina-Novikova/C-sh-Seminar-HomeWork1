// Задача №15. Принимает цифру от 1 до 7 (дни недели)
// и проверяет, является ли этот день выходным сб-вс(6 или 7)

int EnterNumber()
{
    Console.WriteLine("Введите число от 1 до 7");
    return Convert.ToInt32(Console.ReadLine());
}
 
void HollyDay(int number)
{
    if (number >= 6)
    {
        Console.WriteLine("Выходной день");
    }
    else
    {
        Console.WriteLine("Рабочий день");
    }
}

int a = EnterNumber();
HollyDay(a);
