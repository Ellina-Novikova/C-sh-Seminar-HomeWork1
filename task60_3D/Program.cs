// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.

int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetRandomValue(int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue + 1);
}

bool CheckUnicumNumber (int[,,] arr, int rowIndex, int collumnIndex, int zLineIndex)
{      
    for(int k = 0; k < arr.GetLength(2); k++)
    {
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            int j = 0; 
            while (j < arr.GetLength(1))
            {                    
                if(i == rowIndex && j == collumnIndex && k == zLineIndex)
                    return true;
                if(arr[i,j,k] == arr[rowIndex,collumnIndex,zLineIndex]) 
                    return false;                
                else j++;
            }
        }
    }     
    return true;  
}

void FillArrayUnicum(int[,,] arr, int minValue, int maxValue)
{
    
    for(int k = 0; k < arr.GetLength(2); k++)
    {
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i,j,k] = GetRandomValue(minValue,maxValue);
                while (!CheckUnicumNumber (arr, i, j, k))
                {
                    arr[i,j,k] = GetRandomValue(minValue,maxValue);
                }
            }
        }
    }
}

void PrintArray(int[,,] arr)
{
    for(int k = 0; k < arr.GetLength(2); k++)
    {
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i,j,k]}({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();     
    }
}

int[,,] InitializateArray(int m, int n, int k)
{
    return new int[m,n,k];
}

//КОД ОСНОВНОЙ ПРОГРАММЫ
int m = GetNumberFromConsole("Введите размерность массива m");
int n = GetNumberFromConsole("Введите размерность массива n");
int k = GetNumberFromConsole("Введите размерность массива k");   
int[,,] array = InitializateArray(m,n,k);
int minValue = 10;
int maxValue = 99;
if ((m * n * k) > (maxValue - minValue + 1))
    Console.WriteLine($"Невозможно наполнить массив {m}*{n}*{k} " +
                    $"уникальными числами от {minValue} до {maxValue}"); 
else
{
    FillArrayUnicum(array,minValue,maxValue);
    PrintArray(array);
}

