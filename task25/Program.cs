// Задача №25. цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

int GetNumber()
{
Console.WriteLine("Введите число");
return Convert.ToInt32(Console.ReadLine());
}

int Expo(int arg1, int arg2)
{
    int expo = 1;
    for(int i= 1; i <= Math.Abs(arg2); i++)
    {
        expo = expo * arg1;
    }
    return expo;
}
int A = GetNumber();
int B = GetNumber();
Console.WriteLine($"{A} в степени {Math.Abs(B)} = {Expo(A, B)}");