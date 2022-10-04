// Задача №43. Вариант 1.  Найти точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.


void InterPoint(double argK1, double argB1, double argK2, double argB2)
{
    if (argK1 == argK2)
        Console.WriteLine("Точка пересечения не найдена");
    else
    {
        double x = (argB2 - argB1) / (argK1 - argK2);
        double y = argK1 * x + argB1;
        Console.WriteLine($"Точка пересечения: х={x}, y={y}");
    }
}

Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Для прямых y={k1}*x+({b1}) и y={k2}*x+({b2})");
InterPoint(k1, b1, k2, b2);


