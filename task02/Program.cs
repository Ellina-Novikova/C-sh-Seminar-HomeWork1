// Задача №2. Определить максимальное и минимальное из двух чисел

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

int maxnumber, minnumber;

if (number1 > number2)
{
    maxnumber = number1;
    minnumber = number2;
}
else
{
    maxnumber = number2;
    minnumber = number1; 
}

Console.Write("Max = ");
Console.WriteLine(maxnumber);
Console.Write("Min = ");
Console.WriteLine(minnumber);