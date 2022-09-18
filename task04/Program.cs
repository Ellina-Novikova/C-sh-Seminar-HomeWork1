// Задача №4. Найти максимум из трех чисел

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int number3 = Convert.ToInt32(Console.ReadLine());

int maxnumber = number1;

if (number2 > maxnumber) maxnumber = number2;
if (number3 > maxnumber) maxnumber = number3;

    Console.Write("Max = ");
    Console.WriteLine(maxnumber);
   