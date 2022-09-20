// Задача №8. Показать все четные числа от 1 до N
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

int n = 2;
if (n <= N)
{
    Console.WriteLine("Четные числа от 1 до " + N + ":");
    while (n <= N)
{
   
   Console.WriteLine(n); 
   n += 2;
}
}
else Console.WriteLine("Нет четных чисел от 1 до " + N);
