// Задача №13. Выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// int EnterNumber()
// {
//     Console.WriteLine("Введите число ");
//     return Convert.ToInt32(Console.ReadLine());
// }

int TherdDigit(int arg)
{
    if (arg < 100) //1 и 2 значные
    {
        return -1;
    }
    else
    {
        if (arg < 1000)  // 3-х значные
        {
            return arg % 10;
        }
        else
        {
            if (arg < 10000)  // 4-х значные
            {
                return (arg % 100) / 10;
            }
            else
            {
                if (arg < 100000)  // 5-ти значные
                {
                    return (arg % 1000) / 100;
                }
                else 
                {
                    if (arg < 1000000)  // 6-ти значные
                    {
                        return (arg % 10000) / 1000;
                    }
                    else
                    {
                        if (arg < 10000000)  // 7-ми значные
                        {
                            return (arg % 100000) / 10000;
                        }
                        else return (arg % 1000000) / 100000;  // 8-ми значные
                    }
                }
            }
        }
    }
}

int number = 45267891;
Console.WriteLine(TherdDigit(number));
