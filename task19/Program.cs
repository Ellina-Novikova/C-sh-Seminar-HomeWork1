// Задача №19. Принимает 5-ти значное число
// и проверяет яляется ли оно палиндромом.

int GetNumber()
{
    Console.WriteLine("Введите ПЯТИЗНАЧНОЕ число!");
    return Convert.ToInt32(Console.ReadLine());   
}

bool Num5digit(int arg)
{
    return (Math.Abs(arg) >= 10000 && Math.Abs(arg) <= 99999);
}

void Palindrom(int N)
{
    if (N / 10000 == N % 10 && N % 10000 / 1000 == N % 100 / 10)
        Console.WriteLine("Да, это палиндром!");
    else
        Console.WriteLine("Нет, это не палиндром!"); 
}


int a = GetNumber();
if (Num5digit(a))
    Palindrom(a);
else
    Console.WriteLine("Ошибка! " + a + " не пятизначное число.");


