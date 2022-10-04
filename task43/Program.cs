// Задача №43. Вариант 1.  Найти точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.


void InterPoint(int argK1, int argB1, int argK2, int argB2)
{
    if (argK1 == argK2)
        Console.WriteLine("Точка пересечения не найдена");
    else
    {
        int x = (argB2 - argB1) / (argK1 - argK2);
        int y = argK1 * x + argB1;
        Console.WriteLine($"Точка пересечения: х={x}, y={y}");
    }
}

Console.WriteLine("Введите значение k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Для прямых y={k1}*x+({b1}) и y={k2}*x+({b2})");
InterPoint(k1, b1, k2, b2);


