// Задача №23. Принимает число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

int GetNumber()
{
    Console.WriteLine("Введите число!");
    return Convert.ToInt32(Console.ReadLine());
}

void TabCube(int number)
{
    Console.WriteLine("Таблица кубов от 1 до " + number + ":");
    int count = 1;
    while (count <= number)
    {
        Console.WriteLine(count + " в кубе = " + Math.Pow(count, 3));
        count ++;
    }
}

TabCube(GetNumber());
