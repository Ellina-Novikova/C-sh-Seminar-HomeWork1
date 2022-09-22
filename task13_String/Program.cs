// Задача №13. Выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

string EnterNumber()
{
     Console.WriteLine("Введите число ");
     return Console.ReadLine();
}

void TherdDigit(string arg)
{
    if (arg.Length < 3)
    {
        Console.WriteLine ("У числа нет третьей цифры");
    }
    else
    {
    int startIndex = 2;
    int length = 1;
    string therdDigit = arg.Substring(startIndex, length);
    Console.WriteLine("Третья цифра  " + therdDigit);
    }
}

string number = EnterNumber();
TherdDigit(number);
