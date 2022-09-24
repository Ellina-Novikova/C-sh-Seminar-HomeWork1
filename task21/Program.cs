// Задача №21.Принимает координаты 2-х точек
// вычисляет и выдает расстояние между точками в 3Д пространстве

double GetNumber(string name)
{
    Console.WriteLine("Введите координату " + name);
    return Convert.ToDouble(Console.ReadLine());
}

double Distanse3D(double x1, double y1,double z1, 
                double x2,double y2, double z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + 
                    Math.Pow((y2 - y1), 2) + 
                    Math.Pow((z2 - z1), 2));
}

double x1 = GetNumber("x1");
double y1 = GetNumber("y1");
double z1 = GetNumber("z1");
double x2 = GetNumber("x2");
double y2 = GetNumber("y2");
double z2 = GetNumber("z2");
Console.WriteLine("Расстояние между точками = " + 
                Distanse3D(x1, y1, z1, x2, y2, z2));