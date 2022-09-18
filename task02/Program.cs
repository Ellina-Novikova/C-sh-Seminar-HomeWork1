// Задача №2. Определить максимальное и минимальное из двух чисел

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.Write("Max = ");
    Console.WriteLine(number1);
    Console.Write("Min = ");
    Console.WriteLine(number2);
}
else
{
    Console.Write("Max = ");
    Console.WriteLine(number1);
    Console.Write("Min = ");
    Console.WriteLine(number2);
}
