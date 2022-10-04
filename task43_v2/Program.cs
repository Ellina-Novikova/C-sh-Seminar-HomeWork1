// Задача №43. Вариант 2. Найти точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

void FillArray(double[,] arr)   // arr[0,0]=k1, arr[0,1]=b1, arr[1,0]=k2, arr[1,1]=b2,
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.WriteLine($"Введите коэффициент {j + 1} для прямой {i +1}");
            arr[i,j] = Convert.ToDouble(Console.ReadLine());
        }
               
    }
}


void InterPointArr(double[,] arg)  //// arg[0,0]=k1, arg[0,1]=b1, arg[1,0]=k2, arg[1,1]=b2
{
    Console.WriteLine($"Для прямых y={arg[0,0]}*x+({arg[0,1]}) и y={arg[1,0]}*x+({arg[1,1]})");
    if (arg[0,0] == arg[1,0])
        Console.WriteLine("Точка пересечения не найдена");
    else
    {
        double x = (arg[1,1] - arg[0,1]) / (arg[0,0] - arg[1,0]);
        double y = arg[0,0] * x + arg[0,1];
        Console.WriteLine($"Точка пересечения: х={x}, y={y}");
    }
}

double[,] coeff = new double[2,2];
FillArray(coeff);
InterPointArr(coeff);
