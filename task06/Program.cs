// Задача №6. Является ли принятое число четным

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
double rem = number % 2;

if (rem == 0)
{
   Console.WriteLine("Это ЧЕТНОЕ число"); 
}
else
{
   Console.WriteLine("Это НЕЧЕТНОЕ число");
}